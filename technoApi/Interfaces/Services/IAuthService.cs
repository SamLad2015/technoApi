using System.IdentityModel.Tokens.Jwt;
using technoApi.ViewModels;

namespace technoApi.Interfaces.Services
{
    public interface IAuthService
    {
        JwtSecurityToken GetToken(AuthViewModel authViewModel);
    }
}