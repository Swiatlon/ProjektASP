using Microsoft.AspNetCore.Mvc;
using Projekt.Models.Addresses;
using System.ComponentModel.DataAnnotations;

namespace Projekt.Models.Producer
{
    public class ProducerModel
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nazwa jest wymagana.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Opis jest wymagany.")]
        [StringLength(1000, MinimumLength = 10, ErrorMessage = "Opis musi zawierać od 10 do 1000 znaków.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Pole AddressId jest wymagane.")]
        public int AddressId { get; set; }
    }
}
