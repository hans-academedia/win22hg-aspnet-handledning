using Merketo.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Merketo.Controllers;

[Authorize(Roles = "administrator")]
public class AdminController : Controller
{
    private readonly UserManager<IdentityUser> _userManager;

    public AdminController(UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<IActionResult> Index()
    {
        var viewModel = new UsersViewModel
        {
            Users = await _userManager.GetUsersInRoleAsync("user"),
            Administrators = await _userManager.GetUsersInRoleAsync("administrator")
        };

        return View(viewModel);
    }
}
