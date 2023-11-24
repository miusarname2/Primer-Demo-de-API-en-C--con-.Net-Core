using Demo1.Models;

namespace Demo1.Services
{
    public interface IProductService
    {
        void createProduct(ProductModel product);
        void deleteProduct(int id);
        ProductEntity GetProduct(int id);
        List<ProductEntity> GetProducts();
    }
}