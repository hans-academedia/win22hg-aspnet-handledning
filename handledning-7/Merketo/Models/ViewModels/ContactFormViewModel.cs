using System.ComponentModel.DataAnnotations;

namespace Merketo.Models.ViewModels
{
    public class ContactFormViewModel
    {
        [Required]
        public string Name { get; set; } = null!;

        [EmailAddress]
        [Required]
        public string Email { get; set; } = null!;

        [Required]
        public string Message { get; set; } = null!;
    }
}
