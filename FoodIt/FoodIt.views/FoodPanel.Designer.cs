namespace FoodIt
{
    partial class FoodPanel
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
            this.tableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.lblFood = new System.Windows.Forms.Label();
            this.imgFood = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood)).BeginInit();
            this.SuspendLayout();
            // 
            // tableContainer
            // 
            this.tableContainer.AutoSize = true;
            this.tableContainer.BackColor = System.Drawing.Color.White;
            this.tableContainer.ColumnCount = 1;
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableContainer.Controls.Add(this.lblFood, 0, 0);
            this.tableContainer.Controls.Add(this.imgFood, 0, 1);
            this.tableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableContainer.Location = new System.Drawing.Point(10, 0);
            this.tableContainer.Name = "tableContainer";
            this.tableContainer.RowCount = 3;
            this.tableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableContainer.Size = new System.Drawing.Size(280, 290);
            this.tableContainer.TabIndex = 0;
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.BackColor = System.Drawing.Color.White;
            this.lblFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFood.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFood.Location = new System.Drawing.Point(3, 0);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(274, 54);
            this.lblFood.TabIndex = 1;
            this.lblFood.Text = "Title goes here";
            this.lblFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgFood
            // 
            this.imgFood.BackColor = System.Drawing.Color.Transparent;
            this.imgFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgFood.Location = new System.Drawing.Point(3, 57);
            this.imgFood.Name = "imgFood";
            this.imgFood.Padding = new System.Windows.Forms.Padding(15);
            this.imgFood.ShadowDecoration.Parent = this.imgFood;
            this.imgFood.Size = new System.Drawing.Size(274, 210);
            this.imgFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFood.TabIndex = 2;
            this.imgFood.TabStop = false;
            this.imgFood.UseTransparentBackground = true;
            // 
            // FoodPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableContainer);
            this.Name = "FoodPanel";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.Size = new System.Drawing.Size(300, 300);
            this.Click += new System.EventHandler(this.FoodPanel_Click);
            this.tableContainer.ResumeLayout(false);
            this.tableContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableContainer;
        private System.Windows.Forms.Label lblFood;
        private Guna.UI2.WinForms.Guna2PictureBox imgFood;
    }
}
