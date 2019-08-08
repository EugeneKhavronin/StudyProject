using StudyProject.Identity.Domain.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using StudyProject.Identity.Database.Models;
using StudyProject.Identity.Domain.Models;

namespace StudyProject.Identity.Domain.Services
{
    /// <inheritdoc/>
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserService _userService;
        private readonly TokenManagement _tokenManagement;

        /// <summary/>
        public AuthenticationService(IUserService service, IOptions<TokenManagement> tokenManagement)
        {
            _userService = service;
            _tokenManagement = tokenManagement.Value;
        }

        /// <inheritdoc/>
        [HttpPost("/token")]
        public string Authenticate(LoginModel model)
        {
            if (!_userService.ValidateUser(model.Login, model.Password).Result)
                return null;

            var claim = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, model.Login)
            };

            var key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_tokenManagement.Secret));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var jwtToken = new JwtSecurityToken(
                _tokenManagement.Issuer,
                _tokenManagement.Audience,
                claim,
                expires: DateTime.Now.AddMinutes(_tokenManagement.AccessExpiration),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(jwtToken);
        }
    }
}