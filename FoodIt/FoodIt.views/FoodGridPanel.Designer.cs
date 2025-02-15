﻿namespace FoodIt.views
{
    partial class FoodGridPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlNavigation = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrev = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblPaging = new System.Windows.Forms.Label();
            this.btnNext = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pnlFindByIngredients = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnFindRecipeByIngredients = new Guna.UI2.WinForms.Guna2Button();
            this.pnlIngredients = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIngredient = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlFindByIngredients.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.ColumnCount = 3;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMain.RowCount = 3;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlMain.Size = new System.Drawing.Size(835, 333);
            this.pnlMain.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(835, 73);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.txtSearch);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(270, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(295, 67);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconRight = global::FoodIt.Properties.Resources.search;
            this.txtSearch.Location = new System.Drawing.Point(4, 14);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(287, 36);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.Transparent;
            this.pnlNavigation.ColumnCount = 1;
            this.pnlNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlNavigation.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 406);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.RowCount = 1;
            this.pnlNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlNavigation.Size = new System.Drawing.Size(835, 54);
            this.pnlNavigation.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnPrev);
            this.flowLayoutPanel1.Controls.Add(this.lblPaging);
            this.flowLayoutPanel1.Controls.Add(this.btnNext);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(338, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(158, 48);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnPrev
            // 
            this.btnPrev.CheckedState.Parent = this.btnPrev;
            this.btnPrev.CustomImages.Parent = this.btnPrev;
            this.btnPrev.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.HoverState.Parent = this.btnPrev;
            this.btnPrev.Location = new System.Drawing.Point(3, 3);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPrev.ShadowDecoration.Parent = this.btnPrev;
            this.btnPrev.Size = new System.Drawing.Size(48, 45);
            this.btnPrev.TabIndex = 3;
            this.btnPrev.Text = "<";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblPaging
            // 
            this.lblPaging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaging.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaging.Location = new System.Drawing.Point(56, 0);
            this.lblPaging.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaging.Name = "lblPaging";
            this.lblPaging.Size = new System.Drawing.Size(46, 51);
            this.lblPaging.TabIndex = 2;
            this.lblPaging.Text = "paging";
            this.lblPaging.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.CustomImages.Parent = this.btnNext;
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Location = new System.Drawing.Point(107, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnNext.ShadowDecoration.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(48, 45);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pnlFindByIngredients
            // 
            this.pnlFindByIngredients.BackColor = System.Drawing.Color.White;
            this.pnlFindByIngredients.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlFindByIngredients.BorderThickness = 1;
            this.pnlFindByIngredients.Controls.Add(this.guna2Panel2);
            this.pnlFindByIngredients.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFindByIngredients.Location = new System.Drawing.Point(835, 0);
            this.pnlFindByIngredients.Name = "pnlFindByIngredients";
            this.pnlFindByIngredients.ShadowDecoration.Parent = this.pnlFindByIngredients;
            this.pnlFindByIngredients.Size = new System.Drawing.Size(280, 460);
            this.pnlFindByIngredients.TabIndex = 1;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Panel2.Controls.Add(this.btnFindRecipeByIngredients);
            this.guna2Panel2.Controls.Add(this.pnlIngredients);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.txtIngredient);
            this.guna2Panel2.Location = new System.Drawing.Point(3, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(274, 460);
            this.guna2Panel2.TabIndex = 5;
            // 
            // btnFindRecipeByIngredients
            // 
            this.btnFindRecipeByIngredients.BorderRadius = 5;
            this.btnFindRecipeByIngredients.CheckedState.Parent = this.btnFindRecipeByIngredients;
            this.btnFindRecipeByIngredients.CustomImages.Parent = this.btnFindRecipeByIngredients;
            this.btnFindRecipeByIngredients.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.btnFindRecipeByIngredients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindRecipeByIngredients.ForeColor = System.Drawing.Color.White;
            this.btnFindRecipeByIngredients.HoverState.Parent = this.btnFindRecipeByIngredients;
            this.btnFindRecipeByIngredients.Location = new System.Drawing.Point(50, 406);
            this.btnFindRecipeByIngredients.Name = "btnFindRecipeByIngredients";
            this.btnFindRecipeByIngredients.ShadowDecoration.Parent = this.btnFindRecipeByIngredients;
            this.btnFindRecipeByIngredients.Size = new System.Drawing.Size(177, 42);
            this.btnFindRecipeByIngredients.TabIndex = 2;
            this.btnFindRecipeByIngredients.Text = "Find recipes";
            this.btnFindRecipeByIngredients.Click += new System.EventHandler(this.btnFindRecipeByIngredients_Click);
            // 
            // pnlIngredients
            // 
            this.pnlIngredients.AutoScroll = true;
            this.pnlIngredients.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlIngredients.Location = new System.Drawing.Point(9, 95);
            this.pnlIngredients.Name = "pnlIngredients";
            this.pnlIngredients.Size = new System.Drawing.Size(262, 305);
            this.pnlIngredients.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Don\'t know what to cook ?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIngredient
            // 
            this.txtIngredient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtIngredient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtIngredient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtIngredient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIngredient.DefaultText = "";
            this.txtIngredient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIngredient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIngredient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIngredient.DisabledState.Parent = this.txtIngredient;
            this.txtIngredient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIngredient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.txtIngredient.FocusedState.Parent = this.txtIngredient;
            this.txtIngredient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIngredient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.txtIngredient.HoverState.Parent = this.txtIngredient;
            this.txtIngredient.Location = new System.Drawing.Point(9, 43);
            this.txtIngredient.Name = "txtIngredient";
            this.txtIngredient.PasswordChar = '\0';
            this.txtIngredient.PlaceholderText = "Enter your ingredient here";
            this.txtIngredient.SelectedText = "";
            this.txtIngredient.ShadowDecoration.Parent = this.txtIngredient;
            this.txtIngredient.Size = new System.Drawing.Size(262, 36);
            this.txtIngredient.TabIndex = 0;
            this.txtIngredient.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIngredient_KeyUp);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.pnlMain);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 73);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(835, 333);
            this.guna2Panel1.TabIndex = 0;
            // 
            // FoodGridPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.pnlFindByIngredients);
            this.Name = "FoodGridPanel";
            this.Size = new System.Drawing.Size(1115, 460);
            this.Load += new System.EventHandler(this.FoodGridPanel_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.pnlNavigation.ResumeLayout(false);
            this.pnlNavigation.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlFindByIngredients.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.TableLayoutPanel pnlNavigation;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblPaging;
        private Guna.UI2.WinForms.Guna2Panel pnlFindByIngredients;
        private Guna.UI2.WinForms.Guna2Button btnFindRecipeByIngredients;
        private Guna.UI2.WinForms.Guna2TextBox txtIngredient;
        private System.Windows.Forms.FlowLayoutPanel pnlIngredients;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton btnPrev;
        private Guna.UI2.WinForms.Guna2CircleButton btnNext;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}
