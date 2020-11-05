﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodIt.FoodIt.dtos;
using System.IO;
using Guna.UI2.WinForms;
using FoodIt.FoodIt.views;
using FoodIt.dtos;

namespace FoodIt
{
    public partial class FoodPanel : UserControl
    {
        private Recipe recipe;
        private Guna2Panel mainPnl;
        private User user;

        public Guna2Panel MainPnl { get => mainPnl; set => mainPnl = value; }
        public User User { get => user; set => user = value; }

        public FoodPanel(Recipe recipe)
        {
            InitializeComponent();
            this.recipe = recipe;
            this.lblFood.Text = recipe.Title;

            string imgage = recipe.Image.Substring(recipe.Image.LastIndexOf('/') + 1);

            // This will get the current WORKING directory (i.e. \bin\Debug)
            string workingDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // This will get the current PROJECT directory
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

            String path =  projectDirectory + @"\resources\img\" + imgage;
            SetImageURL(path);

            AttachClickEventHandler();
        }

        private void AttachClickEventHandler()
        {
            foreach (Control c in this.tableContainer.Controls)
            {
                Console.WriteLine(c);
                c.Click += FoodPanel_Click;
            }
        }

        public void SetLblFood(String text)
        {
            lblFood.Text = text;
        }

        public void SetImgFood(Image image)
        {
            imgFood.Image = image;
        }

        public void SetImageURL(String url)
        {
            imgFood.ImageLocation = url;
        }

        private void FoodPanel_Click(object sender, EventArgs e)
        {
            this.mainPnl.Controls.Clear();
            ViewRecipePanel viewRecipePanel = new ViewRecipePanel(this.recipe, this.User);
            viewRecipePanel.MainForm = this.mainPnl.Parent as MainForm;
            this.mainPnl.Controls.Add(viewRecipePanel);
        }
    }
}
