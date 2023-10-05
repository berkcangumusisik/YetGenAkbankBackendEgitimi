using Microsoft.AspNetCore.Mvc;
using PasswordGenerator;
using YetGenAkbankJump.MVCClient.Models;

namespace YetGenAkbankJump.MVCClient.Controllers
{
    public class PasswordsController : Controller
    {

        private readonly PWGenerator _passwordGenerator;
        public PasswordsController()
        {
            _passwordGenerator = new PWGenerator();
        }
        [HttpGet]
        public IActionResult Index()
        {
            var indexViewModel = new PasswordsIndexViewModel();
            indexViewModel.Passwords = _passwordGenerator.GeneratePassword(10, true, true, true, true);
            return View(indexViewModel);
        }

        [HttpPost]
        public IActionResult Index(PasswordsIndexViewModel indexViewModel)
        {
            indexViewModel.Passwords = _passwordGenerator.GeneratePassword(indexViewModel.PasswordsLenght, true, true, true, true);
            return View(indexViewModel);
        }
    }
}
