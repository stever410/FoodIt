using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodIt
{
    public partial class FoodPanel : UserControl
    {
        public FoodPanel()
        {
            InitializeComponent();
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

        private void imgFood_Click(object sender, EventArgs e)
        {

        }
    }
}
