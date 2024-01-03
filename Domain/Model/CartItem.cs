namespace DotnetShoppingApi.Domain.Model;

public class CartItem
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public int MinimumAgeRequirement { get; set; }
}
