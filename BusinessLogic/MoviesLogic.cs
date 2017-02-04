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
   public class MoviesLogic : BaseLogic
              
    {
       

       /// <summary>
       /// Creating new movie in the DB
       /// </summary>
       /// <param name="movieName"></param>
       /// <param name="_hour"></param>
       /// <param name="_min"></param>
       /// <param name="_sec"></param>
       /// <param name="movieLink"></param>
       /// <param name="categoryName"></param>
       public void AddNewMovie(string movieName, string _hour, string _min, string _sec, string movieLink, string categoryName)
       {
            // Finding the CategoryID matching the selected categoryName
           var query = db.Categories.Where(c => c.CategoryName == categoryName).FirstOrDefault();

           Movy mov = new Movy()
           {
               MovieName =movieName,
               CategoryName = categoryName,
               CategoryID = query.CategoryID,
               Duration = ConvertingToTimeSpan(_hour,_min,_sec),
               MovieLink = movieLink
           };

           db.Movies.Add(mov);
           db.SaveChanges();
           MessageBox.Show("Done");
       }

       /// <summary>
       /// Updateing movie's details in the DB
       /// </summary>
       /// <param name="currentMovieName"></param>
       /// <param name="newMovieName"></param>
       /// <param name="_hour"></param>
       /// <param name="_min"></param>
       /// <param name="_sec"></param>
       /// <param name="movieLink"></param>
       /// <param name="categoryName"></param>
       public void UpdateMovie(string currentMovieName,string newMovieName ,string _hour, string _min, 
                               string _sec, string movieLink, string categoryName)
       {
           var query = db.Movies.Where(m => m.MovieName == currentMovieName).FirstOrDefault();

           if (query != null)
           {
               //  Finding the CategoryID matching the selected categoryName
               var catID = db.Categories.Where(c => c.CategoryName == categoryName).FirstOrDefault();

               //Checking if the User changed the movie's name
               if (newMovieName == "")
                   query.MovieName = currentMovieName; // If he didnt change  
               else
                   query.MovieName = newMovieName; // If he did change

               query.Duration = ConvertingToTimeSpan(_hour,_min,_sec);
               query.MovieLink = movieLink;
               query.CategoryName = categoryName;
               query.CategoryID = catID.CategoryID;
               db.SaveChanges();

               MessageBox.Show("Done!");
           }
           else
               // If someone delete/updated the Movie in the database before the user pressed the "update" button.
               MessageBox.Show("There is no movie named " + currentMovieName); 
       }

       /// <summary>
       /// Deleting movie from the DB
       /// </summary>
       /// <param name="movieToDelete"></param>
       public void DeleteMovie(string movieToDelete)
       {
           var query = db.Movies.Where(m => m.MovieName == movieToDelete).FirstOrDefault();


           if (query != null)
           {
               string name = query.MovieName.ToString(); // Saving the movie's name to display it in the Massege Box 
               db.Movies.Remove(query);
               db.SaveChanges();
               MessageBox.Show("The movie: " + name + " has been deleted!");
               
           }
           else
               // If someone delete the movie from the database before the user pressed the "delete" button.
               MessageBox.Show("The movie: " + movieToDelete + " is no longer exist"); 
       }


       /// <summary>
       /// Converting Hours, minutes & seconds from string to TimeSpan object
       /// </summary>
       /// <param name="_hour"></param>
       /// <param name="_min"></param>
       /// <param name="_sec"></param>
       /// <returns>TimeSpan object</returns>
       private TimeSpan ConvertingToTimeSpan(string _hour, string _min, string _sec)
       {
           int hours = int.Parse(_hour);
           int min = int.Parse(_min);
           int sec = int.Parse(_min);
           TimeSpan ts = new TimeSpan(hours, min, sec);

           return ts;
       }

       public List<string> GetMoviesName()
       {
           List<string> moviesName = new List<string>(); // Holds the names of the movies
           var query = db.Movies.Select(m => new { m.MovieName });
           foreach (var item in query)
           {
               moviesName.Add(item.MovieName);
           }
           return moviesName;
       }

       public void GetAllMoviesDetails(DataGridView dgv)
       {
           dgv.Columns.Clear();
           dgv.Rows.Clear();
           dgv.Refresh();

           dgv.ColumnCount = 6;
           dgv.Columns[0].Name = "Movie ID";
           dgv.Columns[1].Name = "Movie Name";
           dgv.Columns[2].Name = "Category Name";
           dgv.Columns[3].Name = "Category ID";
           dgv.Columns[4].Name = "Duration";
           dgv.Columns[5].Name = "Movie link";

           var query = db.Movies.Select(m => new
           {
               m.MovieID,
               m.MovieName,
               m.CategoryName,
               m.CategoryID,
               m.Duration,
               m.MovieLink
           });

           DataGridViewButtonColumn dgvbc = new DataGridViewButtonColumn();
           dgv.Columns.Add(dgvbc);

           dgvbc.HeaderText = "Click to watch";

           foreach (var item in query)
           {
               dgvbc.Name = "Click to watch";

               ArrayList dgvRows = new ArrayList();
               dgvRows.Add(item.MovieID);
               dgvRows.Add(item.MovieName);
               dgvRows.Add(item.CategoryName);
               dgvRows.Add(item.CategoryID);
               dgvRows.Add(item.Duration);
               dgvRows.Add(item.MovieLink);
               dgvRows.Add(dgvbc.Name);

               dgv.Rows.Add(dgvRows.ToArray());
           }
       }

       public dynamic ShowMovieDetails(string movieName)
       {
         var query = db.Movies.Where(m => m.MovieName == movieName).FirstOrDefault();
         return query;

       }
    }
}
