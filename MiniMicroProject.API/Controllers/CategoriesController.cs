using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniMicroProject.API.DTOs;
using MiniMicroProject.API.Services;
using MiniMicroProject.API.Services.Interface;

namespace MiniMicroProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesService _categoriesService;

        public CategoriesController(ICategoriesService categoriesService)
        {
            _categoriesService = categoriesService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var value = await _categoriesService.GetAllAsync();

            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoriesDto categoriesDto)
        {
            var value = await _categoriesService.CreateAsync(categoriesDto);

            return Ok(value);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _categoriesService.GetByIdAsync(id);

            return Ok(value);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _categoriesService.DeleteAsync(id);
            return Ok();
        }
    }
}
