using Demo1.Data;
using Demo1.Models;

namespace Demo1.Services
{
    public class ProductService : IProductService
    {
        private readonly StoreDbContext _context;

        public ProductService(StoreDbContext context)
        {
            this._context = context;
        }

        public void createProduct(ProductModel product)
        {
            ProductEntity productToAdd = new()
            {
                Name = product.Name,
                Description = product.Description,
                CreateDate = DateTime.Now,
                Stock = product.Stock
            };
            _context.Products.Add(productToAdd);
            _context.SaveChanges();
        }

        public void deleteProduct(int id)
        {
            ProductEntity productToDelet = GetProduct(id);
            _context.Products.Remove(productToDelet);
        }

        public ProductEntity GetProduct(int id)
        {
            return _context.Products.Find(id);
        }

        public List<ProductEntity> GetProducts()
        {
            return _context.Products.ToList();
        }


    }
}
