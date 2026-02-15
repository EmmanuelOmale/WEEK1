using CarProject.Application.Implementation;
using CarProject.Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CarWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ILogger<CarController> _logger;
        private readonly ICarService _carService;
        public CarController(ILogger<CarController> logger, ICarService carService)
        {
            _logger = logger;
            _carService = carService;
        }


        [HttpPost("create-a-brand-new-car")]
        public IActionResult CreateBrandNewCar(CreateCarDto createCarDto)
        {
            var newCarResponse = _carService.CreateCar(createCarDto);

            return Ok(newCarResponse);
        }

        [HttpGet("get-all-cars")]
        public IActionResult GetAllCars()
        {
            var cars = _carService.GetAllCars();
            return Ok(cars);
        }
    }
}