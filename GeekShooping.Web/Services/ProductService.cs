using GeekShooping.Web.Models;
using GeekShooping.Web.Services.IServices;
using GeekShooping.Web.Utilities;
using System.Net.Http;

namespace GeekShooping.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _client;
        public const string BasePath = "api/v1/product";
        public async Task<IEnumerable<ProductModel>> FindAllProducts()
        {
            var response = await _client.GetAsync(BasePath);
            return await response.ReadContentTAs<List<ProductModel>>();
        }
        public async Task<ProductModel> FindProductById(long id)
        {
            var response = await _client.GetAsync($"{BasePath}/{id}");
            return await response.ReadContentTAs<ProductModel>();
        }
        public async Task<ProductModel> CreateProduct(ProductModel model)
        {
            throw new NotImplementedException();
        }
        public async Task<ProductModel> UpdateProduct(ProductModel model)
        {
            throw new NotImplementedException();
        }
        public async Task<bool> DeleteProductById(long id)
        {
            throw new NotImplementedException();
        }

    }
}
