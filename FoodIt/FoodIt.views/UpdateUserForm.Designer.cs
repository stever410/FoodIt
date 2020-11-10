namespace FoodIt.views
{
    partial class UpdateUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation3 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateUserForm));
            this.pnlRegister = new Guna.UI2.WinForms.Guna2Panel();
            this.txtRetype = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.transistion = new Guna.UI2.WinForms.Guna2Transition();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRegister
            // 
            this.pnlRegister.Controls.Add(this.txtRetype);
            this.pnlRegister.Controls.Add(this.label1);
            this.pnlRegister.Controls.Add(this.txtPassword);
            this.pnlRegister.Controls.Add(this.label7);
            this.pnlRegister.Controls.Add(this.txtUsername);
            this.pnlRegister.Controls.Add(this.label5);
            this.pnlRegister.Controls.Add(this.pictureBox2);
            this.pnlRegister.Controls.Add(this.txtEmail);
            this.pnlRegister.Controls.Add(this.label6);
            this.pnlRegister.Controls.Add(this.btnUpdate);
            this.transistion.SetDecoration(this.pnlRegister, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegister.FillColor = System.Drawing.Color.White;
            this.pnlRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRegister.Location = new System.Drawing.Point(0, 0);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.ShadowDecoration.Parent = this.pnlRegister;
            this.pnlRegister.Size = new System.Drawing.Size(501, 679);
            this.pnlRegister.TabIndex = 9;
            // 
            // txtRetype
            // 
            this.txtRetype.Animated = true;
            this.txtRetype.BackColor = System.Drawing.Color.CadetBlue;
            this.txtRetype.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transistion.SetDecoration(this.txtRetype, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtRetype.DefaultText = "";
            this.txtRetype.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRetype.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRetype.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRetype.DisabledState.Parent = this.txtRetype;
            this.txtRetype.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRetype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.txtRetype.FocusedState.Parent = this.txtRetype;
            this.txtRetype.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetype.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRetype.HoverState.Parent = this.txtRetype;
            this.txtRetype.Location = new System.Drawing.Point(104, 495);
            this.txtRetype.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRetype.MaxLength = 100;
            this.txtRetype.Name = "txtRetype";
            this.txtRetype.PasswordChar = '*';
            this.txtRetype.PlaceholderText = "*******";
            this.txtRetype.SelectedText = "";
            this.txtRetype.ShadowDecoration.Parent = this.txtRetype;
            this.txtRetype.Size = new System.Drawing.Size(317, 36);
            this.txtRetype.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtRetype.TabIndex = 3;
            this.txtRetype.Validating += new System.ComponentModel.CancelEventHandler(this.txtRetype_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.transistion.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Retype your password";
            // 
            // txtPassword
            // 
            this.txtPassword.Animated = true;
            this.txtPassword.BackColor = System.Drawing.Color.CadetBlue;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transistion.SetDecoration(this.txtPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.Location = new System.Drawing.Point(104, 394);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.MaxLength = 100;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "*******";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(317, 36);
            this.txtPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.transistion.SetDecoration(this.label7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(100, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Animated = true;
            this.txtUsername.BackColor = System.Drawing.Color.CadetBlue;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transistion.SetDecoration(this.txtUsername, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.Parent = this.txtUsername;
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.txtUsername.FocusedState.Parent = this.txtUsername;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.HoverState.Parent = this.txtUsername;
            this.txtUsername.Location = new System.Drawing.Point(104, 288);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.MaxLength = 100;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "Your awesome name here";
            this.txtUsername.SelectedText = "";
            this.txtUsername.ShadowDecoration.Parent = this.txtUsername;
            this.txtUsername.Size = new System.Drawing.Size(317, 36);
            this.txtUsername.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.transistion.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Username";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.transistion.SetDecoration(this.pictureBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::FoodIt.Properties.Resources.food;
            this.pictureBox2.Location = new System.Drawing.Point(104, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(317, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Animated = true;
            this.txtEmail.BackColor = System.Drawing.Color.CadetBlue;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transistion.SetDecoration(this.txtEmail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.Parent = this.txtEmail;
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.txtEmail.FocusedState.Parent = this.txtEmail;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.HoverState.Parent = this.txtEmail;
            this.txtEmail.Location = new System.Drawing.Point(104, 180);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "email@email.com";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(317, 36);
            this.txtEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.transistion.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(100, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Email";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Animated = true;
            this.btnUpdate.AutoRoundedCorners = true;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderRadius = 18;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.transistion.SetDecoration(this.btnUpdate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(104, 573);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PressedColor = System.Drawing.Color.Transparent;
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(317, 39);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update information";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // transistion
            // 
            this.transistion.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.transistion.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 1F;
            this.transistion.DefaultAnimation = animation3;
            this.transistion.Interval = 20;
            this.transistion.TimeStep = 0.5F;
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            this.errProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errProvider.Icon")));
            // 
            // UpdateUserForm
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(501, 679);
            this.Controls.Add(this.pnlRegister);
            this.transistion.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update user information";
            this.Load += new System.EventHandler(this.UpdateUserForm_Load);
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlRegister;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2TextBox txtRetype;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Transition transistion;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}