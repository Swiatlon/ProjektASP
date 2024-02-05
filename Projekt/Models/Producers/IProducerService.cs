namespace Projekt.Models.Producer
{
    public interface IProducerService
    {
        void AddProducer(ProducerModel model);
        void UpdateProducer(ProducerModel updatedProduct);
        void DeleteProducer(int productId);
        IEnumerable<ProducerModel> GetAllProducers();
        ProducerModel? GetProducerById(int productId);
    }
}
