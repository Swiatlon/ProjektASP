using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Projekt.Models.Addresses
{
    public class AddressModel
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Miasto jest wymagane.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Ulica jest wymagana.")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Kod pocztowy jest wymagany.")]
        [RegularExpression(@"^\d{2}-\d{3}$", ErrorMessage = "Kod pocztowy musi być w formacie XX-XXX.")]
        public string PostalCode { get; set; }

        [StringLength(50, ErrorMessage = "Region nie może być dłuższy niż 50 znaków.")]
        public string Region { get; set; }
    }
}