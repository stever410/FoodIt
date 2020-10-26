using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodIt.FoodIt.dtos;
using FoodIt.FoodIt.daos;
using Guna.UI2.WinForms;

namespace FoodIt
{
    public partial class FoodGridPanel : UserControl
    {
        private const int ROWS = 4;
        private const int COLS = 4;
        private List<Recipe> recipes;
        private const int PAGE_SIZE = 16;
        private int totalRecords, totalPages;
        private int pageNo = 1;
        private Guna2Panel mainPnl;

        public FoodGridPanel(Guna2Panel mainPnl)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.mainPnl = mainPnl;
        }

        private void LoadFoodGrid()
        {
            // clear current page
            pnlMain.Controls.Clear();

            // init grid layout inside main panel
            pnlMain.RowCount = ROWS;
            pnlMain.ColumnCount = COLS;

            // get recipe based on pageNo
            int recipeNo = (pageNo - 1) * PAGE_SIZE;

            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    FoodPanel foodPanel = new FoodPanel(recipes[recipeNo]);

                    // pass main panel
                    foodPanel.MainPnl = this.mainPnl;

                    pnlMain.Controls.Add(foodPanel, j, i);
                    recipeNo++;
                    // when exist total records just done
                    if (recipeNo >= recipes.Count)
                    {
                        return;
                    }
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pageNo != totalPages)
            {
                ++pageNo;
            }
            else
            {
                pageNo = 1;
            }
            LoadFoodGrid();
            lblPaging.Text = pageNo + "/" + totalPages;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (pageNo != 1)
            {
                --pageNo;
            }
            else
            {
                pageNo = totalPages;
            }
            LoadFoodGrid();
            lblPaging.Text = pageNo + "/" + totalPages;
        }

        private void FoodGridPanel_Load(object sender, EventArgs e)
        {
            try 
            { 
                recipes = RecipeDAO.GetAllRecipes();

                // paging steps
                totalRecords = recipes.Count;
                totalPages = (int)Math.Ceiling(totalRecords * 1.0 / PAGE_SIZE);
                lblPaging.Text = pageNo + "/" + totalPages;

                LoadFoodGrid();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            }
        }
    }
}
