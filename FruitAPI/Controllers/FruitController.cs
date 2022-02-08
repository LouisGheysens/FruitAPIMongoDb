using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FruitData;

namespace FruitAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitController : ControllerBase
    {
        private readonly IFruitServices _fruitServices;

        public FruitController(IFruitServices fruitServices)
        {
            this._fruitServices = fruitServices;
        }

        [HttpGet]
        public IActionResult GetFruits()
        {
            return Ok(_fruitServices.GetFruits());
        }
    }
}
