namespace DotnetShoppingApi.Domain.Model;

public class RegisteredUser
{
    public string Username { get; set; } = null!;
    public string Password { get; set; } = null!;
    public List<ShoppingCart> ShoppingCarts { get; set; } = null!;
    public string Token { get; set; } = null!;
}