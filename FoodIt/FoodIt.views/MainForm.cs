
using System;
using System.Windows.Forms;

namespace FoodIt
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FoodGridPanel foodGridPanel = new FoodGridPanel(this);
            this.MainPnl.Controls.Add(foodGridPanel);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            mainPnl.Controls.Clear();
            AddRecipePanel addRecipePanel = new AddRecipePanel(User);
            addRecipePanel.Dock = DockStyle.Top;
            this.mainPnl.Controls.Add(addRecipePanel);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            mainPnl.Controls.Clear();
            FoodGridPanel foodGridPanel = new FoodGridPanel();
            this.mainPnl.Controls.Add(foodGridPanel);
        }
    }
}
