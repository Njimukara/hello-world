using Microsoft.EntityFrameworkCore;
using MovieApp.Database;
using MovieApp.Database.DataModels;
using ParentProcessor;

namespace MovieApp.DataProcessing
{

    public class MovieAppDataProcessing : IDataProcessor
    {
        public List<Movie> loadMovies()

        {

            try
            {
                using (var Context = new DatabaseContext())
                {
                    var allMovies = Context.Movies.ToList();

                    return allMovies;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public string addNewMovie(Movie newMovieToBind)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    context.Movies.Add(newMovieToBind);
                    context.SaveChanges();
                
                }
                return "Successfull Adition";

            }
            catch (Exception ex)
            {

                string errorMessage = ex.ToString();
                return "Error Adding: " + errorMessage;
            }
        }

        public string updateMovie (List<Movie> updatedMovies)
        {

            try
            {
                using (var context = new DatabaseContext())
                {
                    context.Movies.AddRange(updatedMovies);
                    foreach (var updatedMovie in updatedMovies)
                    {
                        context.Entry(updatedMovie).State = EntityState.Modified;
                    }

                    context.SaveChanges();
                    updatedMovies.Clear();
                }
                return "Update Successful";

            }
            catch (Exception ex)
            {

                string errorMessage = ex.ToString();
                return "Error Adding: " + errorMessage;
            }
        }

        public string deleteMovie (int movie_id)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    var movieToDelete = context.Movies.Find(movie_id);
                    if (movieToDelete != null)
                    {
                        context.Movies.Remove(movieToDelete);
                        context.SaveChanges();
                        return "Delete successful";
                    } else
                    {
                        return "Movie Not found";
                    }

                }
            }
            catch (Exception ex)
            {
                string errorMessage = ex.ToString();
                return "Error Deleting: " + errorMessage;
            }
         
        }
    }


}