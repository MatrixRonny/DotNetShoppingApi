using System.Net;
using DotnetShoppingApi.Domain.Model;
using DotnetShoppingApi.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DotnetShoppingApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShoppingCartController : ControllerBase
    {
        private readonly IShoppingCartService _shoppingCartService;
        private readonly IRegisteredUserService _registeredUserService;

        public ShoppingCartController(IShoppingCartService shoppingCartService, IRegisteredUserService registeredUserRepository)
        {
            _shoppingCartService = shoppingCartService;
            _registeredUserService = registeredUserRepository;
        }

        [HttpGet]
        [Authorize]
        public ActionResult<ShoppingCart> Get()
        {
            string? userName = GetRegisteredUser().Username;
            var shoppingCart = _shoppingCartService.GetShoppingCart(userName);
            return shoppingCart;
        }

        [HttpPost]
        [Authorize]
        public ActionResult AddItem(CartItem item)
        {
            var username = GetRegisteredUser().Username;
            var result = _shoppingCartService.AddItemToCart(username, item);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            return Ok();
        }

        // ... other actions for removing items, changing quantity, etc. ...

        #region Helper methods

        private RegisteredUser GetRegisteredUser()
        {
            string? userName = User.Identity?.Name;
            if (String.IsNullOrEmpty(userName))
                throw new HttpRequestException(null, null, HttpStatusCode.Unauthorized);

            RegisteredUser? registeredUser = _registeredUserService.GetByUsername(userName);
            if (registeredUser == null)
                throw new HttpRequestException(null, null, HttpStatusCode.Unauthorized);

            return registeredUser;
        }

        #endregion
    }
}
