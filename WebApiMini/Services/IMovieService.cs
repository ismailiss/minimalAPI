using WebApiMini.Models;

namespace WebApiMini.Services
{
    public interface IMovieService
    {
        public Movie Create(Movie movie);
        public Movie Get(int id);
        public Movie Update(Movie movie);    
        public void Delete(int id);
        public  List<Movie> List();
    }
}
