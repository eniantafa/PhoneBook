using SmartWorkPhoneBook.Data.Models;
using SmartWorkPhoneBook.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWorkPhoneBook.Data.Services
{
    public interface IPhonebookService
    {
        List<Phonebook> allPhonebooks();
        void CreatePhonebook(PhonebookViewModel viewModel);
        Phonebook GetPhonebookById(int phonebookId);
        void UpdatePhonebook(Phonebook newPhonebook);
        bool Exists(int phonebookId);
        void Delete(int phonebookId);
    }
}
