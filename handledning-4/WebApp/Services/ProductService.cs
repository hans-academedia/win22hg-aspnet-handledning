using WebApp.Models.Entities;
using WebApp.Repositories;

namespace WebApp.Services
{
    public class ProductService
    {
        private readonly ProductRepository _productRepo;

        public ProductService(ProductRepository productRepo)
        {
            _productRepo = productRepo;
        }






        public async Task<bool> AddAsync(ProductEntity entity)
        {
            var productEntity = await _productRepo.CreateAsync(entity);
            if (productEntity != null)
                return true;

            return false;
        }




    }
}
