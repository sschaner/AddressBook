using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AddressBook.Models
{
    public class Address
    {
        [Key]
        [ForeignKey("Person")]
        public int AddressId { get; set; }
        [Required(ErrorMessage = "Please enter a street address.")]
        [StringLength(50, ErrorMessage = "Street address cannot be longer than 50 characters.")]
        public string Street { get; set; }
        [Required(ErrorMessage = "Please enter a city.")]
        [StringLength(50, ErrorMessage = "City name cannot be longer than 50 characters.")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter a state.")]
        [StringLength(2, ErrorMessage = "State cannot be longer than 2 characters.")]
        public string State { get; set; }
        [Required(ErrorMessage = "Please enter a zip code.")]
        [DisplayName("Zip Code")]
        public int Zip { get; set; }
        public virtual Person Person { get; set; }
    }
}
