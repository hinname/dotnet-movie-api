using dotnet_movie_api.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_movie_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllMovies()
        {
            var movies = new List<Movie>
            {
                new Movie()
                {
                    Id = 1,
                    Title = "Inception",
                    Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O., " +
                                  "but his tragic past may doom the project and his team to disaster.",
                    Director = "Christopher Nolan",
                    Duration = 148,
                    Genre = "Action/Sci-Fi",
                    ReleaseDate = new DateTime(2010, 08, 06),
                },
            };

            return Ok(movies);
        }
    }
}
