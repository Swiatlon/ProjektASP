using Data;
using Data.Entities;
using Projekt.Mappers.AddressMapper;

namespace Projekt.Models.Addresses
{
    public class AddressService : IAddressService
    {
        private readonly AppDbContext _context;

        public AddressService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<AddressModel> GetAllAddresses()
        {
            return _context.Addresses.Select(a => AddressMapper.FromEntity(a)).ToList();
        }

        public AddressModel GetAddressById(int id)
        {
            var entity = _context.Addresses.Find(id);
            return entity != null ? AddressMapper.FromEntity(entity) : null;
        }
    }
}
