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

namespace FoodIt.Foodit.views
{
    public partial class ViewRecipePanel : UserControl
    {
        //private MainForm mainForm;
        private Recipe recipe;
        public ViewRecipePanel(Recipe recipe)
        {
            //this.mainForm = mainForm;
            this.recipe = recipe;
            InitializeComponent();

            lblRecipeTitle.Text = recipe.Title;
        }
    }
}
