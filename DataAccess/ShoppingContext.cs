using DotnetShoppingApi.Domain.Model;
using Microsoft.EntityFrameworkCore;

public class ShoppingContext : DbContext
{
    public ShoppingContext(DbContextOptions options) : base(options) { }

    public virtual DbSet<CartItem> CartItems { get; set; }
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<RegisteredUser> RegisteredUsers { get; set; }
}
