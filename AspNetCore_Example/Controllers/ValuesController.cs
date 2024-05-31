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
            dbservice.Conntection();
            dbservice.Disconntection();
            return Ok();
        }
        [HttpGet("[action]")]
        public IActionResult Y()
        {
            DatabaseService dbservice = DatabaseService.GetDbInstance;
            dbservice.Conntection();
            dbservice.Disconntection();
            return Ok();
        }
    }
}
