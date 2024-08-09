using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Api_Dapper.Repositories.PopularLocationRepositories;

namespace RealEstate_Api_Dapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopularLocationsController : ControllerBase
    {
        private readonly IPopularLocationRepository _locatipnRepository;

        public PopularLocationsController(IPopularLocationRepository locatipnRepository)
        {
            _locatipnRepository = locatipnRepository;
        }
        [HttpGet]
        public async Task<IActionResult> PopularLocationList()
        {
            var value = await _locatipnRepository.GetAllPopularLocationAsync();
            return Ok(value);
        }
    }
}
