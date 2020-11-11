using FoodIt.daos;
using FoodIt.dtos;
using System;
using System.ComponentModel;
using System.Net.Mail;
using System.Windows.Forms;

namespace FoodIt.views
{
    public partial class UpdateUserForm : Form
    {
        UserDAO userDAO = new UserDAO();
        User user;
        MainForm mainForm;

        public UpdateUserForm(User user, MainForm mainForm)
        {
            InitializeComponent();
            SetStyle(ControlStyles.Selectable, true);
            this.user = user;
            this.mainForm = mainForm;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (this.ValidateChildren())
            {
                User user = new User(email, username, password);
                userDAO.UpdateUser(user);
                MessageBox.Show($"Update {email} successfully!");
                mainForm.User.Username = username;
                mainForm.ChangeUserButtonText(username);
                // if update user information success, drop update form
                this.Dispose();
            }
        }

        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            txtEmail.Text = user.Email;
            txtUsername.Text = user.Username;
        }
    }
}
