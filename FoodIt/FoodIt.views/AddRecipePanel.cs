﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;
using FoodIt.dtos;
using FoodIt.daos;

namespace FoodIt.views
{
    public partial class AddRecipePanel : UserControl
    {
        private List<Ingredient> ingredients;
        List<RecipeStep> recipeSteps = new List<RecipeStep>();
        List<RecipeIngredient> recipeIngredients = new List<RecipeIngredient>();
        private int stepIndex = 0;
        private User user;
        private string workingDirectory, projectDirectory;
        Dictionary<string, string> imagePaths = new Dictionary<string, string>();

        //file path temp
        private string tmpFilePath;

        public AddRecipePanel(User user)
        {
            InitializeComponent();
            this.user = user;
            
            // this function will always get the directory where your project is
            // whilst Environment.CurrentDicrectory isn't
            workingDirectory = AppDomain.CurrentDomain.BaseDirectory;
            projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        }

        private void AddRecipePanel_Load(object sender, EventArgs e)
        {
            LoadIngredientsAutoComplete();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string image = txtImage.Text;
            string description = txtDescription.Text;
            //validate
            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Maybe you forgot the name (title) of the recipe :v");
            }
            else if (string.IsNullOrWhiteSpace(image))
            {
                MessageBox.Show("Recipe with image will be more attractive :v");
            }
            else if (string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Maybe you forgot describe something about your recipe :v");
            }
            else
            {
                if (recipeIngredients.Count == 0 || recipeSteps.Count == 0)
                {
                    MessageBox.Show("Please add at least 1 ingredient and 1 step.");
                }
                else
                {
                    // data send to db here
                    Recipe recipe = new Recipe(user.Email, title, description, Recipe.DEFAULT_STATUS, DateTime.Now, image);

                    RecipeDAO recipeDAO = new RecipeDAO();
                    RecipeStepDAO recipeStepDAO = new RecipeStepDAO();
                    RecipeIngredientDAO recipeIngredientDAO = new RecipeIngredientDAO();
                    
                    int recipeID = recipeDAO.AddRecipe(recipe);
                    recipeDAO.UpdateImagePath(recipeID, image);

                    recipeStepDAO.AddRecipeSteps(recipeID, recipeSteps);
                    recipeIngredientDAO.AddRecipeIngredients(recipeID, recipeIngredients);

                    //save image
                    String path = projectDirectory + @"\resources\img\" + recipeID;
                    if (Directory.Exists(path) == false) //create folder with name is recipeID if it is not exist
                    {
                        Directory.CreateDirectory(path);
                    }
                    try
                    {
                        foreach (string imageName in imagePaths.Keys)
                        {
                            // if step image is null then let it be
                            if (string.IsNullOrWhiteSpace(imagePaths[imageName]))
                            {
                                continue;
                            }

                            string filename = Path.GetFileName(imagePaths[imageName]);
                            string destFile = Path.Combine(path, filename);
                            File.Copy(imagePaths[imageName], destFile, true);
                        }
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show("Unable to save file " + exp.Message);
                    }
                    MessageBox.Show("Add new recipe successful!");
                    ClearAll();
                }
            }
        }

        private void ClearAll()
        {
            txtIngredientAmount.Clear();
            txtIngredient.Clear();
            txtNote.Clear();
            txtImage.Clear();
            txtDescription.Clear();
            txtTitle.Clear();
            txtStepOrder.Clear();
            txtStepDescription.Clear();
            txtStepImage.Clear();
            recipeIngredients.Clear();
            recipeSteps.Clear();
            LoadAllSteps();
            LoadAllIngredients();
        }

        #region StepDetail
        private void btnStepImage_Click(object sender, EventArgs e)
        {
            stepFileDlg.ShowDialog();
        }

        private void stepFileDlg_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                //get image name and set to txtStepImage
                string imageName = stepFileDlg.SafeFileName;
                tmpFilePath = stepFileDlg.FileName;
                txtStepImage.Text = imageName;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Unable to open file " + exp.Message);
            }
            stepFileDlg.Dispose();
        }

        private void LoadAllSteps()
        {
            DataTable dtStep = new DataTable();
            dtStep.Columns.Add("StepOrder");
            dtStep.Columns.Add("Description");
            dtStep.Columns.Add("Image");
            for (int i = 0; i < recipeSteps.Count; i++)
            {
                DataRow dr = dtStep.NewRow();
                dr["StepOrder"] = recipeSteps[i].Id;
                dr["Description"] = recipeSteps[i].Description;
                dr["Image"] = recipeSteps[i].Image;
                dtStep.Rows.Add(dr);
            }
            txtStepOrder.DataBindings.Clear();
            txtStepDescription.DataBindings.Clear();
            txtStepImage.DataBindings.Clear();
            txtStepOrder.DataBindings.Add("Text", dtStep, "StepOrder");
            txtStepDescription.DataBindings.Add("Text", dtStep, "Description");
            txtStepImage.DataBindings.Add("Text", dtStep, "Image");
            dgvStepDetail.DataSource = dtStep;
        }
        private void UpdateStepOrder()
        {
            for (int i = 0; i < recipeSteps.Count; i++)
            {
                recipeSteps[i].Id = i + 1;
            }
            stepIndex = recipeSteps.Count;
        }

        private void btnAddStep_Click(object sender, EventArgs e)
        {
            int id;
            string description = txtStepDescription.Text;
            string image = txtStepImage.Text;
            if (string.IsNullOrWhiteSpace(description))
            {
                errProvider.SetError(txtStepDescription, "Description must not be blank!");
            }
            else
            {
                id = ++stepIndex;
                errProvider.SetError(txtStepDescription, "");
                errProvider.SetError(txtStepOrder, "");
                RecipeStep step = new RecipeStep(id, description, image);
                recipeSteps.Add(step);
                imagePaths.Add("Step" + stepIndex, tmpFilePath);
                LoadAllSteps();
            }
        }

        private void btnUpdateStep_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStepOrder.Text))
            {
                errProvider.SetError(txtStepOrder, "Please select the step you want to update.");
            }
            else if (string.IsNullOrWhiteSpace(txtStepDescription.Text))
            {
                errProvider.SetError(txtStepOrder, "");
                errProvider.SetError(txtStepDescription, "Description must not be blank!");
            }
            else
            {
                errProvider.SetError(txtStepOrder, "");
                errProvider.SetError(txtStepDescription, "");
                int id = int.Parse(txtStepOrder.Text);
                string description = txtStepDescription.Text;
                string image = txtStepImage.Text;
                RecipeStep updatedStep = new RecipeStep(id, description, image);
                for (int i = 0; i < recipeSteps.Count; i++)
                {
                    if (recipeSteps[i].Equals(updatedStep))
                    {
                        recipeSteps[i] = updatedStep;
                        break;
                    }
                }
                imagePaths["Step" + id] = tmpFilePath;
                LoadAllSteps();
            }
        }

        private void btnDeleteStep_Click(object sender, EventArgs e)
        {
            // add id to step for CRUD
            // NOTE: Don't pass this id attribute to db
            int id = int.Parse(txtStepOrder.Text);
            string description = txtStepDescription.Text;
            string image = txtStepImage.Text;
            RecipeStep updatedStep = new RecipeStep(id, description, image);
            for (int i = 0; i < recipeSteps.Count; i++)
            {
                if (recipeSteps[i].Equals(updatedStep))
                {
                    recipeSteps.RemoveAt(i);
                    break;
                }
            }
            UpdateStepOrder();
            LoadAllSteps();
        }
        #endregion

        #region IngredientDetail
        private void LoadIngredientsAutoComplete()
        {
            IngredientDAO dao = new IngredientDAO();
            ingredients = dao.GetAllIngredients();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (Ingredient ingredient in ingredients)
            {
                collection.Add(ingredient.Name);
            }
            txtIngredient.AutoCompleteCustomSource = collection;
        }

        private void btnRecipeImage_Click(object sender, EventArgs e)
        {
            recipeFileDlg.ShowDialog();
        }
        private void recipeFileDlg_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                //get image name and set to txtImage
                string imageName = recipeFileDlg.SafeFileName;
                string filePath = recipeFileDlg.FileName;
                if (imagePaths.ContainsKey("recipeImage"))
                {
                    imagePaths["recipeImage"] = filePath;
                }
                else
                {
                    imagePaths.Add("recipeImage", filePath);
                }
                txtImage.Text = imageName;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Unable to open file " + exp.Message);
            }
            recipeFileDlg.Dispose();
        }
        private void btnAddIngre_Click(object sender, EventArgs e)
        {
            IngredientDAO dao = new IngredientDAO();
            string name = txtIngredient.Text;
            int id = dao.GetIngredientIDByName(name);
            string amount = txtIngredientAmount.Text;
            string note = txtNote.Text;
            if (id > 0)
            {
                if (string.IsNullOrWhiteSpace(amount))
                {
                    errProvider.SetError(txtIngredientAmount, "Amount must not be blank.");
                }
                else
                {
                    errProvider.SetError(txtIngredientAmount, "");
                    RecipeIngredient ingredient = new RecipeIngredient(id, amount, note);
                    if (recipeIngredients.Contains(ingredient))
                    {
                        //Neu trong list da co ingredient roi thi chi duoc update hoac delete
                        MessageBox.Show(name + " has already existed. You can only update or delete it");
                    }
                    else
                    {
                        recipeIngredients.Add(ingredient);
                        LoadAllIngredients();
                        //clear ingredient field only
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid ingredient");
            }
        }
        private void btnUpdateIngre_Click(object sender, EventArgs e)
        {
            IngredientDAO dao = new IngredientDAO();
            string name = txtIngredient.Text;
            int id = dao.GetIngredientIDByName(name);
            string amount = txtIngredientAmount.Text;
            string note = txtNote.Text;
            if (id > 0)
            {
                if (string.IsNullOrWhiteSpace(amount))
                {
                    errProvider.SetError(txtIngredientAmount, "Amount must not be blank.");
                }
                else
                {
                    RecipeIngredient ingredient = new RecipeIngredient(id, amount, note);
                    for (int i = 0; i < recipeIngredients.Count; i++)
                    {
                        if (recipeIngredients[i].Equals(ingredient))
                        {
                            recipeIngredients[i] = ingredient;
                            break;
                        }
                    }
                    LoadAllIngredients();
                    //clear ingredient field only
                }
            }
            else
            {
                MessageBox.Show("Invalid ingredient");
            }
        }

        private void btnDeleteIngre_Click(object sender, EventArgs e)
        {
            IngredientDAO dao = new IngredientDAO();
            string name = txtIngredient.Text;
            int id = dao.GetIngredientIDByName(name);
            if (id > 0)
            {
                RecipeIngredient ingredient = new RecipeIngredient(id, null, null);
                for (int i = 0; i < recipeIngredients.Count; i++)
                {
                    if (recipeIngredients[i].Equals(ingredient))
                    {
                        recipeIngredients.RemoveAt(i);
                        break;
                    }
                }
                LoadAllIngredients();
                //clear ingredient field only
            }
            else
            {
                MessageBox.Show("Invalid ingredient");
            }
        }

        private void LoadAllIngredients()
        {
            IngredientDAO dao = new IngredientDAO();
            DataTable dtIngredient = new DataTable();
            dtIngredient.Columns.Add("IngredientID");
            dtIngredient.Columns.Add("IngredientName");
            dtIngredient.Columns.Add("Amount");
            dtIngredient.Columns.Add("Note");
            for (int i = 0; i < recipeIngredients.Count; i++)
            {
                DataRow dr = dtIngredient.NewRow();
                dr["IngredientID"] = recipeIngredients[i].IngredientID;
                dr["IngredientName"] = dao.GetIngredientNameByID(recipeIngredients[i].IngredientID);
                dr["Amount"] = recipeIngredients[i].AmountIngredient;
                dr["Note"] = recipeIngredients[i].Note;
                dtIngredient.Rows.Add(dr);
            }
            txtIngredient.DataBindings.Clear();
            txtIngredientAmount.DataBindings.Clear();
            txtNote.DataBindings.Clear();
            txtIngredient.DataBindings.Add("Text", dtIngredient, "IngredientName");
            txtIngredientAmount.DataBindings.Add("Text", dtIngredient, "Amount");
            txtNote.DataBindings.Add("Text", dtIngredient, "Note");
            dgvIngredientDetail.DataSource = dtIngredient;
        }
        #endregion
    }
}
