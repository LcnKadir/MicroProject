using MiniMicroProject.API.DTOs;
using MiniMicroProject.API.Models;

namespace MiniMicroProject.API.Services.Interface
{
    public interface ICategoriesService
    {
        //Service was used to convert the data from the database directly into Dto.// 
        Task<IEnumerable<CategoriesDto>> GetAllAsync();
        Task<CategoriesDto> CreateAsync(CategoriesDto categoriesDto);
        Task<CategoriesDto> GetByIdAsync(int id);
        Task DeleteAsync(int id);
    }
}

