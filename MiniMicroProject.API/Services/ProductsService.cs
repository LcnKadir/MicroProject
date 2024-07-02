using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MiniMicroProject.API.Concrete;
using MiniMicroProject.API.DTOs;
using MiniMicroProject.API.Models;
using MiniMicroProject.API.Services.Interface;

namespace MiniMicroProject.API.Services
{
    public class ProductsService : IProductsService
    {
        private readonly Context _context;
        private readonly IMapper _mapper;

        public ProductsService(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ProductsDto> CreateAsync(ProductsDto productsDto)
        {
            var product = _mapper.Map<Products>(productsDto);
            _context.Products.Add(product);

            await _context.SaveChangesAsync();
            return _mapper.Map<ProductsDto>(product);
        }

        public async Task DeleteAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product != null) // If product is not null, delete product.
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }

        }

        public async Task<List<ProductsDto>> GetAllAsync()
        {
            var products = await _context.Products.ToListAsync();
            return _mapper.Map<List<ProductsDto>>(products);
        }

        public async Task<ProductsDto> GetByIdAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            return _mapper.Map<ProductsDto>(product);
        }

        public async Task<ProductsDto> UpdateAsync(ProductsDto productsDto)
        {
            var product = await _context.Products.FindAsync(productsDto.Id);

            if (product == null) // If the product is not found, null is returned.
            {
                return null;
            }

            _mapper.Map(productsDto, product);

            await _context.SaveChangesAsync();
            return _mapper.Map<ProductsDto>(product);
        }
    }
}
