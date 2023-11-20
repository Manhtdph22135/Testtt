using Testtt.Models;

namespace Testtt.Responsitories
{
    public interface IMovieResponsitory
    {
        IEnumerable<Movies> GetAllMovies();
        bool addMovie(Movies movies);
    }
}
