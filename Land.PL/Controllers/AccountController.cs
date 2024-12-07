using Land.DAL.Models;
using Land.PL.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Land.PL.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager) {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        //public IActionResult Register()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public async Task<IActionResult> Register(RegisterVM model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var user = new ApplicationUser()
        //        {
        //            UserName = model.UserName,
        //            Email = model.Email,
        //        };
        //        var result = await userManager.CreateAsync(user, model.Password);
        //        if (result.Succeeded)
        //        {
        //            return RedirectToAction(nameof(Login));
        //        }
        //    }
        //    return View(model);
        //}

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM model)
        {
            if (ModelState.IsValid) {

                var user = userManager.FindByEmailAsync(model.Email);

                if (user is not null)
                {
                    var check = await userManager.CheckPasswordAsync(await user, model.Password);

                    if (check) {
                        var result = await signInManager.PasswordSignInAsync(await user, model.Password, model.RememberMe, false);
                        if (result.Succeeded) {

                            return RedirectToAction("Index", "Home");
                        }

                    }
                }
            }
            return View(model);
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }
    }

}
