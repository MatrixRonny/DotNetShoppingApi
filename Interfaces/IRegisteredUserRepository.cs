using DotnetShoppingApi.Domain.Model;
using DotnetShoppingApi.Interfaces;

public interface IRegisteredUserService
{
    RegisteredUser? GetByUsername(string username);
}


