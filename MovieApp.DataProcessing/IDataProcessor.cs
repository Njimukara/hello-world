using MovieApp.Database.DataModels;

namespace MovieApp.DataProcessing
{
    public interface IDataProcessor
    {
        List<Movie> loadMovies();

        string addNewMovie(Movie newMovieToBind);

        string updateMovie(List<Movie> updatedMovies);

        string deleteMovie(int movie_id);
    }

}
