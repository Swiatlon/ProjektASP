using Data.Entities;
using Projekt.Models.Addresses;

namespace Projekt.Mappers.AddressMapper
{
    public class AddressMapper
    {
        public static AddressModel FromEntity(AddressEntity entity)
        {
            return new AddressModel()
            {
                Id = entity.Id,
                City = entity.City,
                Street = entity.Street,
                PostalCode = entity.PostalCode,
                Region = entity.Region
            };
        }

        public static AddressEntity ToEntity(AddressModel model)
        {
            return new AddressEntity()
            {
                Id = model.Id,
                City = model.City,
                Street = model.Street,
                PostalCode = model.PostalCode,
                Region = model.Region
            };
        }
    }
}
