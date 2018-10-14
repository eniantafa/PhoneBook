using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWorkPhoneBook.Data.Models;
using SmartWorkPhoneBook.Data.ViewModels;

namespace SmartWorkPhoneBook.Data.Services
{
    public class PhonebookService :IPhonebookService
    {





        private AppDbContext _context;
        public PhonebookService(AppDbContext context)
        {
            _context = context;
        }

        public List<Phonebook> allPhonebooks()
        {
            return _context.Phonebooks.ToList();
        }

        


        public void CreatePhonebook(PhonebookViewModel viewModel)
        {
            Phonebook phonebook = new Phonebook()
            {
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                Type = viewModel.Type,
                PhoneNumber = viewModel.PhoneNumber
            };

            _context.Phonebooks.Add(phonebook);
            _context.SaveChanges();
        }

        public void Delete(int phonebookId)
        {
            Phonebook phonebook = _context.Phonebooks.Where(n => n.Id == phonebookId).FirstOrDefault();
            _context.Phonebooks.Remove(phonebook);
            _context.SaveChanges();
        }

        public bool Exists(int phonebookId)
        {
            return _context.Phonebooks.Any(n => n.Id == phonebookId);
        }





        public Phonebook GetPhonebookById(int phonebookId)
        {
            return _context.Phonebooks.Where(n => n.Id == phonebookId).FirstOrDefault();
        }

       

        public void UpdatePhonebook(Phonebook newPhonebook)
        {
           Phonebook oldPhonebook = GetPhonebookById(newPhonebook.Id);


            oldPhonebook.FirstName = newPhonebook.FirstName;
            oldPhonebook.LastName = newPhonebook.LastName;
            oldPhonebook.Type = newPhonebook.Type;
            oldPhonebook.PhoneNumber = newPhonebook.PhoneNumber;

            _context.SaveChanges();
        }

      
    }
}
