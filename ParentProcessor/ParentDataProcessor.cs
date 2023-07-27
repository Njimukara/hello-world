using MovieApp.Database.DataModels;

namespace ParentProcessor
{

    public abstract class ParentDataProcessor
    {
        public abstract List<Movie> loadMovies();
        public abstract string addNewMovie(Movie newMovieToBind);
        public abstract string updateMovie(List<Movie> updatedMovies);
        public abstract string deleteMovie(int movie_id);
    }


}