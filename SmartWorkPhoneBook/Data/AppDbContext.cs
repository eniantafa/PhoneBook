using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartWorkPhoneBook.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWorkPhoneBook.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        public DbSet<Phonebook> Phonebooks { get; set; }
       
    }
}
