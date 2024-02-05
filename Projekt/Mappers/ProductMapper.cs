using Data.Entities;
using Projekt.Models.Products;

namespace Projekt.Mappers.Products
{
    public class ProductMapper
    {
        public static ProductModel FromEntity(ProductEntity entity)
        {
            return new ProductModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Price = entity.Price,
                Producer = entity.Producer,
                ProductionDate = entity.ProductionDate,
                Description = entity.Description,
            };
        }

        public static ProductEntity ToEntity(ProductModel model)
        {
            return new ProductEntity()
            {
                Id = model.Id,
                Name = model.Name,
                Price = model.Price,
                Producer = model.Producer,
                ProductionDate = model.ProductionDate,
                Description = model.Description,
            };
        }
    }
}
