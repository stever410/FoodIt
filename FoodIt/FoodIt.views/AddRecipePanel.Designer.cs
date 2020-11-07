namespace FoodIt.FoodIt.views
{
    partial class AddRecipePanel
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
            this.components = new System.ComponentModel.Container();
            this.txtNote = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.recipeFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.txtIngredientAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIngredient = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImage = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddIngre = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateIngre = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteIngre = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteStep = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateStep = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddStep = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStepDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtStepImage = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStepOrder = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvIngredientDetail = new System.Windows.Forms.DataGridView();
            this.dgvStepDetail = new System.Windows.Forms.DataGridView();
            this.btnStepImage = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnRecipeImage = new Guna.UI2.WinForms.Guna2ImageButton();
            this.stepFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.bsStep = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStepDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStep)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNote
            // 
            this.txtNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNote.DefaultText = "";
            this.txtNote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNote.DisabledState.Parent = this.txtNote;
            this.txtNote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.txtNote.FocusedState.Parent = this.txtNote;
            this.txtNote.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.txtNote.HoverState.Parent = this.txtNote;
            this.txtNote.Location = new System.Drawing.Point(937, 446);
            this.txtNote.Name = "txtNote";
            this.txtNote.PasswordChar = '\0';
            this.txtNote.PlaceholderText = "";
            this.txtNote.SelectedText = "";
            this.txtNote.ShadowDecoration.Parent = this.txtNote;
            this.txtNote.Size = new System.Drawing.Size(366, 36);
            this.txtNote.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(784, 446);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 21);
            this.label8.TabIndex = 57;
            this.label8.Text = "Ingredient Note";
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // recipeFileDlg
            // 
            this.recipeFileDlg.FileName = "openFileDialog1";
            this.recipeFileDlg.Filter = "Image Files (*.jpg;*.jpeg;.*.png;)|*.jpg;*.jpeg;.*.png";
            this.recipeFileDlg.ShowHelp = true;
            this.recipeFileDlg.FileOk += new System.ComponentModel.CancelEventHandler(this.recipeFileDlg_FileOk);
            // 
            // txtIngredientAmount
            // 
            this.txtIngredientAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIngredientAmount.DefaultText = "";
            this.txtIngredientAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIngredientAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIngredientAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIngredientAmount.DisabledState.Parent = this.txtIngredientAmount;
            this.txtIngredientAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIngredientAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.txtIngredientAmount.FocusedState.Parent = this.txtIngredientAmount;
            this.txtIngredientAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIngredientAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.txtIngredientAmount.HoverState.Parent = this.txtIngredientAmount;
            this.txtIngredientAmount.Location = new System.Drawing.Point(937, 383);
            this.txtIngredientAmount.Name = "txtIngredientAmount";
            this.txtIngredientAmount.PasswordChar = '\0';
            this.txtIngredientAmount.PlaceholderText = "";
            this.txtIngredientAmount.SelectedText = "";
            this.txtIngredientAmount.ShadowDecoration.Parent = this.txtIngredientAmount;
            this.txtIngredientAmount.Size = new System.Drawing.Size(366, 36);
            this.txtIngredientAmount.TabIndex = 55;
            // 
            // txtIngredient
            // 
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
            this.txtIngredient.Location = new System.Drawing.Point(937, 317);
            this.txtIngredient.Name = "txtIngredient";
            this.txtIngredient.PasswordChar = '\0';
            this.txtIngredient.PlaceholderText = "";
            this.txtIngredient.SelectedText = "";
            this.txtIngredient.ShadowDecoration.Parent = this.txtIngredient;
            this.txtIngredient.Size = new System.Drawing.Size(366, 36);
            this.txtIngredient.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(783, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 21);
            this.label6.TabIndex = 53;
            this.label6.Text = "Ingredient Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 21);
            this.label3.TabIndex = 48;
            this.label3.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Animated = true;
            this.txtTitle.BackColor = System.Drawing.Color.CadetBlue;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.DefaultText = "";
            this.txtTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.DisabledState.Parent = this.txtTitle;
            this.txtTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.txtTitle.FocusedState.Parent = this.txtTitle;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.txtTitle.HoverState.Parent = this.txtTitle;
            this.txtTitle.Location = new System.Drawing.Point(194, 107);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitle.MaxLength = 100;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.PlaceholderText = "";
            this.txtTitle.SelectedText = "";
            this.txtTitle.ShadowDecoration.Parent = this.txtTitle;
            this.txtTitle.Size = new System.Drawing.Size(449, 36);
            this.txtTitle.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(783, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 50;
            this.label4.Text = "Ingredient";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(784, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 42;
            this.label5.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Animated = true;
            this.txtDescription.AutoScroll = true;
            this.txtDescription.BackColor = System.Drawing.Color.CadetBlue;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.DisabledState.Parent = this.txtDescription;
            this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.txtDescription.FocusedState.Parent = this.txtDescription;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.txtDescription.HoverState.Parent = this.txtDescription;
            this.txtDescription.Location = new System.Drawing.Point(937, 107);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.MaxLength = 500;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectedText = "";
            this.txtDescription.ShadowDecoration.Parent = this.txtDescription;
            this.txtDescription.Size = new System.Drawing.Size(366, 107);
            this.txtDescription.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 43;
            this.label1.Text = "Image";
            // 
            // txtImage
            // 
            this.txtImage.AllowDrop = true;
            this.txtImage.Animated = true;
            this.txtImage.BackColor = System.Drawing.Color.CadetBlue;
            this.txtImage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtImage.DefaultText = "";
            this.txtImage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtImage.DisabledState.Parent = this.txtImage;
            this.txtImage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtImage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.txtImage.FocusedState.Parent = this.txtImage;
            this.txtImage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.txtImage.HoverState.Parent = this.txtImage;
            this.txtImage.Location = new System.Drawing.Point(194, 178);
            this.txtImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImage.MaxLength = 500;
            this.txtImage.Name = "txtImage";
            this.txtImage.PasswordChar = '\0';
            this.txtImage.PlaceholderText = "";
            this.txtImage.ReadOnly = true;
            this.txtImage.SelectedText = "";
            this.txtImage.ShadowDecoration.Parent = this.txtImage;
            this.txtImage.Size = new System.Drawing.Size(449, 36);
            this.txtImage.TabIndex = 44;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BorderRadius = 5;
            this.btnSubmit.CheckedState.Parent = this.btnSubmit;
            this.btnSubmit.CustomImages.Parent = this.btnSubmit;
            this.btnSubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.HoverState.Parent = this.btnSubmit;
            this.btnSubmit.Location = new System.Drawing.Point(629, 804);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.ShadowDecoration.Parent = this.btnSubmit;
            this.btnSubmit.Size = new System.Drawing.Size(200, 45);
            this.btnSubmit.TabIndex = 62;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label2.Location = new System.Drawing.Point(624, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 30);
            this.label2.TabIndex = 63;
            this.label2.Text = "Fill your recipe here";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddIngre
            // 
            this.btnAddIngre.BorderRadius = 5;
            this.btnAddIngre.CheckedState.Parent = this.btnAddIngre;
            this.btnAddIngre.CustomImages.Parent = this.btnAddIngre;
            this.btnAddIngre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.btnAddIngre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIngre.ForeColor = System.Drawing.Color.White;
            this.btnAddIngre.HoverState.Parent = this.btnAddIngre;
            this.btnAddIngre.Location = new System.Drawing.Point(787, 525);
            this.btnAddIngre.Name = "btnAddIngre";
            this.btnAddIngre.ShadowDecoration.Parent = this.btnAddIngre;
            this.btnAddIngre.Size = new System.Drawing.Size(116, 36);
            this.btnAddIngre.TabIndex = 70;
            this.btnAddIngre.Text = "Add";
            this.btnAddIngre.Click += new System.EventHandler(this.btnAddIngre_Click);
            // 
            // btnUpdateIngre
            // 
            this.btnUpdateIngre.BorderRadius = 5;
            this.btnUpdateIngre.CheckedState.Parent = this.btnUpdateIngre;
            this.btnUpdateIngre.CustomImages.Parent = this.btnUpdateIngre;
            this.btnUpdateIngre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.btnUpdateIngre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateIngre.ForeColor = System.Drawing.Color.White;
            this.btnUpdateIngre.HoverState.Parent = this.btnUpdateIngre;
            this.btnUpdateIngre.Location = new System.Drawing.Point(997, 525);
            this.btnUpdateIngre.Name = "btnUpdateIngre";
            this.btnUpdateIngre.ShadowDecoration.Parent = this.btnUpdateIngre;
            this.btnUpdateIngre.Size = new System.Drawing.Size(116, 36);
            this.btnUpdateIngre.TabIndex = 71;
            this.btnUpdateIngre.Text = "Update";
            this.btnUpdateIngre.Click += new System.EventHandler(this.btnUpdateIngre_Click);
            // 
            // btnDeleteIngre
            // 
            this.btnDeleteIngre.BorderRadius = 5;
            this.btnDeleteIngre.CheckedState.Parent = this.btnDeleteIngre;
            this.btnDeleteIngre.CustomImages.Parent = this.btnDeleteIngre;
            this.btnDeleteIngre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.btnDeleteIngre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteIngre.ForeColor = System.Drawing.Color.White;
            this.btnDeleteIngre.HoverState.Parent = this.btnDeleteIngre;
            this.btnDeleteIngre.Location = new System.Drawing.Point(1187, 525);
            this.btnDeleteIngre.Name = "btnDeleteIngre";
            this.btnDeleteIngre.ShadowDecoration.Parent = this.btnDeleteIngre;
            this.btnDeleteIngre.Size = new System.Drawing.Size(116, 36);
            this.btnDeleteIngre.TabIndex = 72;
            this.btnDeleteIngre.Text = "Delete";
            this.btnDeleteIngre.Click += new System.EventHandler(this.btnDeleteIngre_Click);
            // 
            // btnDeleteStep
            // 
            this.btnDeleteStep.BorderRadius = 5;
            this.btnDeleteStep.CheckedState.Parent = this.btnDeleteStep;
            this.btnDeleteStep.CustomImages.Parent = this.btnDeleteStep;
            this.btnDeleteStep.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.btnDeleteStep.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStep.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStep.HoverState.Parent = this.btnDeleteStep;
            this.btnDeleteStep.Location = new System.Drawing.Point(527, 525);
            this.btnDeleteStep.Name = "btnDeleteStep";
            this.btnDeleteStep.ShadowDecoration.Parent = this.btnDeleteStep;
            this.btnDeleteStep.Size = new System.Drawing.Size(116, 36);
            this.btnDeleteStep.TabIndex = 86;
            this.btnDeleteStep.Text = "Delete";
            this.btnDeleteStep.Click += new System.EventHandler(this.btnDeleteStep_Click);
            // 
            // btnUpdateStep
            // 
            this.btnUpdateStep.BorderRadius = 5;
            this.btnUpdateStep.CheckedState.Parent = this.btnUpdateStep;
            this.btnUpdateStep.CustomImages.Parent = this.btnUpdateStep;
            this.btnUpdateStep.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.btnUpdateStep.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStep.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStep.HoverState.Parent = this.btnUpdateStep;
            this.btnUpdateStep.Location = new System.Drawing.Point(305, 525);
            this.btnUpdateStep.Name = "btnUpdateStep";
            this.btnUpdateStep.ShadowDecoration.Parent = this.btnUpdateStep;
            this.btnUpdateStep.Size = new System.Drawing.Size(116, 36);
            this.btnUpdateStep.TabIndex = 85;
            this.btnUpdateStep.Text = "Update";
            this.btnUpdateStep.Click += new System.EventHandler(this.btnUpdateStep_Click);
            // 
            // btnAddStep
            // 
            this.btnAddStep.BorderRadius = 5;
            this.btnAddStep.CheckedState.Parent = this.btnAddStep;
            this.btnAddStep.CustomImages.Parent = this.btnAddStep;
            this.btnAddStep.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.btnAddStep.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStep.ForeColor = System.Drawing.Color.White;
            this.btnAddStep.HoverState.Parent = this.btnAddStep;
            this.btnAddStep.Location = new System.Drawing.Point(91, 525);
            this.btnAddStep.Name = "btnAddStep";
            this.btnAddStep.ShadowDecoration.Parent = this.btnAddStep;
            this.btnAddStep.Size = new System.Drawing.Size(116, 36);
            this.btnAddStep.TabIndex = 84;
            this.btnAddStep.Text = "Add";
            this.btnAddStep.Click += new System.EventHandler(this.btnAddStep_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(87, 461);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 21);
            this.label9.TabIndex = 82;
            this.label9.Text = "Step image";
            // 
            // txtStepDescription
            // 
            this.txtStepDescription.Animated = true;
            this.txtStepDescription.AutoScroll = true;
            this.txtStepDescription.BackColor = System.Drawing.Color.CadetBlue;
            this.txtStepDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStepDescription.DefaultText = "";
            this.txtStepDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStepDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStepDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStepDescription.DisabledState.Parent = this.txtStepDescription;
            this.txtStepDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStepDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.txtStepDescription.FocusedState.Parent = this.txtStepDescription;
            this.txtStepDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStepDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.txtStepDescription.HoverState.Parent = this.txtStepDescription;
            this.txtStepDescription.Location = new System.Drawing.Point(194, 332);
            this.txtStepDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStepDescription.MaxLength = 500;
            this.txtStepDescription.Multiline = true;
            this.txtStepDescription.Name = "txtStepDescription";
            this.txtStepDescription.PasswordChar = '\0';
            this.txtStepDescription.PlaceholderText = "";
            this.txtStepDescription.SelectedText = "";
            this.txtStepDescription.ShadowDecoration.Parent = this.txtStepDescription;
            this.txtStepDescription.Size = new System.Drawing.Size(449, 97);
            this.txtStepDescription.TabIndex = 81;
            // 
            // txtStepImage
            // 
            this.txtStepImage.AllowDrop = true;
            this.txtStepImage.Animated = true;
            this.txtStepImage.BackColor = System.Drawing.Color.CadetBlue;
            this.txtStepImage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStepImage.DefaultText = "";
            this.txtStepImage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStepImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStepImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStepImage.DisabledState.Parent = this.txtStepImage;
            this.txtStepImage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStepImage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.txtStepImage.FocusedState.Parent = this.txtStepImage;
            this.txtStepImage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStepImage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.txtStepImage.HoverState.Parent = this.txtStepImage;
            this.txtStepImage.Location = new System.Drawing.Point(194, 461);
            this.txtStepImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStepImage.MaxLength = 500;
            this.txtStepImage.Name = "txtStepImage";
            this.txtStepImage.PasswordChar = '\0';
            this.txtStepImage.PlaceholderText = "";
            this.txtStepImage.ReadOnly = true;
            this.txtStepImage.SelectedText = "";
            this.txtStepImage.ShadowDecoration.Parent = this.txtStepImage;
            this.txtStepImage.Size = new System.Drawing.Size(449, 36);
            this.txtStepImage.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(87, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 21);
            this.label7.TabIndex = 79;
            this.label7.Text = "Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label10.Location = new System.Drawing.Point(348, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 30);
            this.label10.TabIndex = 88;
            this.label10.Text = "Step detail";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label11.Location = new System.Drawing.Point(992, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 30);
            this.label11.TabIndex = 89;
            this.label11.Text = "Ingredient Detail";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoScroll = true;
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.guna2Panel1.Controls.Add(this.label12);
            this.guna2Panel1.Controls.Add(this.txtStepOrder);
            this.guna2Panel1.Controls.Add(this.dgvIngredientDetail);
            this.guna2Panel1.Controls.Add(this.dgvStepDetail);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label11);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label10);
            this.guna2Panel1.Controls.Add(this.btnSubmit);
            this.guna2Panel1.Controls.Add(this.btnStepImage);
            this.guna2Panel1.Controls.Add(this.txtImage);
            this.guna2Panel1.Controls.Add(this.btnDeleteStep);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.btnUpdateStep);
            this.guna2Panel1.Controls.Add(this.btnRecipeImage);
            this.guna2Panel1.Controls.Add(this.btnAddStep);
            this.guna2Panel1.Controls.Add(this.txtDescription);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label9);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.txtStepDescription);
            this.guna2Panel1.Controls.Add(this.txtTitle);
            this.guna2Panel1.Controls.Add(this.txtStepImage);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.txtIngredient);
            this.guna2Panel1.Controls.Add(this.btnDeleteIngre);
            this.guna2Panel1.Controls.Add(this.txtIngredientAmount);
            this.guna2Panel1.Controls.Add(this.btnUpdateIngre);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Controls.Add(this.btnAddIngre);
            this.guna2Panel1.Controls.Add(this.txtNote);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1326, 827);
            this.guna2Panel1.TabIndex = 91;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(87, 274);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 21);
            this.label12.TabIndex = 94;
            this.label12.Text = "StepOrder";
            // 
            // txtStepOrder
            // 
            this.txtStepOrder.AllowDrop = true;
            this.txtStepOrder.Animated = true;
            this.txtStepOrder.BackColor = System.Drawing.Color.CadetBlue;
            this.txtStepOrder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStepOrder.DefaultText = "";
            this.txtStepOrder.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStepOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStepOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStepOrder.DisabledState.Parent = this.txtStepOrder;
            this.txtStepOrder.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStepOrder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.txtStepOrder.FocusedState.Parent = this.txtStepOrder;
            this.txtStepOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStepOrder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.txtStepOrder.HoverState.Parent = this.txtStepOrder;
            this.txtStepOrder.Location = new System.Drawing.Point(194, 274);
            this.txtStepOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStepOrder.MaxLength = 500;
            this.txtStepOrder.Name = "txtStepOrder";
            this.txtStepOrder.PasswordChar = '\0';
            this.txtStepOrder.PlaceholderText = "";
            this.txtStepOrder.ReadOnly = true;
            this.txtStepOrder.SelectedText = "";
            this.txtStepOrder.ShadowDecoration.Parent = this.txtStepOrder;
            this.txtStepOrder.Size = new System.Drawing.Size(65, 36);
            this.txtStepOrder.TabIndex = 93;
            // 
            // dgvIngredientDetail
            // 
            this.dgvIngredientDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvIngredientDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvIngredientDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredientDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(235)))));
            this.dgvIngredientDetail.Location = new System.Drawing.Point(787, 586);
            this.dgvIngredientDetail.Name = "dgvIngredientDetail";
            this.dgvIngredientDetail.ReadOnly = true;
            this.dgvIngredientDetail.Size = new System.Drawing.Size(516, 189);
            this.dgvIngredientDetail.TabIndex = 92;
            // 
            // dgvStepDetail
            // 
            this.dgvStepDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvStepDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStepDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStepDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(235)))));
            this.dgvStepDetail.Location = new System.Drawing.Point(91, 586);
            this.dgvStepDetail.Name = "dgvStepDetail";
            this.dgvStepDetail.ReadOnly = true;
            this.dgvStepDetail.Size = new System.Drawing.Size(552, 189);
            this.dgvStepDetail.TabIndex = 91;
            // 
            // btnStepImage
            // 
            this.btnStepImage.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnStepImage.CheckedState.Parent = this.btnStepImage;
            this.btnStepImage.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnStepImage.HoverState.Parent = this.btnStepImage;
            this.btnStepImage.Image = global::FoodIt.Properties.Resources.folder;
            this.btnStepImage.ImageRotate = 0F;
            this.btnStepImage.ImageSize = new System.Drawing.Size(24, 24);
            this.btnStepImage.Location = new System.Drawing.Point(659, 461);
            this.btnStepImage.Name = "btnStepImage";
            this.btnStepImage.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnStepImage.PressedState.Parent = this.btnStepImage;
            this.btnStepImage.Size = new System.Drawing.Size(28, 32);
            this.btnStepImage.TabIndex = 87;
            this.btnStepImage.Click += new System.EventHandler(this.btnStepImage_Click);
            // 
            // btnRecipeImage
            // 
            this.btnRecipeImage.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnRecipeImage.CheckedState.Parent = this.btnRecipeImage;
            this.btnRecipeImage.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRecipeImage.HoverState.Parent = this.btnRecipeImage;
            this.btnRecipeImage.Image = global::FoodIt.Properties.Resources.folder;
            this.btnRecipeImage.ImageRotate = 0F;
            this.btnRecipeImage.ImageSize = new System.Drawing.Size(24, 24);
            this.btnRecipeImage.Location = new System.Drawing.Point(659, 178);
            this.btnRecipeImage.Name = "btnRecipeImage";
            this.btnRecipeImage.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRecipeImage.PressedState.Parent = this.btnRecipeImage;
            this.btnRecipeImage.Size = new System.Drawing.Size(28, 32);
            this.btnRecipeImage.TabIndex = 49;
            this.btnRecipeImage.Click += new System.EventHandler(this.btnRecipeImage_Click);
            // 
            // stepFileDlg
            // 
            this.stepFileDlg.FileName = "openFileDialog1";
            this.stepFileDlg.Filter = "Image Files (*.jpg;*.jpeg;.*.png;)|*.jpg;*.jpeg;.*.png";
            this.stepFileDlg.ShowHelp = true;
            this.stepFileDlg.FileOk += new System.ComponentModel.CancelEventHandler(this.stepFileDlg_FileOk);
            // 
            // AddRecipePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.guna2Panel1);
            this.Name = "AddRecipePanel";
            this.Size = new System.Drawing.Size(1326, 827);
            this.Load += new System.EventHandler(this.AddRecipePanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStepDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtNote;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errProvider;
        private Guna.UI2.WinForms.Guna2TextBox txtIngredientAmount;
        private Guna.UI2.WinForms.Guna2TextBox txtIngredient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2ImageButton btnRecipeImage;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtImage;
        private System.Windows.Forms.OpenFileDialog recipeFileDlg;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnDeleteIngre;
        private Guna.UI2.WinForms.Guna2Button btnUpdateIngre;
        private Guna.UI2.WinForms.Guna2Button btnAddIngre;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ImageButton btnStepImage;
        private Guna.UI2.WinForms.Guna2Button btnDeleteStep;
        private Guna.UI2.WinForms.Guna2Button btnUpdateStep;
        private Guna.UI2.WinForms.Guna2Button btnAddStep;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtStepDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtStepImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.OpenFileDialog stepFileDlg;
        private System.Windows.Forms.DataGridView dgvStepDetail;
        private System.Windows.Forms.DataGridView dgvIngredientDetail;
        private System.Windows.Forms.BindingSource bsStep;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtStepOrder;
    }
}
