using Merketo.Helpers.Repositories;
using Merketo.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Merketo.Controllers
{
    public class ContactsController : Controller
    {
        private readonly ContactFormRepo _contactFormRepo;

        public ContactsController(ContactFormRepo contactFormRepo)
        {
            _contactFormRepo = contactFormRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(ContactFormViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                await _contactFormRepo.AddAsync(new Models.Entities.ContactFormEntity
                {
                    Name = viewModel.Name,
                    Email = viewModel.Email,
                    Message = viewModel.Message
                });

                return RedirectToAction("Index");   
            }

            return View(viewModel);
        }
    }
}
