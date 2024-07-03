using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    }
}
