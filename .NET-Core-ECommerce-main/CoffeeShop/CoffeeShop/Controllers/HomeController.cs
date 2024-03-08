using CoffeeShop.Models;
using CoffeeShop.Models.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{

    public class HomeController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private IProductRepository productRepository;
        public HomeController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, IProductRepository productRepository)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            this.productRepository = productRepository;
        }

        public IActionResult Index()
        {
            return View(productRepository.GetTrendingProducts());
        }

        // GET: Contact
        public IActionResult Contact()
        {
            return View();
        }

        // POST: Contact
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Process the form (e.g., send an email) here

                // Redirect to a confirmation page or back to the contact form with a success message
                return RedirectToAction("ContactConfirmation");
            }

            // If we got this far, something failed; redisplay the form
            return View(model);
        }

        public IActionResult ContactConfirmation()
        {
            return View();
        }
        public async Task<IActionResult> SomeAction()
        {
            var user = await _userManager.GetUserAsync(User);
            var isAdmin = await _userManager.IsInRoleAsync(user, "Admin");

            ViewBag.IsAdmin = isAdmin;
            return View();
        }
    }
}
