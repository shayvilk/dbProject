using Data_Access_Layer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLogic
{
   public class CategoriesLogic : BaseLogic
    {
        public bool isOk { get; set; } //To inform to the NewCategoryForm that the creation of a new category was successful. 


       /// <summary>
       /// Adding new category to the DB
       /// </summary>
       /// <param name="newCategory"></param>
       public void AddNewCategory(string newCategory)
       {
            if (newCategory=="") // valedation check
            {
                MessageBox.Show("Please enter categoy name");
                return;
            }

          // Checking if the category name the user entered, already exist
          var query=  db.Categories.Where(c => c.CategoryName == newCategory).FirstOrDefault();

           if (query == null)
           {
               Category cat = new Category()
               {
                   CategoryName = newCategory
               };

               db.Categories.Add(cat);
               db.SaveChanges();

               isOk = true;
               MessageBox.Show("Catagory added");
           }
           else
               MessageBox.Show("The category " + newCategory + " already exist");
       }

       /// <summary>
       /// Updeating existing category.
       /// this method has 2 overloads, one that takes the oldName and NewNAme, and one that takes the new names and the CategoryID.
       /// </summary>
       /// <param name="newName"></param>
       /// <param name="selectedName"></param>
       /// 
       public void UpdateCategories(String newName, int categoryID)
       {
           string categoryName = GetCategoryNameByID(categoryID);
           UpdateCategories(newName, categoryName);
       }
       public void UpdateCategories(string newName, string selectedName)
       {
           if (newName == "")
           {
               MessageBox.Show("Please choose new name for this category");
               return;
           }

           var query = db.Categories.Where(c => c.CategoryName == selectedName).FirstOrDefault();

           if (query != null)
           {
               var result = db.Categories.Where(c => c.CategoryName == newName).FirstOrDefault();

               // checking if the new category name the user entered isn't already exist
               if (result == null)
               {
                   query.CategoryName = newName;
                   db.SaveChanges();

                   MessageBox.Show("The category updated!");
               }
               else
                   MessageBox.Show("There is already category in the name " + newName + "\nPlease choose a different name");
           }
           else
           {
               // If someone delete the category from the database before the user pressed the "update" button.
               MessageBox.Show("The category " + selectedName + "is no longer exist");
           }
       }

       /// <summary>
       /// Deleteing category from the DB.
       /// this methos has 2 overloads, one that takes the Name and one that takes the ID
       /// </summary>
       /// <param name="catName"></param>
       /// 
       public void DeleteCategory(int categoryID)
       {
           DeleteCategory(GetCategoryNameByID(categoryID));
       }
       public void DeleteCategory(string catName)
       {
           // Checking if the selected category isn't associated with a movie\movies
            var result = db.Movies.Where(m=> m.CategoryName == catName).FirstOrDefault();

            if (result !=null)
            {
		     MessageBox.Show("You can not delete this category\n\nThis category is associated with a movie");
                return;
            }

            var query = from cat in  db.Categories
                        where cat.CategoryName == catName
                        select cat;

            Category category = query.FirstOrDefault();
            if (category != null)
            {
                db.Categories.Remove(category);
                db.SaveChanges();

                MessageBox.Show("The category: " + catName + " has been deleted!");
            }
            else
            // If someone delete the category from the database before the user pressed the "delete" button.
            MessageBox.Show("The category: " + catName + " is no longer exist"); 
        }

       /// <summary>
       /// Gets the categories name from the DB
       /// </summary>
       /// <returns></returns>
       public List<string> GetCategoriesNamesList()
       {
           List<string> categoriesName = new List<string>(); // Holds the names of the categories

           var query = db.Categories.Select(c => new { c.CategoryName });
           foreach (var item in query)
           {
               categoriesName.Add(item.CategoryName);
           }
           return categoriesName;
       }
       public void GetCategoriesDetails(DataGridView dgv)
       {
           dgv.Columns.Clear();
           dgv.Rows.Clear();
           dgv.Refresh();

           dgv.ColumnCount = 2;
           dgv.Columns[0].Name = "Category ID";
           dgv.Columns["Category ID"].ReadOnly = true;
           dgv.Columns[1].Name = "Category Name";

           var query = db.Categories.Select(c => new { c.CategoryID, c.CategoryName });

           foreach (var item in query)
           {
               ArrayList dgvRows = new ArrayList();
               dgvRows.Add(item.CategoryID);
               dgvRows.Add(item.CategoryName);

               dgv.Rows.Add(dgvRows.ToArray());
           }
       }
       private string GetCategoryNameByID(int categoryID)
       {
           var query = db.Categories.Where(c => c.CategoryID == categoryID).FirstOrDefault();
           return query.CategoryName;
       }
                      
    }
}
