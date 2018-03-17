using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using technoApi.Interfaces.Services;
using technoApi.ViewModels;

namespace technoApi.Controllers
{
    [Authorize]
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        
        [AllowAnonymous]
        [HttpPost]
        [Route("token")]
        public IActionResult AuthenticateUser([FromBody]AuthViewModel authViewModel)
        {
            return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(_authService.GetToken(authViewModel))
            });
        }
    }
}