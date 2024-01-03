namespace DotnetShoppingApi.Domain.Model
{
    public class ShoppingCart
    {
        public List<CartItem> Items { get; set; } = null!;
        public RegisteredUser User { get; set; } = null!;
    }
}
