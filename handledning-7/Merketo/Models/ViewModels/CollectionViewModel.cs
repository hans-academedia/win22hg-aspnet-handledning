using Merketo.Models.Dtos;

namespace Merketo.Models.ViewModels;

public class CollectionViewModel
{
    public string? Title { get; set; }
    public IEnumerable<Product> Items { get; set; } = new List<Product>();
}
