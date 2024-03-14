using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate.API.Repositories.TestimonialRepositories;

namespace RealEstate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly ITestimonailRepository _testimonailRepository;

        public TestimonialsController(ITestimonailRepository testimonailRepository)
        {
            _testimonailRepository = testimonailRepository;
        }

        [HttpGet]
        public async Task<IActionResult> TestimonialList()
        {
            var values = await _testimonailRepository.GetAllTestimonialAsync();
            return Ok(values);
        }
    }
}
