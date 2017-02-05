using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class Form1 : Form
    {
        MoviesLogic logicMovies = new MoviesLogic();
        CategoriesLogic logicCategories = new CategoriesLogic();


        public Form1()
        {
            InitializeComponent();
            regreshDataGridMovies();
            dataGridViewMovies.Visible = true;
            refreshDataGridCategories();
            dataGridViewCategories.Visible = true;
        }

        private void regreshDataGridMovies()
        {
            logicMovies.GetAllMoviesDetails(dataGridViewMovies);
        }

        private void refreshDataGridCategories()
        {
            logicCategories.GetCategoriesDetails(dataGridViewCategories);
        }

        private void uiDisplaySelector(bool mode)
        {
            if (mode)
            {
                dataGridViewMovies.Visible = true;
                manageMoviesBtn.Visible = false;
                manageCatagoriesBtn.Visible = false;

            }
        }


        // Creating buttons inside the dataGridView
        private void dataGridViewMovies_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                WatchMovieForm watchMov = new WatchMovieForm();
                watchMov.Show();

                watchMov.webBrowser1.Navigate(dataGridViewMovies.Rows[e.RowIndex].Cells[5].Value.ToString());
            }
        }
        /// <summary>
        /// this function handels the editing of the Categories table, it checks if the value is empty of the name to delete,
        /// new to add, or changed (already has a CategoryID) to update.
        /// it then uses the  refreshDataGridCategories() to refresh the view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewCategories_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var snderGrid = (DataGridView)sender;
            int id;
            string newName;
            try
            {
                id = (int.Parse(dataGridViewCategories.Rows[e.RowIndex].Cells[0].Value.ToString()));
            }
            catch (Exception)
            {
                id = -1;
            }
            try
            {
                newName = dataGridViewCategories.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                newName = string.Empty;
            }

            if (snderGrid.Columns[e.ColumnIndex].HeaderText == "Category Name")
            {

                if (newName == null || (newName == string.Empty && id == -1))
                {
                    return;
                }
                else if (id != -1 && (newName == null || newName == string.Empty))
                {
                    logicCategories.DeleteCategory(id);
                    BeginInvoke(new MethodInvoker(refreshDataGridCategories));
                   // refreshDataGridCategories();
                }
                else if (newName == null || newName == string.Empty)
                {
                    logicCategories.AddNewCategory(newName);
                    BeginInvoke(new MethodInvoker(refreshDataGridCategories));

                }
                else if (id == -1 && (newName != null || newName != string.Empty))
                {
                    logicCategories.AddNewCategory(newName);
                    BeginInvoke(new MethodInvoker(refreshDataGridCategories));

                }

                else if (id != -1 && (newName != null || newName != string.Empty))
                {
                    logicCategories.UpdateCategories(newName, id);
                    BeginInvoke(new MethodInvoker(refreshDataGridCategories));

                }


            }
        }
    }
}
