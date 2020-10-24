﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using FoodIt.dtos;
using FoodIt.FoodIt.daos;
using FoodIt.FoodIt.dtos;

namespace FoodIt.FoodIt.views
{
    public partial class AddRecipePanel : UserControl
    {
        private List<Ingredient> ingredients;
        List<RecipeStep> recipeSteps = new List<RecipeStep>();
        List<RecipeIngredient> recipeIngredients = new List<RecipeIngredient>();
        private int stepIndex = 0;
        private User user;

        public AddRecipePanel(User user)
        {
            InitializeComponent();
            this.user = user;
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
            // data send to db here
            Recipe recipe = new Recipe(user.Email, title, description, Recipe.DEFAULT_STATUS, new DateTime(), image);
            recipe.RecipeIngredients = recipeIngredients;
            recipe.RecipeSteps = recipeSteps;
        }

        #region StepDetail
        private void btnStepImage_Click(object sender, EventArgs e)
        {
            stepFileDlg.ShowDialog();
        }

        private void stepFileDlg_FileOk(object sender, CancelEventArgs e)
        {
            txtStepImage.Text = stepFileDlg.FileName;
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

        private void btnAddStep_Click(object sender, EventArgs e)
        {
            int id = ++stepIndex;
            string description = txtStepDescription.Text;
            string image = txtStepImage.Text;
            RecipeStep step = new RecipeStep(id, description, image);
            recipeSteps.Add(step);
            LoadAllSteps();
        }

        private void btnUpdateStep_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtStepOrder.Text);
            string description = txtStepDescription.Text;
            string image = txtStepImage.Text;
            RecipeStep updatedStep = new RecipeStep(id, description, image);
            for (int i = 0; i < recipeSteps.Count; i++)
            {
                if(recipeSteps[i].Equals(updatedStep))
                {
                    recipeSteps[i] = updatedStep;
                    break;
                }
            }
            LoadAllSteps();
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
            txtImage.Text = recipeFileDlg.FileName;
        }
        private void btnAddIngre_Click(object sender, EventArgs e)
        {
            IngredientDAO dao = new IngredientDAO();
            string name = txtIngredient.Text;
            int id = dao.GetIngredientIDByName(name);
            string amount = txtIngredientAmount.Text;
            string note = txtNote.Text;
            if(id > 0)
            {
                RecipeIngredient ingredient = new RecipeIngredient(id, amount, note);
                if(recipeIngredients.Contains(ingredient))
                {
                    //Neu trong list da co ingredient roi thi chi duoc update hoac delete
                    MessageBox.Show(name + " has already existed. You can only update or delete it");
                } else
                {
                    recipeIngredients.Add(ingredient);
                    LoadAllIngredients();
                    //clear ingredient field only
                }
            } else
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
                for (int i = 0; i < recipeIngredients.Count; i++)
                {
                    RecipeIngredient ingredient = new RecipeIngredient(id, amount, note);
                    if (recipeIngredients[i].Equals(ingredient))
                    {
                        recipeIngredients[i] = ingredient;
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

        private void btnDeleteIngre_Click(object sender, EventArgs e)
        {
            IngredientDAO dao = new IngredientDAO();
            string name = txtIngredient.Text;
            int id = dao.GetIngredientIDByName(name);
            if (id > 0)
            {
                for (int i = 0; i < recipeIngredients.Count; i++)
                {
                    RecipeIngredient ingredient = new RecipeIngredient(id, null, null);
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
