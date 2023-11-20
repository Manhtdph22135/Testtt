using Testtt.Models;

namespace Testtt.Services
{
    public interface IMovieServices
    {
        IEnumerable<Movies> GetAllMovies();
        bool addMovie(Movies movies);
    }
}
