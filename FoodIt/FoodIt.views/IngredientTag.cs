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
        public IngredientTag(string tagName)
        {
            InitializeComponent();
            lblIngredient.Text = tagName;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
