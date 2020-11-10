using Guna.UI2.WinForms;

namespace FoodIt.views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnPost = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.sidePnl = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlUser = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnUser = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.mainPnl = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlMenu.SuspendLayout();
            this.sidePnl.SuspendLayout();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenu.ColumnCount = 1;
            this.pnlMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMenu.Controls.Add(this.btnPost, 0, 1);
            this.pnlMenu.Controls.Add(this.btnHome, 0, 0);
            this.pnlMenu.Location = new System.Drawing.Point(1, 104);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.RowCount = 2;
            this.pnlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlMenu.Size = new System.Drawing.Size(214, 116);
            this.pnlMenu.TabIndex = 5;
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.Color.Transparent;
            this.btnPost.CheckedState.Parent = this.btnPost;
            this.btnPost.CustomImages.Parent = this.btnPost;
            this.btnPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPost.FillColor = System.Drawing.Color.Transparent;
            this.btnPost.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.ForeColor = System.Drawing.Color.White;
            this.btnPost.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnPost.HoverState.Parent = this.btnPost;
            this.btnPost.Image = ((System.Drawing.Image)(resources.GetObject("btnPost.Image")));
            this.btnPost.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPost.Location = new System.Drawing.Point(0, 58);
            this.btnPost.Margin = new System.Windows.Forms.Padding(0);
            this.btnPost.Name = "btnPost";
            this.btnPost.ShadowDecoration.Parent = this.btnPost;
            this.btnPost.Size = new System.Drawing.Size(214, 58);
            this.btnPost.TabIndex = 1;
            this.btnPost.Text = "Post article";
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.CustomImages.Parent = this.btnHome;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(214, 58);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // sidePnl
            // 
            this.sidePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.sidePnl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sidePnl.BorderThickness = 1;
            this.sidePnl.Controls.Add(this.pnlUser);
            this.sidePnl.Controls.Add(this.label1);
            this.sidePnl.Controls.Add(this.pnlMenu);
            this.sidePnl.Controls.Add(this.guna2PictureBox1);
            this.sidePnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePnl.Location = new System.Drawing.Point(0, 0);
            this.sidePnl.Name = "sidePnl";
            this.sidePnl.ShadowDecoration.BorderRadius = 0;
            this.sidePnl.ShadowDecoration.Depth = 200;
            this.sidePnl.ShadowDecoration.Enabled = true;
            this.sidePnl.ShadowDecoration.Parent = this.sidePnl;
            this.sidePnl.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(100);
            this.sidePnl.Size = new System.Drawing.Size(218, 857);
            this.sidePnl.TabIndex = 0;
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.Color.Transparent;
            this.pnlUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlUser.Controls.Add(this.btnLogout);
            this.pnlUser.Controls.Add(this.btnUser);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUser.Location = new System.Drawing.Point(0, 810);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.ShadowDecoration.Parent = this.pnlUser;
            this.pnlUser.Size = new System.Drawing.Size(218, 47);
            this.pnlUser.TabIndex = 7;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogout.HoverState.ImageSize = new System.Drawing.Size(28, 28);
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Image = global::FoodIt.Properties.Resources.logout;
            this.btnLogout.ImageRotate = 0F;
            this.btnLogout.ImageSize = new System.Drawing.Size(24, 24);
            this.btnLogout.Location = new System.Drawing.Point(159, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.PressedState.ImageSize = new System.Drawing.Size(28, 28);
            this.btnLogout.PressedState.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(59, 47);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.Transparent;
            this.btnUser.CheckedState.Parent = this.btnUser;
            this.btnUser.CustomImages.Parent = this.btnUser;
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUser.FillColor = System.Drawing.Color.Transparent;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.btnUser.HoverState.Parent = this.btnUser;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUser.Location = new System.Drawing.Point(0, 0);
            this.btnUser.Name = "btnUser";
            this.btnUser.ShadowDecoration.Parent = this.btnUser;
            this.btnUser.Size = new System.Drawing.Size(185, 47);
            this.btnUser.TabIndex = 3;
            this.btnUser.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "FoodIt";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::FoodIt.Properties.Resources.food;
            this.guna2PictureBox1.Location = new System.Drawing.Point(86, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(52, 58);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            // 
            // mainPnl
            // 
            this.mainPnl.AutoScroll = true;
            this.mainPnl.AutoSize = true;
            this.mainPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.mainPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPnl.Location = new System.Drawing.Point(218, 0);
            this.mainPnl.Name = "mainPnl";
            this.mainPnl.ShadowDecoration.Depth = 100;
            this.mainPnl.ShadowDecoration.Enabled = true;
            this.mainPnl.ShadowDecoration.Parent = this.mainPnl;
            this.mainPnl.Size = new System.Drawing.Size(1362, 857);
            this.mainPnl.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1580, 857);
            this.Controls.Add(this.mainPnl);
            this.Controls.Add(this.sidePnl);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodIt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnlMenu.ResumeLayout(false);
            this.sidePnl.ResumeLayout(false);
            this.sidePnl.PerformLayout();
            this.pnlUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnUser;
        private System.Windows.Forms.TableLayoutPanel pnlMenu;
        private Guna.UI2.WinForms.Guna2Panel sidePnl;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel mainPnl;
        private Guna2PictureBox guna2PictureBox1;
        private Guna2Panel pnlUser;
        private Guna2ImageButton btnLogout;
        private Guna2Button btnPost;
    }
}