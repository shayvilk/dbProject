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
    public partial class UpdateCategoryForm :BaseForm
    {
        CategoriesLogic logic = new CategoriesLogic();

        public UpdateCategoryForm()
        {
            InitializeComponent();
        }

        private void UpdateCategoryForm_Load(object sender, EventArgs e)
        {
            UpdateCategoryComboBox();
        }

        private void comboBoxCategoryName_DropDown(object sender, EventArgs e)
        {
            UpdateCategoryComboBox();
        }
        
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxCategoryName.SelectedItem== null)
            {
                MessageBox.Show("Please select category from the list");
                return;
            }

            logic.UpdateCategories(textBoxNewName.Text,comboBoxCategoryName.Text);

            comboBoxCategoryName.SelectedItem = null;

            textBoxNewName.Clear();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        /// <summary>
        /// Updating the data in the combobox 
        /// </summary>
        private void UpdateCategoryComboBox()
        {
            comboBoxCategoryName.Items.Clear();

            foreach (var item in logic.GetCategoriesNamesList())
            {
                comboBoxCategoryName.Items.Add(item);
            }
        }
    }
}
