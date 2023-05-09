using Merketo.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Merketo.Helpers.Services
{
    public class UserService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserService(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }


        public async Task CreateUserAsync(UserRegistrationViewModel viewModel)
        {
            if (!await _roleManager.Roles.AnyAsync())
            {
                await _roleManager.CreateAsync(new IdentityRole("administrator"));
                await _roleManager.CreateAsync(new IdentityRole("user"));
            }

            var standardRole = "user";

            if (!await _userManager.Users.AnyAsync())
            {
                standardRole = "administrator";
            }

            var identityUser = new IdentityUser
            {
                UserName = viewModel.Email,
                Email = viewModel.Email
            };

            var result = await _userManager.CreateAsync(identityUser, viewModel.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(identityUser, standardRole);
            }
        }
    }
}
