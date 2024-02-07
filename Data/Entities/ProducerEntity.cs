using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    [Table("Producers")]
    public class ProducerEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(255)]
        public string Description { get; set; }

        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public AddressEntity Address { get; set; }

        public ICollection<ProductEntity> Products { get; set; }

    }
}
