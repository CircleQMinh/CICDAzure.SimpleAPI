using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        [HttpGet("AddTwoNumber")]
        public ActionResult<int> AddTwoNumber(int numberOne,int numberTwo)
        {
            return numberOne + numberTwo;
        }

        [HttpGet("SubtractTwoNumber")]
        public ActionResult<int> SubtractTwoNumber(int numberOne, int numberTwo)
        {
            //trigger build
            return numberOne - numberTwo;
        }
    }
}
