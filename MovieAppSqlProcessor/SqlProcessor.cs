using Microsoft.Data.SqlClient;
using MovieApp.Database.DataModels;
using ParentProcessor;
using System;
using System.Collections.Generic;

namespace MovieAppSqlProcessor
{
    public class SqlProcessor: IDataProcessor
    {
        private readonly string connectionString = "Data Source=localhost;Initial Catalog=MovieDB; USER ID=sa; password=P@55w0rd;TrustServerCertificate=True";

        public List<Movie> loadMovies()
        {
            List<Movie> allMovies = new List<Movie>();


            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Movies";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int movieId = Convert.ToInt32(reader["MovieId"]);
                            string MovieName = reader["MovieName"].ToString();
                            string ratings = reader["ratings"].ToString();
                            string Description = reader["Description"].ToString();
                            string dateCreated = reader["DateCreated"].ToString();
                            Movie movie = new Movie { MovieId = movieId, MovieName = MovieName, ratings = int.Parse(ratings), Description = Description, DateCreated= Convert.ToDateTime(dateCreated) };
                            allMovies.Add(movie);
                        }
                    }
                }
            }

            return allMovies;
        }

        public string addNewMovie(Movie newMovieToBind)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Movies ( MovieName, ratings, Description, DateCreated) VALUES (@MovieName,@ratings,@Description,@DateCreated )";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MovieName", newMovieToBind.MovieName);
                        command.Parameters.AddWithValue("@ratings", newMovieToBind.ratings);
                        command.Parameters.AddWithValue("@Description", newMovieToBind.Description);
                        command.Parameters.AddWithValue("@DateCreated", newMovieToBind.DateCreated);

                        command.ExecuteNonQuery();
                    }
                }
                return "Successful Addition";
            }
            catch (Exception ex)
            {
                string errorMessage = ex.ToString();
                return "Error Adding: " + errorMessage;
            }
        }

        public string updateMovie(List<Movie> updatedMovies)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    foreach (var updatedMovie in updatedMovies)
                    {
                        int movieId = updatedMovie.MovieId;
                        string query = "UPDATE Movies SET MovieName = @MovieName, ratings = @ratings, Description = @Description, DateCreated = @DateCreated WHERE MovieId = @MovieId";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@MovieName", updatedMovie.MovieName);
                            command.Parameters.AddWithValue("@ratings", updatedMovie.ratings);
                            command.Parameters.AddWithValue("@Description", updatedMovie.Description);
                            command.Parameters.AddWithValue("@DateCreated", updatedMovie.DateCreated);

                            command.ExecuteNonQuery();
                        }
                    }
                }
                return "update successful";
            }
            catch (Exception ex)
            {
                string errorMessage = ex.ToString();
                return "Error Adding: " + errorMessage;
            }
        }

        public string deleteMovie(int movie_id)
        {
            /* try
             {
                 using (SqlConnection connection = new SqlConnection(connectionString))
                 {
                     connection.Open();

                     string query = "DELETE FROM Movies WHERE MovieId = @MovieId";
                     using (SqlCommand command = new SqlCommand(query, connection))
                     {
                         command.Parameters.AddWithValue("@MovieId", movie_id);
                         command.ExecuteNonQuery();
                     }
                 }

                 return "Delete successful";
             }
             catch (Exception ex)
             {
                 string errorMessage = ex.ToString();
                 return "Error Deleting: " + errorMessage;
             }*/
            return "sql processor";
        }
    }
}
