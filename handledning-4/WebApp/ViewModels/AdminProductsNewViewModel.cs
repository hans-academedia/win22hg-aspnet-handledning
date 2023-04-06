using System.ComponentModel.DataAnnotations;
using WebApp.Models.Entities;

namespace WebApp.ViewModels
{
    public class AdminProductsNewViewModel
    {
        [Display(Name = "Artikelnummer")]
        [Required(ErrorMessage = "Du måste ange ett artikelnummer")]
        public string ArticleNumber { get; set; } = null!;


        [Display(Name = "Produktens namn")]
        [Required(ErrorMessage = "Du måste ange ett produktnamn")]
        public string Name { get; set; } = null!;


        [Display(Name = "Produktbeskrivning")]
        [Required(ErrorMessage = "Du måste ange en produktbeskrivning")]
        public string Description { get; set; } = null!;


        [Display(Name = "Produktens pris (i SEK)")]
        [Required(ErrorMessage = "Du måste ange produktens pris")]
        public decimal Price { get; set; } = 0;


        [Display(Name = "Produktbild")]
        public IFormFile? Image { get; set; }


        //Omvandlar/Mapping: AdminProductsNewViewModel -> ProductEntity

        public static implicit operator ProductEntity(AdminProductsNewViewModel model)
        {
            return new ProductEntity
            {
                ArticleNumber = model.ArticleNumber,
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
                ImageName = model.Image?.FileName
            };
        }
    }
}
