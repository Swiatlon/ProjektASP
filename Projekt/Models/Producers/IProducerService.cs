namespace Projekt.Models.Producer
{
    public interface IProducerService
    {
        void AddProducer(ProducerModel model);
        void UpdateProducer(ProducerModel updatedProduct);
        void DeleteProducer(int productId);
        string GetProducerNameById(int producerId);
        IEnumerable<ProducerModel> GetAllProducers();
        ProducerModel? GetProducerById(int productId);
    }
}
