using FoodIt.daos;
using FoodIt.dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodIt
{
    public partial class LoginForm : Form
    {
        UserDAO userDAO = new UserDAO();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtEmail.Text;
            string password = txtPassword.Text;
            User user = userDAO.checkLogin(username, password);
            if (user != null)
            {
                this.Hide();
                MainForm frmMain = new MainForm();
                frmMain.User = user;
                frmMain.Show();
            }

        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            transistion.Hide(this);
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
