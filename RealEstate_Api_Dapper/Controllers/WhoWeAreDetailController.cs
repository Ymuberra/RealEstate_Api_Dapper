using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Api_Dapper.Dtio.WhoWeAreDetailDtio;
using RealEstate_Api_Dapper.Dtio.CategoryDtio;
using RealEstate_Api_Dapper.Repositories.CategoryRepository;
using RealEstate_Api_Dapper.Repositories.WhoWeAreRepository;

namespace RealEstate_Api_Dapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhoWeAreDetailController : ControllerBase
    {
        private readonly IWhoWeAreDetailRepository? _whoWeAreDetailRepository;

        public WhoWeAreDetailController(IWhoWeAreDetailRepository? whoWeAreDetailRepository)
        {
            _whoWeAreDetailRepository = whoWeAreDetailRepository;
        }

        [HttpGet]
        public async Task<IActionResult> WhoWeAreDetailList()
        {
            var values = await _whoWeAreDetailRepository.GetAllWhoWeAreDetailAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateWhoWeAreDetail(CreateWhoWeAreDetailDtio createWhoWeAreDetailDtio)
        {
            _whoWeAreDetailRepository.CreateWhoWeAreDteail(createWhoWeAreDetailDtio);
            return Ok("Hakkımızda kısmı başarılı bir şekilde eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteWhoWeAreDetail(int id)
        {
            _whoWeAreDetailRepository.DeleteWhoWeAreDetail(id);
            return Ok("hakkımızda kısmı  başarılı bir şekilde silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpDateWhoWeAreDEtail(UpdateWhoWeAreDetailDtio updateWhoWeAreDetailDtio)
        {
            _whoWeAreDetailRepository.UpDateWhoWeAreDetail(updateWhoWeAreDetailDtio);
            return Ok("hakkımızda kısmı başarı ile güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWhoWeAreDetail(int id)
        {
            var value = await _whoWeAreDetailRepository.GetWhoWeAreDetail(id);
            return Ok(value);
        }

    }
}

