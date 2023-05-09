using Merketo.Helpers.Repositories;
using Merketo.Models.Dtos;
using System.Diagnostics;

namespace Merketo.Helpers.Services;

public class ProductService
{
    private readonly ProductEntityRepo _productEntityRepo;

    public ProductService(ProductEntityRepo productEntityRepo)
    {
        _productEntityRepo = productEntityRepo;
    }

    public async Task<IEnumerable<Product>> GetAllByTagNameAsync(string tagName)
    {
        var items = await _productEntityRepo.GetAllAsync();
        var list = new List<Product>();
        foreach (var item in items)
        {
            var tagList = new List<string>();
            foreach (var tag in item.Tags)
                tagList.Add(tag.Tag.TagName);

            list.Add(new Product
            {
                ArticleNumber = item.ArticleNumber,
                Description = item.Description,
                Ingress = item.Ingress,
                Tags = tagList,
                VendorName = item.VendorName,
                ProductName = item.ProductName,
                BarCode = item.BarCode
            });
        }

        return list;
    }

    public async Task<Product> GetAsync(string articleNumber)
    {
        var item = await _productEntityRepo.GetAsync(x => x.ArticleNumber == articleNumber);

        var tagList = new List<string>();
        foreach (var tag in item.Tags)
            tagList.Add(tag.Tag.TagName);

        var product = new Product
        {
            ArticleNumber = item.ArticleNumber,
            Description = item.Description,
            Ingress = item.Ingress,
            Tags = tagList,
            VendorName = item.VendorName,
            ProductName = item.ProductName,
            BarCode = item.BarCode
        };

        return product;
    }
}
