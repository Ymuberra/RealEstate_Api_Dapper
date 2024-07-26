using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Api_Dapper.Dtos.CategoryDtos;
using RealEstate_Api_Dapper.Repositories.CategoryRepository;
using System.Reflection.Metadata.Ecma335;

namespace RealEstate_Api_Dapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var values = await _categoryRepository.GetAllCategoryAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDtio createCategoryDtio)
        {
            _categoryRepository.CreateCategory(createCategoryDtio);
            return Ok("kategori başarılı bir şekilde eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult>DeleteCategory(int id)
        {
            _categoryRepository.DeleteCategory(id);
            return Ok("kategori başarılı bir şekilde silindi");
        }
        [HttpPut]
        public async Task<IActionResult>UpDateCategory(UpDateCategoryDtio updateCategoryDtio)
        {
            _categoryRepository.UpDateCategory(updateCategoryDtio);
            return Ok("kategori başarı ile güncellendi");
        }
        [HttpGet("{id}")]
        public async Task <IActionResult>GetCategory(int id)
        {
            var value = _categoryRepository.GetCategory(id);
            return Ok(value);
        }

    }

}

