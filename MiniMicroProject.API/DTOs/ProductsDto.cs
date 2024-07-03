using MiniMicroProject.API.Models;
using System.Text.Json.Serialization;

namespace MiniMicroProject.API.DTOs
{
    public class ProductsDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Order { get; set; }
        public string? Picture { get; set; }
        public int CategoriesId { get; set; }

    }
}
