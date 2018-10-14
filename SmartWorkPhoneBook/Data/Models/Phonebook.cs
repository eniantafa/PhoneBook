using SmartWorkPhoneBook.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWorkPhoneBook.Data.Models
{
    public class Phonebook
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public PhoneType Type { get; set; }

        [Phone]
        public int PhoneNumber { get; set; }

    }
}
