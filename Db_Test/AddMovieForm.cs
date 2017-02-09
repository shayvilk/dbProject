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
    public partial class AddMovieForm : BaseForm
    {
        CategoriesLogic cLogic = new CategoriesLogic();

        public AddMovieForm()
        {
            InitializeComponent();
            ResetDuration();
        }

        private void buttonAddMovie_Click(object sender, EventArgs e)
        {
            #region validation chack

            if (textBoxName.Text=="")
            {
                MessageBox.Show("Please enter the name of the movie");
                return;
            }

            if (textBoxLink.Text== "")
            {
                MessageBox.Show("Please enter the movie's link");
                return;
            }

            if (comboBoxCategory.SelectedItem == null )
            {
                MessageBox.Show("Please select category from the list");
                return;
            }

            #endregion

            MoviesLogic mLogic = new MoviesLogic();

            //mLogic.AddNewMovie(textBoxName.Text, comboBoxHour.SelectedItem.ToString(), comboBoxMin.SelectedItem.ToString(),
            //                   comboBoxSec.SelectedItem.ToString(), textBoxLink.Text, comboBoxCategory.Text);

            
            //Clearing the textbox & the combobox after the adding is done
            textBoxName.Clear();
            textBoxLink.Clear();
            comboBoxCategory.SelectedItem = null;

            // Reset hours, minutes & seconds combobox to it's defult => 00:00:01
            ResetDuration();
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            NewCategoryForm newCat = new NewCategoryForm();
            newCat.ShowDialog();

            // If the creation of a new category was successful, update the combobox
            if (newCat.DialogResult == DialogResult.OK) 
            {
                UpdateCategoryComboBox();
            }
        }

        private void AddMovieForm_Load(object sender, EventArgs e)
        {
            UpdateCategoryComboBox();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDeleteCat_Click(object sender, EventArgs e)
        {
            DelCategoryForm delete = new DelCategoryForm();

            delete.ShowDialog();
        }

        private void comboBoxCategory_DropDown(object sender, EventArgs e)
        {
            comboBoxCategory.Items.Clear();

            UpdateCategoryComboBox();
        }

        private void buttonUpdateCat_Click(object sender, EventArgs e)
        {
            UpdateCategoryForm update = new UpdateCategoryForm();
            update.ShowDialog();
        }


        /// <summary>
        /// Reset the durations combobox to defult-> 00:00:01
        /// </summary>
        private void ResetDuration()
        {
            comboBoxHour.SelectedIndex = 0;
            comboBoxMin.SelectedIndex = 0;
            comboBoxSec.SelectedIndex = 0;
        }


        /// <summary>
        /// Updating the combobox data
        /// </summary>
        private void UpdateCategoryComboBox()
        {
            foreach (var item in cLogic.GetCategoriesNamesList())
            {
                comboBoxCategory.Items.Add(item);
            }
        }

    }
}
