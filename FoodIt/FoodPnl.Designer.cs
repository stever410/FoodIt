namespace FoodIt
{
    partial class FoodPnl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFood = new System.Windows.Forms.Label();
            this.imgFood = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblFood, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.imgFood, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.34495F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.65505F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(391, 287);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.BackColor = System.Drawing.Color.Transparent;
            this.lblFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFood.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFood.Location = new System.Drawing.Point(3, 0);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(385, 67);
            this.lblFood.TabIndex = 1;
            this.lblFood.Text = "Hello World";
            this.lblFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgFood
            // 
            this.imgFood.BackColor = System.Drawing.Color.Transparent;
            this.imgFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgFood.Location = new System.Drawing.Point(3, 70);
            this.imgFood.Name = "imgFood";
            this.imgFood.ShadowDecoration.Parent = this.imgFood;
            this.imgFood.Size = new System.Drawing.Size(385, 214);
            this.imgFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFood.TabIndex = 2;
            this.imgFood.TabStop = false;
            this.imgFood.Click += new System.EventHandler(this.imgFood_Click);
            // 
            // FoodPnl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FoodPnl";
            this.Size = new System.Drawing.Size(391, 287);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFood;
        private Guna.UI2.WinForms.Guna2PictureBox imgFood;
    }
}
