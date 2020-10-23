﻿using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FoodIt
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FoodGridPanel foodGridPanel = new FoodGridPanel(this);
            this.MainPnl.Controls.Add(foodGridPanel);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
