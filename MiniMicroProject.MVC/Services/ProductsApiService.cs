using MiniMicroProject.API.DTOs;

namespace MiniMicroProject.MVC.Services
{
    public class ProductsApiService
    {
        private readonly HttpClient _httpClient;

        public ProductsApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //For best practice and performance, httpclient can be used in DIContainer.//

        public async Task<List<ProductsDto>> GetAll()
        {
            var response = await _httpClient.GetFromJsonAsync<List<ProductsDto>>("products");

            return response;
        }

        public async Task<ProductsDto> GetByIdAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<ProductsDto>("products");

            return response;
        }

        public async Task<List<ProductsDto>> GetProductsByCategory(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<List<ProductsDto>>($"products/GetProductsByCategory/{id}");

            return response;
        }
    }
}
