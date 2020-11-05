using FoodIt.dtos;
using FoodIt.FoodIt.views;
using System;
using System.Windows.Forms;

namespace FoodIt
{
    public partial class MainForm : Form
    {
        public User User { get; set; }

        public MainForm()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Font;
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            this.btnUser.Text = User.Username;
            FoodGridPanel foodGridPanel = new FoodGridPanel(this.mainPnl);
            foodGridPanel.User = this.User;
            this.mainPnl.Controls.Add(foodGridPanel);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            mainPnl.Controls.Clear();
            AddRecipePanel addRecipePanel = new AddRecipePanel(User);
            //addRecipePanel.Dock = DockStyle.Top;
            this.mainPnl.Controls.Add(addRecipePanel);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            mainPnl.Controls.Clear();
            FoodGridPanel foodGridPanel = new FoodGridPanel(this.mainPnl);
            //foodGridPanel.Dock = DockStyle.Top;
            foodGridPanel.User = this.User;
            this.mainPnl.Controls.Add(foodGridPanel);
        }

        public void RenderOnMainPanel(UserControl panel)
        {
            this.mainPnl.Controls.Clear();
            this.mainPnl.Controls.Add(panel);
        }
    }
}