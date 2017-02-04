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
    public partial class NewCategoryForm : BaseForm
    {

        public NewCategoryForm()
        {
            InitializeComponent();
        }

        private void buttonAddCat_Click(object sender, EventArgs e)
        {
            CategoriesLogic logic = new CategoriesLogic();

            logic.AddNewCategory(textBoxCatName.Text);

            // inform to AddNewMovieForm that the creation of a new category was successful
            if (logic.isOk)
            {
                DialogResult = DialogResult.OK;  
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
