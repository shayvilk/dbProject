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
    public partial class MangeCategoriesForm : BaseForm

    {
        public MangeCategoriesForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            NewCategoryForm newCat = new NewCategoryForm();
            newCat.ShowDialog();
        }

        private void buttonDelCAtegory_Click(object sender, EventArgs e)
        {
            DelCategoryForm delCat = new DelCategoryForm();
            delCat.ShowDialog();
        }

        private void buttonUpdateCat_Click(object sender, EventArgs e)
        {
            UpdateCategoryForm updateCat = new UpdateCategoryForm();
            updateCat.ShowDialog();
        }

        private void buttonCatLIst_Click(object sender, EventArgs e)
        {
            CategoryListForm catList = new CategoryListForm();
            catList.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
