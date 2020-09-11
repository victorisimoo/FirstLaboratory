using FirstLaboratory.Controllers;
using FirstLaboratory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace FirstLaboratory.Manager
{
    public class MoviesManager {
        public static List<Movie> ProcessMoviesFile(string content) {
            return JsonSerializer.Deserialize<List<Movie>>(content, new JsonSerializerOptions {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            });
        }
    }
}
