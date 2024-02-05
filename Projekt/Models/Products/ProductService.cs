using Data.Entities;
using Data;
using Projekt.Mappers.Products;

namespace Projekt.Models.Products
{
    public class ProductService : IProductService
    {
        private AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductModel> GetAllProducts()
        {
            return _context.Products.Select(e => ProductMapper.FromEntity(e)).ToList();
        }

        public ProductModel? GetProductById(int productId)
        {
            ProductEntity? entity = _context.Products.Find(productId);
            return entity != null ? ProductMapper.FromEntity(entity) : null;
        }

        public void AddProduct(ProductModel model)
        {
            var entity = ProductMapper.ToEntity(model);
            _context.Products.Add(entity);
            _context.SaveChanges();
        }

        public void UpdateProduct(ProductModel updatedProduct)
        {
            _context.Products.Update(ProductMapper.ToEntity(updatedProduct));
            _context.SaveChanges();
        }

        public void DeleteProduct(int productId)
        {
            ProductEntity find = _context.Products.Find(productId);
            if (find != null)
            {
                _context.Products.Remove(find);
                _context.SaveChanges();
            }
        }
    }
}
