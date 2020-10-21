using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodIt.Foodit.dtos;
using FoodIt.Foodit.views;

namespace FoodIt
{
    public partial class FoodPnl : UserControl
    {
        private MainForm mainForm;
        private Recipe recipe;
        private FoodGridPanel foodGridPanel;

        public FoodGridPanel FoodGridPanel { get => foodGridPanel; set => foodGridPanel = value; }

        //public MainForm MainForm { get => mainForm; set => mainForm = value; }

        public FoodPnl(Recipe recipe)
        {
            this.recipe = recipe;
            InitializeComponent();
            this.lblFood.Text = recipe.Title;
            this.SetImageURL(recipe.Image);

            string currentPath = @"D:\learning_materials\Fall2020\PRN292\stever410\FoodIt\FoodIt";

            this.SetImageURL(currentPath + "\\" + recipe.Image);
        }

        public void SetLblFood(String text)
        {
            lblFood.Text = text;
        }

        public void SetImgFood(Image image)
        {
            imgFood.Image = image;
        }

        public void SetImageURL(String url)
        {
            imgFood.ImageLocation = url;
        }

        private void FoodPnl_Click(object sender, EventArgs e)
        {
            //this.mainForm.MainPnl.Controls.Clear();
            //this.mainForm.MainPnl.Controls.Add(new ViewRecipePanel(this.mainForm, recipe));
            this.foodGridPanel.Controls.Clear();
            this.foodGridPanel.Controls.Add(new ViewRecipePanel(recipe));
        }
    }
}
