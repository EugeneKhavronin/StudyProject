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
        private readonly IUserManagementService _userManagementService;
        private readonly TokenManagement _tokenManagement;

        /// <summary/>
        public AuthenticationService(IUserManagementService service, IOptions<TokenManagement> tokenManagement)
        {
            _userManagementService = service;
            _tokenManagement = tokenManagement.Value;
        }

        /// <inheritdoc/>
        [HttpPost("/token")]
        public string Authentication(LoginModel model)
        {
            string token = string.Empty;

            if (!_userManagementService.ValidUser(model.Login, model.Password).Result)
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

            token = new JwtSecurityTokenHandler().WriteToken(jwtToken);

            return token;
        }
    }
}