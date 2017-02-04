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
    public partial class MovieListForm : BaseForm
    {
        MoviesLogic logic = new MoviesLogic();

        public MovieListForm()
        {
            InitializeComponent();

            logic.GetAllMoviesDetails(dataGridView1);
        }


        // Creating buttons inside the dataGridView
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                WatchMovieForm watchMov = new WatchMovieForm();
                watchMov.Show();

                watchMov.webBrowser1.Navigate(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
            }

        }
    }
}
