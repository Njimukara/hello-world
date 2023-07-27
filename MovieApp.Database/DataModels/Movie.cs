
namespace MovieApp.Database.DataModels
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public DateTime DateCreated { get; set; }
        public string Description { get; set; }
        public double ratings { get; set; }

    }
}
