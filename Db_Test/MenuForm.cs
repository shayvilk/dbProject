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
    public partial class MenuForm : BaseForm
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void buttonMovieList_Click(object sender, EventArgs e)
        {
            MovieListForm movList = new MovieListForm();
            movList.Show();
        }

        private void buttonManegeCat_Click(object sender, EventArgs e)
        {
            MangeCategoriesForm mngCat = new MangeCategoriesForm();
            mngCat.Show();
        }

        private void buttonManegeMovies_Click(object sender, EventArgs e)
        {
            MangeMoviesForm mngMov = new MangeMoviesForm();
            mngMov.Show();
        }

        private void buttonOpenYouTube_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "https://www.youtube.com");
        }
    }
}
