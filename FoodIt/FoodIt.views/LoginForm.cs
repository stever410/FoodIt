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
            if (this.ValidateChildren())
            {
                User user = userDAO.CheckLogin(username, password);
                if (user != null)
                {
                    this.Hide();
                    MainForm frmMain = new MainForm();
                    frmMain.User = user;
                    frmMain.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!");
                    txtEmail.Focus();
                }
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

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                //txtEmail.Focus();
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                //txtPassword.Focus();
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}
