using Guna.UI2.WinForms;

namespace FoodIt
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPost = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.sidePnl = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnUser = new Guna.UI2.WinForms.Guna2Button();
            this.mainPnl = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel2.SuspendLayout();
            this.sidePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnPost, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnHome, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 97);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(158, 163);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.Color.Transparent;
            this.btnPost.CheckedState.Parent = this.btnPost;
            this.btnPost.CustomImages.Parent = this.btnPost;
            this.btnPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPost.FillColor = System.Drawing.Color.Transparent;
            this.btnPost.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.ForeColor = System.Drawing.Color.Black;
            this.btnPost.HoverState.Parent = this.btnPost;
            this.btnPost.Image = ((System.Drawing.Image)(resources.GetObject("btnPost.Image")));
            this.btnPost.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPost.Location = new System.Drawing.Point(0, 54);
            this.btnPost.Margin = new System.Windows.Forms.Padding(0);
            this.btnPost.Name = "btnPost";
            this.btnPost.ShadowDecoration.Parent = this.btnPost;
            this.btnPost.Size = new System.Drawing.Size(158, 54);
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
            this.btnHome.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(158, 54);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // sidePnl
            // 
            this.sidePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(235)))));
            this.sidePnl.BorderColor = System.Drawing.Color.Transparent;
            this.sidePnl.Controls.Add(this.label1);
            this.sidePnl.Controls.Add(this.tableLayoutPanel2);
            this.sidePnl.Controls.Add(this.guna2PictureBox1);
            this.sidePnl.Controls.Add(this.btnUser);
            this.sidePnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePnl.Location = new System.Drawing.Point(0, 0);
            this.sidePnl.Name = "sidePnl";
            this.sidePnl.ShadowDecoration.Parent = this.sidePnl;
            this.sidePnl.Size = new System.Drawing.Size(161, 561);
            this.sidePnl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "FoodIt";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::FoodIt.Properties.Resources.logo;
            this.guna2PictureBox1.Location = new System.Drawing.Point(59, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(52, 58);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.Transparent;
            this.btnUser.CheckedState.Parent = this.btnUser;
            this.btnUser.CustomImages.Parent = this.btnUser;
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUser.FillColor = System.Drawing.Color.Transparent;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.Black;
            this.btnUser.HoverState.Parent = this.btnUser;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUser.Location = new System.Drawing.Point(0, 516);
            this.btnUser.Name = "btnUser";
            this.btnUser.ShadowDecoration.Parent = this.btnUser;
            this.btnUser.Size = new System.Drawing.Size(161, 45);
            this.btnUser.TabIndex = 3;
            this.btnUser.Text = "User";
            // 
            // mainPnl
            // 
            this.mainPnl.AutoScroll = true;
            this.mainPnl.AutoSize = true;
            this.mainPnl.BackColor = System.Drawing.Color.White;
            this.mainPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPnl.Location = new System.Drawing.Point(161, 0);
            this.mainPnl.MinimumSize = new System.Drawing.Size(571, 861);
            this.mainPnl.Name = "mainPnl";
            this.mainPnl.ShadowDecoration.Parent = this.mainPnl;
            this.mainPnl.Size = new System.Drawing.Size(823, 861);
            this.mainPnl.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.mainPnl);
            this.Controls.Add(this.sidePnl);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(999, 599);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodIt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.sidePnl.ResumeLayout(false);
            this.sidePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnPost;
        private Guna.UI2.WinForms.Guna2Button btnUser;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Panel sidePnl;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel mainPnl;
    }
}