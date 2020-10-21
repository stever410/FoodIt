using FoodIt.daos;
using FoodIt.dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodIt
{
    public partial class RegisterForm : Form
    {
        UserDAO userDAO = new UserDAO();

        public RegisterForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.Selectable, true);
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            transistion.Hide(this);
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                MailAddress checkEmail = new MailAddress(txtEmail.Text);
                errProvider.SetError(txtEmail, "");
                e.Cancel = false;
            }
            catch (Exception)
            {
                errProvider.SetError(txtEmail, "Invalid Email!");
                e.Cancel = true;
            }
        }

        private void txtRetype_Validating(object sender, CancelEventArgs e)
        {
            if (!txtRetype.Text.Equals(txtPassword.Text))
            {
                errProvider.SetError(txtRetype, "Retype must match Password!");
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(txtRetype, "");
                e.Cancel = false;
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errProvider.SetError(txtUsername, "Username must not blank!");
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(txtUsername, "");
                e.Cancel = false;
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errProvider.SetError(txtPassword, "Password must not blank!");
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(txtPassword, "");
                e.Cancel = false;
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (this.ValidateChildren())
            {
                if (userDAO.FindUserByEmail(email) != null)
                {
                    MessageBox.Show("That email is exist!");
                    this.txtEmail.Focus();
                }
                else
                {
                    User user = new User(email, username, password, User.MEMBER, "", User.DEFAULT_STATUS);
                    userDAO.AddUser(user);
                    MessageBox.Show("Sign up successfully!");
                }
            }
        }
    }
}
