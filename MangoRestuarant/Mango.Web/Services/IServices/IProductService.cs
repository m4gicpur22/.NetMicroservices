using Mango.Web.Models;

namespace Mango.Web.Services.IServices
{
    public interface IProductService
    {
        Task<T> GetAllProductsAsync<T>();

        Task<T> GetProductByIdAsync<T>(int id);

        Task<T> CreateProductAsync<T>(ProductDto productDto);

        Task<T> UpdateProductsAsync<T>(ProductDto productDto);

        Task<T> DeleteProductAsync<T>(int id);
    }
}
