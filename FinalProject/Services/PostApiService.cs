using FinalProject.Core.Models;

namespace FinalProject.Web.Services
{
    public class PostApiService
    {
        private readonly HttpClient _httpClient;

        public PostApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
    }
}
