﻿using System.Text.Json.Serialization;

namespace MiniMicroProject.API.Models
{
    public class Products
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Order { get; set; } // a choice of how many months the product can be paid in installments.
        public string Picture { get; set; }
        public string CategoriesId { get; set; }
        public Categories Categories { get; set; }
    }
}