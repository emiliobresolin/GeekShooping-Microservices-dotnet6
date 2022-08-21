using GeekShooping.Web.Models;

namespace GeekShooping.Web.Services.IServices
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> FindAllProducts();
        Task<ProductModel> FindProductById(long id);
        Task<ProductModel> CreateProduct(ProductModel model);
        Task<ProductModel> UpdateProduct(ProductModel model);
        Task<bool> DeleteProductById(long id);
    }
}
