using SmartWorkPhoneBook.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWorkPhoneBook.Data.ViewModels
{
    public class PhonebookViewModel
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "This field is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public PhoneType Type { get; set; }


        [Phone]
        public int PhoneNumber { get; set; }

    }
}
