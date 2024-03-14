using Microsoft.AspNetCore.Mvc;
using RealEstate.API.Repositories.PopularLocationRepositories;

namespace RealEstate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopularLocationsController : ControllerBase
    {
        private readonly IPopularLocationRepository _popularLocationRepository;

        public PopularLocationsController(IPopularLocationRepository popularLocationRepository)
        {
            _popularLocationRepository = popularLocationRepository;
        }

        [HttpGet]
        public async Task<IActionResult> PopularLocationList()
        {
            var values = await _popularLocationRepository.GetAllPopularLocationsAsync();
            return Ok(values);
        }
    }
}
