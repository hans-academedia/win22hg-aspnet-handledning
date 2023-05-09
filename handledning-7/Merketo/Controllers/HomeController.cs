using Merketo.Helpers.Repositories;
using Merketo.Helpers.Services;
using Merketo.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Merketo.Controllers;

public class HomeController : Controller
{
    private readonly ProductService _productService;

    public HomeController(ProductService productService)
    {
        _productService = productService;
    }

    public async Task<IActionResult> Index()
    {
        var viewModel = new HomeViewModel
        {
            BestCollection = new CollectionViewModel
            {
                Title = "Best Collection",
                Items = await _productService.GetAllByTagNameAsync("new")
            }
        };

        return View(viewModel);
    }
}
