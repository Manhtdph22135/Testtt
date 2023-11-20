using Testtt.Models;
using Testtt.Responsitories;

namespace Testtt.Services
{
    public class MovieServices : IMovieServices
    {
        private readonly IMovieResponsitory _movieResponsitory;

        public MovieServices(IMovieResponsitory movieResponsitory)
        {
            _movieResponsitory = movieResponsitory;
        }

        public bool addMovie(Movies movies)
        {
            return _movieResponsitory.addMovie(movies);
        }

        public IEnumerable<Movies> GetAllMovies()
        {
            return _movieResponsitory.GetAllMovies();
        }
    }
}
