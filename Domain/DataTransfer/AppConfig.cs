namespace DotnetShoppingApi.Domain.DataTransfer
{
    public class AppConfig
    {
        public JwtConfig Jwt { get; set; } = null!;
    }

    public class JwtConfig
    {
        public string TokenIssuer { get; set; } = null!;
        public string TokenKey { get; set; } = null!;
        public TimeSpan TokenExpiration { get; set; } = TimeSpan.FromHours(2);
        public string TokenAudience { get; set; } = "defaultAudience";
    }
}