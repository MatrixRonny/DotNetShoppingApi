namespace DotnetShoppingApi.Domain.Model;

public class Product
{
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public int MinimumAge { get; set; }
}
