﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;
using FoodIt.dtos;
using FoodIt.daos;
using Guna.UI2.WinForms;

namespace FoodIt.views
{
    public partial class UpdateRecipePanel : UserControl
    {
        private List<Ingredient> ingredients;
        List<RecipeStep> recipeSteps = new List<RecipeStep>();
        List<RecipeIngredient> recipeIngredients = new List<RecipeIngredient>();
        private int stepIndex = 0;
        private User user;
        private string workingDirectory, projectDirectory;
        Dictionary<string, string> imagePaths = new Dictionary<string, string>();
        private MainForm mainForm;
        private Recipe recipe;

        //file path temp
        private string tmpFilePath;

        public MainForm MainForm { get => mainForm; set => mainForm = value; }

        public UpdateRecipePanel(User user, Recipe recipe)
        {
            InitializeComponent();
            this.user = user;
            this.recipe = recipe;
            workingDirectory = AppDomain.CurrentDomain.BaseDirectory;
            projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        }

        private void UpdateRecipePanel_Load(object sender, EventArgs e)
        {
            LoadIngredientsAutoComplete();

            this.txtTitle.Text = recipe.Title;
            this.txtImage.Text = recipe.Image;
            this.txtDescription.Text = recipe.Description;

            this.recipeSteps = recipe.RecipeSteps;
            LoadAllSteps();

            RecipeIngredientDAO dao = new RecipeIngredientDAO();
            this.recipeIngredients = dao.GetRecipeIngredientsByRecipe(recipe);
            LoadAllIngredients();
        }
        private bool CheckLength(string text, int max)
        {
            if (text.Length > max)
            {
                return false;
            }
            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string image = @"img\" + recipe.Id + @"\" + txtImage.Text;
            string description = txtDescription.Text;
            //validate
            if (recipeIngredients.Count == 0 || recipeSteps.Count == 0)
            {
                MessageBox.Show("Please add at least 1 ingredient and 1 step.");
            }
            else
            {
                // update information
                this.recipe.Title = title;
                this.recipe.Description = description;
                this.recipe.Image = image;

                RecipeDAO recipeDAO = new RecipeDAO();
                RecipeStepDAO recipeStepDAO = new RecipeStepDAO();
                RecipeIngredientDAO recipeIngredientDAO = new RecipeIngredientDAO();

                bool check = recipeDAO.UpdateRecipe(recipe);

                recipeStepDAO.UpdateRecipeSteps(recipe.Id, recipeSteps);
                recipeIngredientDAO.UpdateRecipeIngredients(recipe.Id, recipeIngredients);

                //save image
                String path = projectDirectory + @"\resources\img\" + recipe.Id;
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
                MessageBox.Show("Update recipe successfully!");

                //redirect to viewpanel
                RedirectViewPanel();
            }
        }

        private void RedirectViewPanel()
        {
            Guna2Panel mainPnl = this.Parent as Guna2Panel;
            mainPnl.Controls.Clear();
            ViewRecipePanel viewRecipePanel = new ViewRecipePanel(this.recipe, this.user);
            viewRecipePanel.MainForm = mainPnl.Parent as MainForm;
            mainPnl.Controls.Add(viewRecipePanel);
        }

        #region StepDetail
        private void LoadAllSteps()
        {
            DataTable dtStep = new DataTable();
            dtStep.Columns.Add("StepOrder");
            dtStep.Columns.Add("Description");
            dtStep.Columns.Add("Image");
            for (int i = 0; i < recipeSteps.Count; i++)
            {
                DataRow dr = dtStep.NewRow();
                // set step order to back to 1
                recipeSteps[i].Id = i + 1;
                dr["StepOrder"] = i + 1;
                dr["Description"] = recipeSteps[i].Description;
                dtStep.Rows.Add(dr);
            }
            txtStepOrder.DataBindings.Clear();
            txtStepDescription.DataBindings.Clear();
            txtStepOrder.DataBindings.Add("Text", dtStep, "StepOrder");
            txtStepDescription.DataBindings.Add("Text", dtStep, "Description");
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
            if (string.IsNullOrWhiteSpace(description))
            {
                errProvider.SetError(txtStepDescription, "Description must not be blank!");
            }
            else
            {
                id = ++stepIndex;
                errProvider.SetError(txtStepDescription, "");
                errProvider.SetError(txtStepOrder, "");
                RecipeStep step = new RecipeStep(id, description);
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
                RecipeStep updatedStep = new RecipeStep(id, description);
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
            RecipeStep deletedStep = new RecipeStep(id, description);
            for (int i = 0; i < recipeSteps.Count; i++)
            {
                if (recipeSteps[i].Equals(deletedStep))
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
                    ingredient.RecipeID = this.recipe.Id;
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
                    ingredient.RecipeID = this.recipe.Id;
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
                ingredient.RecipeID = recipe.Id;

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

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                errProvider.SetError(txtTitle, "Title must not blank!");
                if (!CheckLength(txtTitle.Text, 100))
                {
                    errProvider.SetError(txtTitle, "Title max length is 100");
                    e.Cancel = true;
                }
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(txtTitle, "");
                e.Cancel = false;
            }
        }

        private void txtIngredientAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIngredientAmount.Text))
            {
                errProvider.SetError(txtIngredientAmount, "Amount must not blank!");
                if (!CheckLength(txtIngredientAmount.Text, 50))
                {
                    errProvider.SetError(txtIngredientAmount, "Amount max length is 50");
                    e.Cancel = true;
                }
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(txtIngredientAmount, "");
                e.Cancel = false;
            }
        }

        private void txtNote_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNote.Text))
            {
                errProvider.SetError(txtNote, "Note must not blank!");
                if (!CheckLength(txtNote.Text, 500))
                {
                    errProvider.SetError(txtNote, "Note max length is 500");
                    e.Cancel = true;
                }
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(txtNote, "");
                e.Cancel = false;
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                errProvider.SetError(txtDescription, "Description must not blank!");
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(txtDescription, "");
                e.Cancel = false;
            }
        }

        private void txtStepDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStepDescription.Text))
            {
                errProvider.SetError(txtStepDescription, "Step Description must not blank!");
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(txtStepDescription, "");
                e.Cancel = false;
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
