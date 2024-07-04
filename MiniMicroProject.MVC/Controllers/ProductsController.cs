using Microsoft.AspNetCore.Mvc;
using MiniMicroProject.MVC.Services;

namespace MiniMicroProject.MVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductsApiService _productsApiService;
        private readonly CategoriesApiService _categoriesApiService;

        public ProductsController(ProductsApiService productsApiService, CategoriesApiService categoriesApiService)
        {
            _productsApiService = productsApiService;
            _categoriesApiService = categoriesApiService;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await _categoriesApiService.GetAll();
            return Json(categories);
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts(int categoryId)
        {
            var products = await _productsApiService.GetProductsByCategory(categoryId);
            return Json(products);
        }
    }
}
