using MiniMicroProject.API.Models;

namespace MiniMicroProject.API.DTOs
{
    public class ProductsDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Order { get; set; } 
        public string Picture { get; set; }
        public string CategoriesId { get; set; }
        public Categories Categories { get; set; }
    }
}
