using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AgriEnergyConnect.Models;
using AgriEnergyConnect.Services;
using System.Threading.Tasks;

namespace AgriEnergyConnect.Controllers
{
    [Authorize(Roles = "admin")]
    public class EmployeeController : Controller
    {
        private readonly UserManager<AgriEnergyConnectUser> _userManager;
        private readonly SignInManager<AgriEnergyConnectUser> _signInManager;
        private readonly AgriEnergyConnectDBContext _context;

        public EmployeeController(UserManager<AgriEnergyConnectUser> userManager, SignInManager<AgriEnergyConnectUser> signInManager, AgriEnergyConnectDBContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        // GET: EmployeeController
        public ActionResult Index()
        {
            return View();
        }

        // CreateUser action
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AgriEnergyConnectUser model, string password)
        {
            if (ModelState.IsValid)
            {
                var user = new AgriEnergyConnectUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    PhoneNumber = model.PhoneNumber,
                    Address = model.Address,
                    CreatedAt = DateTime.UtcNow,
                };

                var result = await _userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("ListFarmers");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            else
            {
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    ModelState.AddModelError(string.Empty, error.ErrorMessage);
                }
            }
            return View(model);
        }

        // ListUsers action
        public async Task<IActionResult> ListFarmers()
        {
            var users = await _userManager.Users.OrderBy(u => u.Email).ToListAsync();
            return View(users);
        }


        // ViewProducts action
        public async Task<IActionResult> ViewProducts()
        {
            var products = await _context.Products.ToListAsync();
            return View(products);
        }
    }
}


