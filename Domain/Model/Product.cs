using DotnetShoppingApi.Domain.Enum;

namespace DotnetShoppingApi.Domain.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ProductCategory Category { get; set; }
        // ... other product properties
    }
}