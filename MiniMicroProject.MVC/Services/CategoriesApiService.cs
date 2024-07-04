using MiniMicroProject.API.DTOs;

namespace MiniMicroProject.MVC.Services
{
    public class CategoriesApiService
    {
        private readonly HttpClient _httpClient;

        public CategoriesApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //For best practice and performance, httpclient can be used in DIContainer.//

        public async Task<List<CategoriesDto>> GetAll()
        {
            var response = await _httpClient.GetFromJsonAsync<List<CategoriesDto>>("categories");
            return response;
        }
    }
}
