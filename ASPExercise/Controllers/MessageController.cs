using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace ASPExercise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {

        public MessageController()
        {
             
        }

        [HttpGet]
        public async Task<IActionResult> GetMessages()
        {

            return Ok(new List<string>{
            "a",
            "aaa",
            "bang",
            "bing",
            "eee",
            "oo",
            "ooo",
            "tang",
            "ting",
            "walla",
            "welcome"
        });

        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(string json)
        {
            return Ok(JsonSerializer.Deserialize<List<string>>(json));
        }

    }
}
