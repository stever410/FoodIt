namespace FoodIt.Foodit.views
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
            this.lblRecipeTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRecipeTitle
            // 
            this.lblRecipeTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRecipeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipeTitle.Location = new System.Drawing.Point(0, 0);
            this.lblRecipeTitle.Name = "lblRecipeTitle";
            this.lblRecipeTitle.Size = new System.Drawing.Size(1189, 55);
            this.lblRecipeTitle.TabIndex = 0;
            this.lblRecipeTitle.Text = "Recipe Title Goes Here";
            this.lblRecipeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewRecipePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.lblRecipeTitle);
            this.Name = "ViewRecipePanel";
            this.Size = new System.Drawing.Size(1189, 665);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRecipeTitle;
    }
}
