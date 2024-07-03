using Azure;
using Microsoft.AspNetCore.Http.HttpResults;
using MiniMicroProject.API.DTOs;

namespace MiniMicroProject.API.Services.Interface
{
    public interface IProductsService
    {
        //Service was used to convert the data from the database directly into Dto.//
        Task<List<ProductsDto>> GetAllAsync();
        Task<ProductsDto> GetByIdAsync(int id);
        Task<ProductsDto> CreateAsync(ProductsDto productsDto);
        Task<ProductsDto> UpdateAsync(ProductsDto productsDto);
        Task DeleteAsync(int id);
    }
}
