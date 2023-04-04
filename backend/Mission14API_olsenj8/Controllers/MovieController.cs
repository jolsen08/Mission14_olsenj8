using Microsoft.AspNetCore.Mvc;
using Mission14API_olsenj8.Data;
using System.Security.Cryptography.X509Certificates;

namespace Mission14API_olsenj8.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : Controller
    { 
        private MovieDbContext context;
        public MovieController(MovieDbContext temp)
        {
            context = temp;
        }
        
        //For our Movies Object, we are only including movies that have been edited
        //We are also ordering the movies alphabetically by Title.
        //For the movies that match that criteria, we are sending it to an array which can 
        //be used by our frontend react app to display on the table
        public IEnumerable<Movies> Get()
        {
            return context.Movies
                .Where(movie => movie.Edited == "Yes")
                .OrderBy(movie => movie.Title)
                .ToArray();
        }
    }
}
