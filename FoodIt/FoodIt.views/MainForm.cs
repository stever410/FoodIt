using FoodIt.dtos;
using FoodIt.views;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FoodIt.views
{
    public partial class MainForm : Form
    {
        private Color DEFAULT_BUTTON_COLOR = Color.Transparent;
        private Color PRESSED_BUTTON_COLOR = Color.FromArgb(252, 155, 155);
        private List<Guna2Button> buttons;

        public User User { get; set; }

        public MainForm()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Font;
            buttons = new List<Guna2Button>();
        }

        public void ChangeUserButtonText(String text)
        {
            btnUpdateUser.Text = text;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.btnUpdateUser.Text = User.Username;
            FoodGridPanel foodGridPanel = new FoodGridPanel(this.mainPnl);
            foodGridPanel.User = this.User;
            this.mainPnl.Controls.Add(foodGridPanel);
            //get all button in pnlMenu
            foreach (var component in pnlMenu.Controls)
            {
                if(component is Guna2Button)
                {
                    buttons.Add((Guna2Button)component);
                }
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            mainPnl.Controls.Clear();
            AddRecipePanel addRecipePanel = new AddRecipePanel(User);
            ChangeButtonColor(btnPost, buttons);
            addRecipePanel.Dock = DockStyle.Fill;
            this.mainPnl.Controls.Add(addRecipePanel);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            mainPnl.Controls.Clear();
            FoodGridPanel foodGridPanel = new FoodGridPanel(this.mainPnl);
            ChangeButtonColor(btnHome, buttons);
            foodGridPanel.User = this.User;
            this.mainPnl.Controls.Add(foodGridPanel);
        }

        public void RenderOnMainPanel(UserControl panel)
        {
            this.mainPnl.Controls.Clear();
            this.mainPnl.Controls.Add(panel);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        // this function will change button color based on which button user pressed
        private void ChangeButtonColor(Guna2Button pressedButton, List<Guna2Button> listButtons)
        {
            // set all button to default color
            foreach (Guna2Button button in listButtons)
            {
                button.FillColor = DEFAULT_BUTTON_COLOR;
            }
            // set the pressed button to pressed button color
            pressedButton.FillColor = PRESSED_BUTTON_COLOR;
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            UpdateUserForm updateUserForm = new UpdateUserForm(User, this);
            updateUserForm.ShowDialog();
        }
    }
}