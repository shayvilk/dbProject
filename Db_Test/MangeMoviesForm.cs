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
    public partial class MangeMoviesForm : BaseForm
    {
        public MangeMoviesForm()
        {
            InitializeComponent();
        }

        private void buttonDelMovie_Click(object sender, EventArgs e)
        {
            DelMovieForm delMov = new DelMovieForm();
            delMov.ShowDialog();
        }

        private void buttonAddMovie_Click(object sender, EventArgs e)
        {
            AddMovieForm addMov = new AddMovieForm();
            addMov.ShowDialog();
        }

        private void buttonUpdateMovie_Click(object sender, EventArgs e)
        {
            UpdateMovieForm updateMov = new UpdateMovieForm();
            updateMov.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
