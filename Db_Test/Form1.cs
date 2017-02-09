using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            refreshDataGridMovies();
            dataGridViewMovies.Visible = true;
            refreshDataGridCategories();
            dataGridViewCategories.Visible = true;
        }

        private void refreshDataGridMovies()
        {
            logicMovies.GetAllMoviesDetails(dataGridViewMovies, true);
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



        /// <summary>
        /// uses regular expressions to validate the duration
        /// </summary>
        /// <param name="strDuration"></param>
        /// <returns></returns>
        public bool validateDuration(string strDuration)
        {
            Regex regex = new Regex(@"^\[0-2]|[0-4]:[0-5][0-9]:[0-5][0-9]$");
            Match match = regex.Match(strDuration);
            return match.Success;
        }

        /// <summary>
        /// uses regular expressions to validate the link.
        /// </summary>
        /// <param name="strLink"></param>
        /// <returns></returns>
        public bool validateLink(string strLink)
        {
            Regex regex = new Regex(@"^((http[s]?|ftp):\/)?\/?([^:\/\s]+)((\/\w+)*\/)([\w\-\.]+[^#?\s]+)(.*)?(#[\w\-]+)?$");
            Match match = regex.Match(strLink);
            return match.Success;
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

        private void dataGridViewMovies_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }



        // Handeling events for buttons  inside the dataGridView
        private void dataGridViewMovies_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].Name == "Click to watch")
            {
                WatchMovieForm watchMov = new WatchMovieForm();
                watchMov.Show();
                watchMov.webBrowser1.Navigate(dataGridViewMovies.Rows[e.RowIndex].Cells[5].Value.ToString());
            }
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].Name == "Save")
            {

                BuildMovieObjectAndSendToDB(sender, e);

            }
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].Name == "Delete")
            {
                int id;
                try
                {
                    id = int.Parse(senderGrid.Rows[e.RowIndex].Cells["Movie ID"].FormattedValue.ToString());
                }
                catch (Exception)
                {
                    id = -1;
                }
                if ( id > 0 )
                {
                    logicMovies.DeleteMovie(id);
                    refreshDataGridMovies();
                }
                else
                {
                    try
                    {
                        senderGrid.Rows.RemoveAt(e.RowIndex);
                        refreshDataGridMovies();
                    }
                    catch (Exception)
                    {
                        
                    }

                }
            }

            //TODO - add the logic to save the updated/deleted/new movie!!!
        }

        private void BuildMovieObjectAndSendToDB(object sender, DataGridViewCellEventArgs e)
        {
            var snderGrid = (DataGridView)sender;
            int id;
            string newName;
            try
            {
                id = (int.Parse(dataGridViewMovies.Rows[e.RowIndex].Cells[0].Value.ToString()));

            }
            catch (Exception)
            {

                id = -1;
            }
            try
            {
                newName = dataGridViewMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                newName = string.Empty;
            }
            string duration = dataGridViewMovies.Rows[e.RowIndex].Cells["Duration"].FormattedValue.ToString();
            string catName = dataGridViewMovies.Rows[e.RowIndex].Cells["Category Name"].FormattedValue.ToString();
            string movieLink = dataGridViewMovies.Rows[e.RowIndex].Cells["Movie link"].FormattedValue.ToString();

            //Check if YRL nd Duration are valid befor Updating.
            if (validateDuration(duration) && validateLink(movieLink))
            {   //if there is no ID then you need to add it.
                if (id == -1)
                {
                    logicMovies.AddNewMovie(newName, duration, movieLink, catName);
                    refreshDataGridMovies();
                }// if you have an ID you need to update it.
                else
                {
                    logicMovies.UpdateMovie(id, newName, duration, movieLink, catName);
                    refreshDataGridMovies();
                }
            }
            else
            {
                MessageBox.Show("Duration or Link are not well formated.\n Please make sure it's in the correct format and try again.");
            }
        }

        private void dataGridViewMovies_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //refreshDataGridMovies();
        }


    }
}
