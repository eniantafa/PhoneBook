using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartWorkPhoneBook.Data.Models;
using SmartWorkPhoneBook.Data.Services;
using SmartWorkPhoneBook.Data.ViewModels;

namespace SmartWorkPhoneBook.Controllers
{
    public class PhonebookController : Controller
    {

        //Dependency Injection
        private IPhonebookService _phonebookService;
        public PhonebookController(IPhonebookService phonebookService)
        {
            _phonebookService = phonebookService;
        }

        // GET: All Sites
        public ActionResult Index()
        {
            List<Phonebook> phonebooks = _phonebookService.allPhonebooks();
            return View(phonebooks);
        }

        public ActionResult CreatePhonebook()
        {
            return View("~/Views/Phonebook/Create.cshtml", new PhonebookViewModel());
        }


        //[HttpPost]

        public ActionResult Create(PhonebookViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Phonebook Problem");
                return View();
            }

            _phonebookService.CreatePhonebook(viewModel);
            return View();
        }

        public ActionResult Edit(int id)
        {
            Phonebook myPhonebook = _phonebookService.GetPhonebookById(id);
            return View(myPhonebook);
        }

        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(Phonebook phonebook)
        {
            _phonebookService.UpdatePhonebook(phonebook);
            return View();
        }

        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            if (!_phonebookService.Exists(id))
            {
                return RedirectToAction("Index");
            }
            return View(_phonebookService.GetPhonebookById(id));
        }



        // POST: /Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            _phonebookService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}