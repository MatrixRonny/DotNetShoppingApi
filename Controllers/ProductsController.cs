using DotnetShoppingApi.Domain.Enum;
using DotnetShoppingApi.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace DotnetShoppingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ShoppingContext _context;

        public ProductsController(ShoppingContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IList<Product> FindProducts(string productName, ProductCategory category = ProductCategory.All)
        {
            var query = _context.Products.AsQueryable();
            if (!string.IsNullOrEmpty(productName))
            {
                query = query.Where(p => p.Name.Contains(productName));
            }
            if (category != ProductCategory.All)
            {
                query = query.Where(p => p.Category == category);
            }
            return query.ToList();
        }
    }
}