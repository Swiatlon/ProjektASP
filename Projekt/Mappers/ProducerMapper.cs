using Data.Entities;
using Projekt.Models.Producer;

namespace Projekt.Mappers.Producers
{
    public class ProducerMapper
    {
        public static ProducerModel FromEntity(ProducerEntity entity)
        {
            return new ProducerModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
            };
        }

        public static ProducerEntity ToEntity(ProducerModel model)
        {
            return new ProducerEntity()
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
            };
        }
    }
}
