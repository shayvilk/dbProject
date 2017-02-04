using BusinessLogic;
using Data_Access_Layer;
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
    public partial class CategoryListForm : BaseForm
    {
        CategoriesLogic logic = new CategoriesLogic();
        public CategoryListForm()
        {
            InitializeComponent();
            logic.GetCategoriesDetails(dataGridView1);
        }

        
    }
}
