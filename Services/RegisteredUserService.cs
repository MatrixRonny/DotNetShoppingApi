using DotnetShoppingApi.Domain.Model;

public class RegisteredUserService : IRegisteredUserService
{
    private readonly ShoppingContext _context;

    public RegisteredUserService(ShoppingContext context)
    {
        _context = context;
    }

    public RegisteredUser? GetByUsername(string username)
    {
        return _context.RegisteredUsers.FirstOrDefault(u => u.Username == username);
    }
}
