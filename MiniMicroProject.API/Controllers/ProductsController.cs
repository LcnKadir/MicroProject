using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniMicroProject.API.DTOs;
using MiniMicroProject.API.Services.Interface;

namespace MiniMicroProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var value = await _productsService.GetAllAsync();

            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductsDto  productsDto)
        {
            var value = await _productsService.CreateAsync(productsDto);

            return Ok(value);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _productsService.GetByIdAsync(id);

            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> Update(ProductsDto productsDto)
        {
            var value = await _productsService.UpdateAsync(productsDto);

            return Ok(value);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _productsService.DeleteAsync(id);
            return Ok();
        }
    }
}
