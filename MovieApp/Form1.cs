using MovieApp.Database;
using MovieApp.Database.DataModels;
using MovieApp.DataProcessing;
using MovieAppSqlProcessor;


namespace MovieApp
{
    public partial class Form1 : Form
    {
        private List<Movie> updatedMovies = new List<Movie>();

        public class DataProcessorFactory
        {
            public enum DataProcessingType
            {
                EntityProcessor,
                SqlDataProcessor
            }

            public static IDataProcessor CreateDataProcessor(DataProcessingType type)
            {
                switch (type)
                {
                    case DataProcessingType.EntityProcessor:
                        return new MovieAppDataProcessing();
                    case DataProcessingType.SqlDataProcessor:
                        return new SqlDataProcessor();
                    default:
                        throw new ArgumentException("Invalid DataProcessingType.");
                }
            }
        }


        public DataProcessorFactory.DataProcessingType userSelectedType;
        public IDataProcessor dataprocessor = new SqlDataProcessor();
        public DataProcessorFactory parentDataProcessorFactory = new DataProcessorFactory();

        private void InitializeDataProcessingTypeDropdown()
        {
            dataProcessingTypeDropdown.DataSource = Enum.GetValues(typeof(DataProcessorFactory.DataProcessingType));

        }

        public Movie newMovieToBind
        {
            get
            {
                return movieBindingSource.DataSource as Movie;
            }
            set
            {
                this.movieBindingSource.DataSource = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
            InitializeDataProcessingTypeDropdown();
            displayMovies();

            newMovieToBind = new Movie
            {
                DateCreated = DateTime.Now,
            };

            grid_allMovies.CellValueChanged += Grid_allMovies_CellValueChanged;

        }

        private void Grid_allMovies_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                DataGridViewRow row = grid_allMovies.Rows[e.RowIndex];

                int idColumnIndex = 0;
                int titleColumnIndex = 1;
                int descriptionColumnIndex = 3;
                int ratingsColumnIndex = 4;
                int releaseDateColumnIndex = 2;

                int movieId = int.Parse(row.Cells[idColumnIndex].Value.ToString());

                var recentMovie = context.Movies.Find(movieId);

                if (recentMovie != null)
                {
                    recentMovie.ratings = int.Parse(row.Cells[ratingsColumnIndex].Value.ToString());
                    recentMovie.Description = row.Cells[descriptionColumnIndex].Value.ToString();
                    recentMovie.DateCreated = Convert.ToDateTime(row.Cells[releaseDateColumnIndex].Value);
                    recentMovie.MovieName = row.Cells[titleColumnIndex].Value.ToString();
                }

                updatedMovies.Add(recentMovie);

            }
        }

        private void getMovies_Click(object sender, EventArgs e)
        {
            displayMovies();
            if (grid_allMovies.Visible == false)
            {
                toggle_add_movie();

            }
        }


        private void getUsers_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void addMovies_Click(object sender, EventArgs e)
        {
            var group = group_newmovie;

            if (group.Visible != true)
            {
                toggle_add_movie();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void submit_bbtn_Click(object sender, EventArgs e)
        {

            if (newMovieToBind != null)
            {

                var message = dataprocessor.addNewMovie(newMovieToBind);
                MessageBox.Show(message);
                displayMovies();
                toggle_add_movie();

            }

        }

        private void displayMovies()
        {
            grid_allMovies.DataSource = dataprocessor.loadMovies();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            toggle_add_movie();
        }

        private void toggle_add_movie()
        {

            var group = group_newmovie;
            var allMovies = grid_allMovies;

            if (group.Visible == false)
            {
                group.Dock = DockStyle.Fill;
                group.Visible = true;

                allMovies.Dock = DockStyle.None;
                allMovies.Visible = false;

                delete.Visible = false;
                update.Visible = false;


            }
            else
            {
                group.Visible = false;
                group.Dock = DockStyle.None;

                allMovies.Dock = DockStyle.Fill;
                allMovies.Visible = true;

                delete.Visible = true;
                update.Visible = true;

            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            //var message = dataprocessor.updateMovie(updatedMovies);
            //MessageBox.Show(message.ToString());

            updatedMovies.Clear();
            displayMovies();
        }

        private void delete_Click(object sender, EventArgs e)
        {

            if (grid_allMovies.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = grid_allMovies.SelectedRows[0];

                int idColumnIndex = 0;
                int movieId = int.Parse(selectedRow.Cells[idColumnIndex].Value.ToString());

                var message = dataprocessor.deleteMovie(movieId);
                MessageBox.Show(message);
                displayMovies();
            }
            else
            {
                MessageBox.Show("Please select a row.");
            }

        }

        private void input_movieName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataProcessingTypeDropdown_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (Enum.TryParse(dataProcessingTypeDropdown.SelectedItem.ToString(), out DataProcessorFactory.DataProcessingType selectedType))
            {
                dataprocessor = DataProcessorFactory.CreateDataProcessor(selectedType);

            }
        }
    }
}