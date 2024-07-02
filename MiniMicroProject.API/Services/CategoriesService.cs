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

        public async Task<IEnumerable<CategoriesDto>> GetAllAsync()
        {
            var categories = await _context.Categories.ToListAsync();
            return _mapper.Map<List<CategoriesDto>>(categories);
        }
    }
}
