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
    public partial class DelMovieForm : BaseForm
    {

        MoviesLogic logic = new MoviesLogic();
        public DelMovieForm()
        {
            InitializeComponent();
        }

        private void DelMovieForm_Load(object sender, EventArgs e)
        {
            UpdateCombobox();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxMovieName.Text=="") // valedation check
            {
                MessageBox.Show("Please select movie from the list");
                return;
            }

            //logic.DeleteMovie(comboBoxMovieName.Text);
           
            UpdateCombobox();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxName_DropDown(object sender, EventArgs e)
        {
            UpdateCombobox();
        }

        /// <summary>
        /// Updating the combobox data 
        /// </summary>
        private void UpdateCombobox()
        {
            comboBoxMovieName.Items.Clear();
            foreach (var item in logic.GetMoviesName())
            {
                comboBoxMovieName.Items.Add(item);
            } 
        }

        
    }
}
