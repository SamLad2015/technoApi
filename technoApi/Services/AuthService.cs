using System;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;
using Microsoft.IdentityModel.Tokens;
using technoApi.Interfaces.Services;
using technoApi.ViewModels;

namespace technoApi.Services
{
    public class AuthService: IAuthService
    {
        public IConfiguration Configuration { get; }
        

        public AuthService(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        public JwtSecurityToken GetToken(AuthViewModel authViewModel)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, authViewModel.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(""));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            
            var token = new JwtSecurityToken(
                issuer: Configuration["AuthTokenSettings:issuer"],
                audience: Configuration["AuthTokenSettings:audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToInt32(Configuration["AuthTokenSettings:durationInMinutes"])),
                signingCredentials: creds);

            return token;
        }
    }
}