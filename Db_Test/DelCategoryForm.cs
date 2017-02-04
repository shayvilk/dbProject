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
    public partial class DelCategoryForm : BaseForm
    {
        CategoriesLogic logic = new CategoriesLogic();

        public DelCategoryForm()
        {
            InitializeComponent();
        }

        private void DelCategoryForm_Load(object sender, EventArgs e)
        {
            UpdateCategoryComboBox();
        }

        private void comboBoxCategoryName_DropDown(object sender, EventArgs e)
        {
            UpdateCategoryComboBox();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // checkin if the user choose category from the list
            if (comboBoxCategoryName.SelectedItem==null)
            {
                MessageBox.Show("Please select category to delete");
                return;
            }

            logic.DeleteCategory(comboBoxCategoryName.Text);

            UpdateCategoryComboBox();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        /// <summary>
        /// Updating the combobox data & setting the selected value to " "
        /// </summary>
        private void UpdateCategoryComboBox()
        {
            comboBoxCategoryName.Items.Clear(); 

            foreach (var item in logic.GetCategoriesName())
            {
                comboBoxCategoryName.Items.Add(item);
            }
        }

       

      
            

        
        

       
    }
}
