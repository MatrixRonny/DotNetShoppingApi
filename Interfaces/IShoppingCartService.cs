using DotnetShoppingApi.Domain.Model;

namespace DotnetShoppingApi.Interfaces;

public interface IShoppingCartService
{
    ShoppingCart GetShoppingCart(string userId);
    CartResult AddItemToCart(string userId, CartItem item);
    CartResult RemoveItemFromCart(string userId, CartItem item);
    CartResult ChangeItemQuantity(string userId, CartItem item, int newQuantity);
}