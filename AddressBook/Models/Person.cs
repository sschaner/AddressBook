using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AddressBook.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        [Required(ErrorMessage = "Please enter a first name.")]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter a last name.")]
        [StringLength(50, ErrorMessage = "Last name cannot be longer than 50 characters.")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Full Name")]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public virtual Address Address { get; set; }
    }
}
