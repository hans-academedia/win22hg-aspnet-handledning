namespace Merketo.Models.Dtos;

public class Product
{
    public string? ArticleNumber { get; set; }
    public string? BarCode { get; set; }
    public string? ProductName { get; set; }
    public string? Ingress { get; set; }
    public string? Description { get; set; }
    public string? VendorName { get; set; }
    public List<string> Tags { get; set; } = new List<string>();
}
