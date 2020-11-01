using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodIt.FoodIt.views
{
    public partial class IngredientTag : UserControl
    {
        List<string> ingredients;
        string tagName;

        public IngredientTag(string tagName, List<string> ingredients)
        {
            InitializeComponent();
            lblIngredient.Text = tagName;
            this.ingredients = ingredients;
            this.tagName = tagName;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ingredients.Remove(tagName);
            Dispose();
        }
    }
}
