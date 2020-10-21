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
    public partial class FoodGridPanel : UserControl
    {
        private const int ROWS = 4;
        private const int COLS = 4;

        public FoodGridPanel()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void LoadFoodGrid()
        {
            // init grid layout inside main panel
            pnlMain.RowCount = ROWS;
            pnlMain.ColumnCount = COLS;
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    FoodPanel uc1 = new FoodPanel();
                    uc1.SetImageURL("https://picsum.photos/200/200");
                    pnlMain.Controls.Add(uc1, i, j);
                }
            }
        }

        private void FoodGridPanel_Load(object sender, EventArgs e)
        {
            LoadFoodGrid();
        }
    }
}
