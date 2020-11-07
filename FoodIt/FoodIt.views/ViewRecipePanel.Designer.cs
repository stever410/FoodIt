namespace FoodIt.FoodIt.views
{
    partial class ViewRecipePanel
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.container = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imgRecipe = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ingrePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.controlPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUpdateRecipe = new Guna.UI2.WinForms.Guna2Button();
            this.container.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRecipe)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(733, 104);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title Recipe goes here";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // container
            // 
            this.container.AutoScroll = true;
            this.container.Controls.Add(this.tableLayoutPanel1);
            this.container.Controls.Add(this.lblTitle);
            this.container.Controls.Add(this.tableLayoutPanel2);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.ShadowDecoration.Parent = this.container;
            this.container.Size = new System.Drawing.Size(733, 615);
            this.container.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.imgRecipe, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ingrePanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 104);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(733, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // imgRecipe
            // 
            this.imgRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgRecipe.Location = new System.Drawing.Point(3, 3);
            this.imgRecipe.Name = "imgRecipe";
            this.imgRecipe.ShadowDecoration.Parent = this.imgRecipe;
            this.imgRecipe.Size = new System.Drawing.Size(213, 444);
            this.imgRecipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgRecipe.TabIndex = 0;
            this.imgRecipe.TabStop = false;
            // 
            // ingrePanel
            // 
            this.ingrePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ingrePanel.AutoScroll = true;
            this.ingrePanel.AutoSize = true;
            this.ingrePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ingrePanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingrePanel.Location = new System.Drawing.Point(222, 3);
            this.ingrePanel.Name = "ingrePanel";
            this.ingrePanel.Size = new System.Drawing.Size(508, 444);
            this.ingrePanel.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.controlPanel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 554);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(733, 61);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.controlPanel.Controls.Add(this.btnUpdateRecipe);
            this.controlPanel.Location = new System.Drawing.Point(279, 3);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(174, 55);
            this.controlPanel.TabIndex = 2;
            // 
            // btnUpdateRecipe
            // 
            this.btnUpdateRecipe.BorderRadius = 5;
            this.btnUpdateRecipe.CheckedState.Parent = this.btnUpdateRecipe;
            this.btnUpdateRecipe.CustomImages.Parent = this.btnUpdateRecipe;
            this.btnUpdateRecipe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.btnUpdateRecipe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRecipe.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRecipe.HoverState.Parent = this.btnUpdateRecipe;
            this.btnUpdateRecipe.Location = new System.Drawing.Point(3, 3);
            this.btnUpdateRecipe.Name = "btnUpdateRecipe";
            this.btnUpdateRecipe.ShadowDecoration.Parent = this.btnUpdateRecipe;
            this.btnUpdateRecipe.Size = new System.Drawing.Size(166, 44);
            this.btnUpdateRecipe.TabIndex = 2;
            this.btnUpdateRecipe.Text = "Update Recipe";
            this.btnUpdateRecipe.Click += new System.EventHandler(this.btnUpdateRecipe_Click);
            // 
            // ViewRecipePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.container);
            this.Name = "ViewRecipePanel";
            this.Size = new System.Drawing.Size(733, 615);
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRecipe)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel container;
        private Guna.UI2.WinForms.Guna2PictureBox imgRecipe;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel ingrePanel;
        private System.Windows.Forms.FlowLayoutPanel controlPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Button btnUpdateRecipe;
    }
}
