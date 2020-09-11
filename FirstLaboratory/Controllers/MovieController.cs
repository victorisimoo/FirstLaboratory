using FirstLaboratory.Models;
using CustomGenerics.Structure;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using FirstLaboratory.Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FirstLaboratory.Data;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstLaboratory.Controllers
{
    [ApiController]
    public class MovieController : ControllerBase
    {

        //GET - NOMBRE DE RECORRIDO EN LA RUTA
        // GET api/<Movies>/inorden
        [HttpGet("{route}")]
        [Route("api/[controller]")]
        public ActionResult GetByRoute([FromRoute] string route)
        {
            //Agregar el .recorrer
            var result = new Movie
            { Director = "Yo",
                Title = "Mi vida xD",
                ReleaseDate = "10kjfd",
                ImdbRating = 0,
                RottenTomatoesRating = 0,
                Genre = "tragedia"
            };
            if (result == null) return NotFound();
            return Ok(result);
        }

        // POST api/<Movies>/
        [HttpPost]
        [Route("api/[controller]")]
        public ActionResult Post(int orden) {
            Storage.Instance.rangeTree = new RangeTree<Movie>(orden);
            return Ok();
        }


        //POST - RECIBE UN JSON 
        // POST api/<Movies>/populate
        [HttpPost]
        [Route("api/movie/populate")]
        public async Task<string> Post(IFormFile file) {
            //try
            //{
                using var contentInMemory = new MemoryStream();
                await file.CopyToAsync(contentInMemory);
                var content = Encoding.ASCII.GetString(contentInMemory.ToArray());
                var objects = MoviesManager.ProcessMoviesFile(content);
                foreach (var item in objects) {
                    Storage.Instance.rangeTree.InsertElement(item, Movie.CompareByTitle);
                }
                return "Ok";
            //}
            //catch (Exception) {
            //    throw new Exception("Internal Server Error");
            //}
        }
    }
}
