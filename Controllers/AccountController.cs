using Hackathon.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hackathon.Controllers
{
    public class AccountController : Controller
{
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            // Perform authentication logic and redirect to the desired page
        }
        return View(model);
    }

    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(RegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            // Save the user's registration data and redirect to the login page
        }
        return View(model);
    }
}
}