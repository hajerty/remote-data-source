using Microsoft.AspNetCore.Mvc;

namespace RemoteDataSource.Controllers;

[ApiController]
[Route("[controller]")]
 public class GetTreeDataController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var data = System.IO.File.ReadAllText("data.json");
            return Ok(data);
        }
    }
