using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace ASPExercise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : ControllerBase
    {

        public NameController()
        {
                
        }

        [HttpGet]
        public async Task<IActionResult> GetNames() 
        {

           List<Person> people = new List<Person>()
            {
            new Person(){Name ="Dad" },
            new Person(){Name ="David Blaine" },
            new Person(){Name ="Joseph"},
            new Person(){Name ="Mike Oxsmaul" },
            new Person(){Name ="Moe Lester" },
            new Person(){Name ="Mom" },
            new Person(){Name ="Scatman" },
            new Person(){Name ="Sean" },
            new Person(){Name ="Walter White" },
            };

            // Serialize

            return Ok(JsonSerializer.Serialize(people));
        }


        [HttpPost]
        public async Task<IActionResult> CreateNames(string json)
        {
            return Ok(JsonSerializer.Deserialize<List<Person>>(json));
        }
    }
}
