using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWorkPhoneBook.Data.Enums
{
    public enum PhoneType
    {
        [Display(Name = "Work")]
        Work,

        [Display(Name = "Cellphone")]
        Cellphone,

        [Display(Name = "Home)")]
        Home
    }
}
