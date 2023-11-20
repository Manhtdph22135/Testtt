
using Testtt.Context;
using Testtt.Models;

namespace Testtt.Responsitories
{
    public class MovieResponsitory : IMovieResponsitory
    {
        private readonly ApplicationDbContext _context;

        public MovieResponsitory(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }

        public bool addMovie(Movies movies)
        {
            try
            {
                _context.Movies.Add(movies);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public IEnumerable<Movies> GetAllMovies()
        {
            return _context.Movies.ToList();
        }
    }
}
