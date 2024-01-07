using Catalog.API.Entities;
using Catalog.API.Repositories.Interface;
using Catalog.API.Services.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.API.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task CreateProductAsync(Product product)
        {
            await _productRepository.CreateProductAsync(product).ConfigureAwait(false);
        }

        public async Task<bool> DeleteProductAsync(string id)
        {
            return await _productRepository.DeleteProductAsync(id).ConfigureAwait(false);
        }

        public async Task<IEnumerable<Product>> GetProductByCategoryAsync(string categoryName)
        {
            return await _productRepository.GetProductByCategoryAsync(categoryName).ConfigureAwait(false);
        }

        public async Task<Product> GetProductByIdAsync(string id)
        {
            return await _productRepository.GetProductByIdAsync(id).ConfigureAwait(false);
        }

        public async Task<IEnumerable<Product>> GetProductByNameAsync(string name)
        {
            return await _productRepository.GetProductByNameAsync(name).ConfigureAwait(false);
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _productRepository.GetProductsAsync().ConfigureAwait(false);
        }

        public async Task<bool> UpdateProductAsync(Product product)
        {
            return await _productRepository.UpdateProductAsync(product).ConfigureAwait(false);
        }
    }
}
