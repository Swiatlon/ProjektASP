namespace Projekt.Models.Addresses
{
    public interface IAddressService
    {
        IEnumerable<AddressModel> GetAllAddresses();

        AddressModel? GetAddressById(int id);
    }
}
