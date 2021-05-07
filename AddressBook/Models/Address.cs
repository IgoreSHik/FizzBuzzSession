using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AddressBook.Models
{
    public class Address
    {
        public int Id { get; set; }
        [Display(Name = "Twoja ulubiona ulica")]
        [Required(ErrorMessage = "No podaj ulice")]
        public string Street { get; set; }
        [StringLength(60, MinimumLength = 6), Required(ErrorMessage = "Podaj conajmnei 6 liczb")]
        [Display(Name = "ZipCode jak w WinRAR ale pocztowy")]
        public string ZipCode { get; set; }
        [Required(ErrorMessage = "No chociaż najblizsze miasto")]
        [Display(Name = "Ciasto-Miasto")]
        public string City { get; set; }
        [Display(Name = "Liczba. Number. Число. Zahl. Πλήθος.")]
        public int Number { get; set; }
    }
}