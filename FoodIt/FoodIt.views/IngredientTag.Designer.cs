namespace FoodIt.views
{
    partial class IngredientTag
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
            this.btnDelete = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Image = global::FoodIt.Properties.Resources.delete;
            this.btnDelete.ImageRotate = 0F;
            this.btnDelete.ImageSize = new System.Drawing.Size(16, 16);
            this.btnDelete.Location = new System.Drawing.Point(98, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.btnDelete.PressedState.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(30, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblIngredient
            // 
            this.lblIngredient.AutoEllipsis = true;
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.lblIngredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIngredient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredient.ForeColor = System.Drawing.Color.White;
            this.lblIngredient.Location = new System.Drawing.Point(0, 0);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(98, 21);
            this.lblIngredient.TabIndex = 3;
            this.lblIngredient.Text = "lblIngredient";
            this.lblIngredient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IngredientTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.Controls.Add(this.lblIngredient);
            this.Controls.Add(this.btnDelete);
            this.Name = "IngredientTag";
            this.Size = new System.Drawing.Size(128, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton btnDelete;
        private System.Windows.Forms.Label lblIngredient;
    }
}
