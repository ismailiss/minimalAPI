using WebApiMini.Models;
using WebApiMini.Repositories;

namespace WebApiMini.Services
{
    public class MovieService : IMovieService
    {
        public Movie Create(Movie movie)
        {
            movie.Id = MovieRepository.Movies.Count + 1;
            return movie;
        }
        public Movie Get(int id)
        {
            var movie = MovieRepository.Movies.FirstOrDefault(x => x.Id == id);
            return movie ;

        }
        public Movie Update(Movie movie)
        {
            var old = MovieRepository.Movies.FirstOrDefault(x => x.Id == movie.Id);
            if (old == null) return null;
            old.Id = movie.Id;
            old.Title = movie.Title;
            old.Description = movie.Description;   
            old.Rating = movie.Rating;   
            return movie;
        }
        public void Delete(int id) {
                var movie = MovieRepository.Movies.FirstOrDefault(x => x.Id == id);
                MovieRepository.Movies.Remove(movie);

                }
        public List<Movie> List()
        {
            return MovieRepository.Movies.ToList();
        }
    }
}
