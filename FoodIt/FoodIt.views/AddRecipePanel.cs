using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FoodIt.dtos;
using FoodIt.FoodIt.daos;
using FoodIt.FoodIt.dtos;
using Guna.UI2.WinForms;

namespace FoodIt.FoodIt.views
{
    public partial class AddRecipePanel : UserControl
    {
        private List<Ingredient> ingredients;
        List<RecipeStep> recipeSteps = new List<RecipeStep>();
        List<RecipeIngredient> recipeIngredients = new List<RecipeIngredient>();
        private int stepIndex = 0;
        private User user;
        private string workingDirectory, projectDirectory;
        Dictionary<string, string> imagePath = new Dictionary<string, string>();

        public AddRecipePanel(User user)
        {
            InitializeComponent();
            this.user = user;
            workingDirectory = Environment.CurrentDirectory;
            projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
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
            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Maybe you forgot the name of the recipe :v");
            }
            else if (string.IsNullOrEmpty(image))
            {
                MessageBox.Show("Recipe with image will be more attractive :v");
            }
            else if (string.IsNullOrEmpty(description))
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
                    recipe.RecipeIngredients = recipeIngredients;
                    recipe.RecipeSteps = recipeSteps;
                    RecipeDAO recipeDAO = new RecipeDAO();
                    RecipeStepDAO recipeStepDAO = new RecipeStepDAO();
                    RecipeIngredientDAO recipeIngredientDAO = new RecipeIngredientDAO();
                    int recipeID = recipeDAO.AddRecipe(recipe);
                    recipeStepDAO.AddRecipeSteps(recipeID, recipeSteps);
                    recipeIngredientDAO.AddRecipeIngredients(recipeID, recipeIngredients);
                    //save image
                    String path = projectDirectory + @"\resources\img\" + recipeID;
                    if (Directory.Exists(path) == false)
                    {
                        Directory.CreateDirectory(path);
                    }
                    try
                    {
                        foreach (string imageName in imagePath.Keys)
                        {
                            string destFile = Path.Combine(path, imageName);
                            File.Copy(imagePath[imageName], destFile, true);
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
                string imageName = stepFileDlg.SafeFileName;
                txtStepImage.Text = imageName;
                string filePath = stepFileDlg.FileName;
                imagePath.Add(imageName, filePath);
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
        private void updateStepOrder()
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
            if (string.IsNullOrEmpty(description))
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
                LoadAllSteps();
            }
        }

        private void btnUpdateStep_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStepOrder.Text))
            {
                errProvider.SetError(txtStepOrder, "Please select the step you want to update.");
            }
            else if (string.IsNullOrEmpty(txtStepDescription.Text))
            {
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
            updateStepOrder();
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
                string imageName = recipeFileDlg.SafeFileName;
                string filePath = recipeFileDlg.FileName;
                txtImage.Text = imageName;
                imagePath.Add(imageName, filePath);
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
            string unit = txtUnit.Text;
            string note = txtNote.Text;
            if (id > 0)
            {
                if (string.IsNullOrEmpty(amount))
                {
                    errProvider.SetError(txtIngredientAmount, "Amount must not be blank.");
                }
                else if (string.IsNullOrEmpty(unit))
                {
                    errProvider.SetError(txtIngredientAmount, "");
                    errProvider.SetError(txtUnit, "Unit must not be blank.");
                }
                else
                {
                    errProvider.SetError(txtIngredientAmount, "");
                    errProvider.SetError(txtUnit, "");
                    RecipeIngredient ingredient = new RecipeIngredient(id, amount, unit, note);
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
            string unit = txtUnit.Text;
            string note = txtNote.Text;
            if (id > 0)
            {
                if (string.IsNullOrEmpty(amount))
                {
                    errProvider.SetError(txtIngredientAmount, "Amount must not be blank.");
                }
                else if (string.IsNullOrEmpty(unit))
                {
                    errProvider.SetError(txtIngredientAmount, "");
                    errProvider.SetError(txtUnit, "Unit must not be blank.");
                }
                else
                {

                    for (int i = 0; i < recipeIngredients.Count; i++)
                    {
                        RecipeIngredient ingredient = new RecipeIngredient(id, amount, unit, note);
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
                for (int i = 0; i < recipeIngredients.Count; i++)
                {
                    RecipeIngredient ingredient = new RecipeIngredient(id, null, null, null);
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
            dtIngredient.Columns.Add("Unit");
            dtIngredient.Columns.Add("Note");
            for (int i = 0; i < recipeIngredients.Count; i++)
            {
                DataRow dr = dtIngredient.NewRow();
                dr["IngredientID"] = recipeIngredients[i].IngredientID;
                dr["IngredientName"] = dao.GetIngredientNameByID(recipeIngredients[i].IngredientID);
                dr["Amount"] = recipeIngredients[i].AmountIngredient;
                dr["Unit"] = recipeIngredients[i].Unit;
                dr["Note"] = recipeIngredients[i].Note;
                dtIngredient.Rows.Add(dr);
            }
            txtIngredient.DataBindings.Clear();
            txtIngredientAmount.DataBindings.Clear();
            txtNote.DataBindings.Clear();
            txtUnit.DataBindings.Clear();
            txtIngredient.DataBindings.Add("Text", dtIngredient, "IngredientName");
            txtIngredientAmount.DataBindings.Add("Text", dtIngredient, "Amount");
            txtUnit.DataBindings.Add("Text", dtIngredient, "Unit");
            txtNote.DataBindings.Add("Text", dtIngredient, "Note");
            dgvIngredientDetail.DataSource = dtIngredient;
        }
        #endregion

        private void txtIngredientAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            if ((e.KeyChar == '.') && (txtIngredientAmount.Text.Contains(".") == false)) return;
            if ((e.KeyChar == '.') && (txtIngredientAmount.SelectionLength == txtIngredientAmount.TextLength)) return;
            e.Handled = true;
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
