using mauiProject.Models;

namespace mauiProject.Services
{
    public interface IBrandService
    {
        public Task<List<BrandModel>> GetList();
        public Task<BrandModel> GetById(Guid id);
    }
}