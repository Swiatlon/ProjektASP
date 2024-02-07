using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace Projekt.Models.Products
{
    public class ProductModel
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nazwa jest wymagana.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Cena jest wymagana.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Cena musi być większa niż 0.")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Pole ProducentId jest wymagane.")]
        public int ProducerId { get; set; }

        [Required(ErrorMessage = "Data produkcji jest wymagana.")]
        [DataType(DataType.Date, ErrorMessage = "Podaj poprawną datę produkcji.")]
        public DateTime ProductionDate { get; set; }

        [Required(ErrorMessage = "Opis jest wymagany.")]
        [StringLength(1000, MinimumLength = 10, ErrorMessage = "Opis musi zawierać od 10 do 1000 znaków.")]
        public string Description { get; set; }
    }
}
