namespace DotnetShoppingApi.Domain.Model;

public class CartResult
{
    public bool Success { get; set; }
    public string Message { get; set; } = null!;
}