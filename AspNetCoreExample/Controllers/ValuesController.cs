using AspNetCore_Example.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult X()
        {
            DatabaseService dbservice = DatabaseService.GetDbInstance;
            Console.WriteLine("X Activated");

            dbservice.Conntection();
            dbservice.Disconntection();
            return Ok(dbservice.Count);
        }
        [HttpGet("[action]")]
        public IActionResult Y()
        {
            DatabaseService dbservice = DatabaseService.GetDbInstance;
            Console.WriteLine("Y Activated");
            dbservice.Conntection();
            dbservice.Disconntection();
            return Ok(dbservice.Count);
        }
    }
}
