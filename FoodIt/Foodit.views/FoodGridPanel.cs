using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodIt.Foodit.dtos;
using FoodIt.FoodIt.daos;

namespace FoodIt
{
    public partial class FoodGridPanel : UserControl
    {
        private MainForm mainForm;
        private const int ROWS = 4;
        private const int COLS = 4;
        private List<Recipe> recipes;
        private int pageNo = 1;
        private const int PAGE_SIZE = 16;
        private int totalPages;
        private int totalRecords;

        public FoodGridPanel(MainForm mainForm)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.mainForm = mainForm;
        }

        private void LoadFoodGrid()
        {
            // clear current page
            pnlMain.Controls.Clear();

            // set paging
            int recipeNo = (pageNo - 1) * PAGE_SIZE;
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    FoodPnl foodPnl = new FoodPnl(recipes[recipeNo]);
                    // alway remember to set mainForm for child controllers
                    //foodPnl.MainForm = this.mainForm;
                    foodPnl.FoodGridPanel = this;
                    pnlMain.Controls.Add(foodPnl, j, i);
                    recipeNo++;

                    // when exist total records just done
                    if (recipeNo >= recipes.Count)
                    {
                        return;
                    }
                }
            }
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

                // set up ui
                LoadFoodGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
    }
}
