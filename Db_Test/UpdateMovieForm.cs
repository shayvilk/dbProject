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
    public partial class UpdateMovieForm : BaseForm
    {
        MoviesLogic mLogic = new MoviesLogic();
        CategoriesLogic cLogic = new CategoriesLogic();
           
        public UpdateMovieForm()
        {
            InitializeComponent();

            // comboBoxCategory טעינת רשימת הקטגוריות לתוך
            UpdateCategoryCombobox();

            // comboBoxMovieName טעינת רשימת הסרטים לתוך
            UpdateMoviesCombobox();
        }

       
        // Displaying the details of the selected movie 
        private void comboBoxMovieName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ShowMovieDetails(mLogic.ShowMovieDetails(comboBoxMovieName.SelectedItem.ToString()));
        }
        

        private void buttonSave_Click(object sender, EventArgs e)
        {
            #region Valedation check

            if (comboBoxMovieName.SelectedItem == null)
            {
                MessageBox.Show("please select a movie to update from the list");
                return;
            }

            if (textBoxLink.Text == "")
            {
                MessageBox.Show("Please enter the movie's link");
                return;
            }

            if (comboBoxCategoryName.SelectedItem == null )
            {
                MessageBox.Show("Please select category");
                return;
            }
            #endregion

            MoviesLogic logic = new MoviesLogic();

            logic.UpdateMovie(comboBoxMovieName.Text, textBoxNewName.Text, comboBoxHour.SelectedItem.ToString(), comboBoxMin.SelectedItem.ToString(),
                              comboBoxSec.SelectedItem.ToString(), textBoxLink.Text, comboBoxCategoryName.Text);

            comboBoxMovieName.SelectedItem = null;
            textBoxNewName.Clear();

            comboBoxHour.SelectedIndex = 0;
            comboBoxMin.SelectedIndex = 0;
            comboBoxSec.SelectedIndex = 0;

            textBoxLink.Clear();

            comboBoxCategoryName.SelectedItem = null;

        }

        private void comboBoxMovieName_DropDown(object sender, EventArgs e)
        {
            UpdateMoviesCombobox();
        }

        private void comboBoxCategoryName_DropDown(object sender, EventArgs e)
        {
            comboBoxCategoryName.Items.Clear();

            foreach (var item in cLogic.GetCategoriesNamesList() )
            {
                comboBoxCategoryName.Items.Add(item);
            }
        }
        
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ShowMovieDetails(dynamic query)
        {
            // Hours Display
            if (query.Duration.Hours < 10)
                comboBoxHour.SelectedIndex = comboBoxHour.Items.IndexOf("0" + query.Duration.Hours.ToString());
            else
                comboBoxHour.SelectedIndex = comboBoxHour.Items.IndexOf(query.Duration.Hours.ToString());

            //  Minutes display
            if (query.Duration.Minutes < 10)
                comboBoxMin.SelectedIndex = comboBoxMin.Items.IndexOf("0" + query.Duration.Minutes.ToString());
            else
                comboBoxMin.SelectedIndex = comboBoxMin.Items.IndexOf(query.Duration.Minutes.ToString());

            // Seconds display
            if (query.Duration.Seconds < 10)
                comboBoxSec.SelectedIndex = comboBoxSec.Items.IndexOf("0" + query.Duration.Seconds.ToString());
            else
                comboBoxSec.SelectedIndex = comboBoxSec.Items.IndexOf(query.Duration.Seconds.ToString());

            // Link display
            textBoxLink.Text = query.MovieLink.ToString();

            // Movie's category display
            comboBoxCategoryName.SelectedItem = query.CategoryName;
        }

        /// <summary>
        /// Updating the movies combobox data
        /// </summary>
        public void UpdateMoviesCombobox()
        {
            comboBoxMovieName.Items.Clear();

            foreach (var item in mLogic.GetMoviesName())
            {
                comboBoxMovieName.Items.Add(item);
            } 

        }

        /// <summary>
        /// Updating the categories combobox data
        /// </summary>
        public void UpdateCategoryCombobox()
        {
            comboBoxCategoryName.Items.Clear();

            foreach (var item in cLogic.GetCategoriesNamesList())
            {
                comboBoxCategoryName.Items.Add(item);
            }
        }
       



    }
}
