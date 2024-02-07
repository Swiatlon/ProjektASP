using Data.Entities;
using Data;
using Projekt.Mappers.Producers;
using Microsoft.EntityFrameworkCore;

namespace Projekt.Models.Producer
{
    public class ProducerService : IProducerService
    {
        private AppDbContext _context;

        public ProducerService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ProducerModel> GetAllProducers()
        {
            return _context.Producers.Select(e => ProducerMapper.FromEntity(e)).ToList();
        }

        public ProducerModel? GetProducerById(int productId)
        {
            ProducerEntity? entity = _context.Producers.Find(productId);
            return entity != null ? ProducerMapper.FromEntity(entity) : null;
        }

        public void AddProducer(ProducerModel model)
        {
            var entity = ProducerMapper.ToEntity(model);
            _context.Producers.Add(entity);
            _context.SaveChanges();
        }

        public void UpdateProducer(ProducerModel updatedProducer)
        {
            _context.Producers.Update(ProducerMapper.ToEntity(updatedProducer));
            _context.SaveChanges();
        }

        public void DeleteProducer(int productId)
        {
            ProducerEntity find = _context.Producers.Find(productId);
            if (find != null)
            {
                _context.Producers.Remove(find);
                _context.SaveChanges();
            }
        }

        public string GetProducerNameById(int producerId)
        {
            var producer = _context.Producers.FirstOrDefault(p => p.Id == producerId);
            return producer != null ? producer.Name : "Unknown Producer";
        }
    }
}
