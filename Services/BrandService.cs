using System.Text.Json;
using mauiProject.Models;
using mauiProject.Services;


namespace mauiProject.Services
{
    public class BrandService : IBrandService
    {
        private readonly string url = "http://localhost:5211/Brand";

        public async Task<List<BrandModel>> GetList()
        {
            var client = new HttpClient();
            var response = await client.GetAsync(url + "/GetBrandList");
            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<BrandModel>>(responseBody);
        }

        public async Task<BrandModel> GetById(Guid id)
        {
            var client = new HttpClient();
            var response = await client.GetAsync($"{url}/GetBrandById?id={id.ToString()}");
            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<BrandModel>(responseBody.ToString());
        }
    }
}