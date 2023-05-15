
using WebApiMini.Models;

namespace WebApiMini.Repositories
{
    public class MovieRepository
    {
        public static List<Movie> Movies = new()
        {
            new() { Id = 1, Title = "title1", Description = "desc1", Rating = 6.1 },
            new() { Id =2 , Title ="title2",Description ="desc2",Rating =6.1}
        };

    }
}
