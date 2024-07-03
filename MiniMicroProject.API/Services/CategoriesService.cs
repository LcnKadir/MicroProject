using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MiniMicroProject.API.Concrete;
using MiniMicroProject.API.DTOs;
using MiniMicroProject.API.Models;
using MiniMicroProject.API.Services.Interface;

namespace MiniMicroProject.API.Services
{
    public class CategoriesService : ICategoriesService
    {
        private readonly Context _context;
        private readonly IMapper _mapper;

        public CategoriesService(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CategoriesDto> CreateAsync(CategoriesDto categoriesDto)
        {
            var categories = _mapper.Map<Categories>(categoriesDto);
            _context.Categories.Add(categories);

            await _context.SaveChangesAsync();
            return _mapper.Map<CategoriesDto>(categories);
        }

        public async Task DeleteAsync(int id)
        {
            var categories = await _context.Categories.FindAsync(id);

            if (categories != null) // If categories is not null, delete.
            {
                _context.Categories.Remove(categories);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<CategoriesDto>> GetAllAsync()
        {
            var categories = await _context.Categories.ToListAsync();
            return _mapper.Map<List<CategoriesDto>>(categories);
        }

        public async Task<CategoriesDto> GetByIdAsync(int id)
        {
            var categories = await _context.Categories.FindAsync(id);
            return _mapper.Map<CategoriesDto>(categories);
        }
    }
}
