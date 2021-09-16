using Main.Web.Models;
using System.Threading.Tasks;

namespace Main.Web.Services.IServices
{
    public interface IProductServices
    {
        Task<T> GetAllProductsAsync<T>();
        Task<T> GetProductsByIdAsync<T>(int id);
        Task<T> CreateProductsAsync<T>(ProductDto productDto);
        Task<T> UpdateProductsAsync<T>(ProductDto productDto);
        Task<T> DeleteProductsAsync<T>(int id);
    }
}
