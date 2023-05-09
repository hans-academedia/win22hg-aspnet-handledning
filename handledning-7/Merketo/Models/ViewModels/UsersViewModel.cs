using Microsoft.AspNetCore.Identity;

namespace Merketo.Models.ViewModels
{
    public class UsersViewModel
    {
        public IList<IdentityUser> Users { get; set; } = new List<IdentityUser>();
        public IList<IdentityUser> Administrators { get; set; } = new List<IdentityUser>();

    }
}
