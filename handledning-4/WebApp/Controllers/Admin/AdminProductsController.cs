using Microsoft.AspNetCore.Mvc;
using WebApp.Models.Entities;
using WebApp.Repositories;
using WebApp.Services;
using WebApp.ViewModels;

namespace WebApp.Controllers.Admin
{
    [Route("admin/products")]
    public class AdminProductsController : Controller
    {
        private readonly ProductService _productService;
        private readonly ProductRepository _productRepository;

        public AdminProductsController(ProductService productService, ProductRepository productRepository)
        {
            _productService = productService;
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _productRepository.GetAllAsync());
        }





        [HttpGet]
        [Route("new")]
        public IActionResult New() 
        {
            return View();
        }


        [HttpPost]
        [Route("new")]
        public async Task<IActionResult> New(AdminProductsNewViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var _entity = await _productRepository.CreateAsync(viewModel);
                if (_entity != null)
                    return RedirectToAction("Index", "AdminProducts");
            }

            return View(viewModel);
        }






        [HttpGet]
        [Route("edit/{id}")]
        public async Task<IActionResult> Edit(string id)
        {
            var entity = await _productRepository.GetAsync(x => x.ArticleNumber == id);
            if (entity != null)
                return View(entity);

            return RedirectToAction("Index", "AdminProducts");
        }


        [HttpPost]
        [Route("edit")]
        public async Task<IActionResult> Edit(AdminProductsNewViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var entity = await _productRepository.UpdateAsync(viewModel);
                if (entity != null)
                    return RedirectToAction("Index", "AdminProducts");
            }

            return View(viewModel);
        }


















        [HttpGet]
        [Route("remove")]
        public IActionResult Remove()
        {
            return View();
        }


        [HttpPost]
        [Route("edit")]
        public async Task<IActionResult> Remove(AdminProductsNewViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var entity = await _productRepository.CreateAsync(viewModel);
                if (entity != null)
                    return RedirectToAction("Index", "AdminProducts");
            }

            return View(viewModel);
        }

    }
}
