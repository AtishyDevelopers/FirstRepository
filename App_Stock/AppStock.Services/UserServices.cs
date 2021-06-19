using APPSTOCK.Core.Models;
using APPSTOCK.Persistence.Context;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace APPSTOCK.Services
{
    public interface IUserService
    {
        //string GenerateJSONWebToken(User user);
        Task<string> GenerateJSONWebToken(User user);
        Task<IEnumerable<User>> GetAll();
    }

    public class UserServices: IUserService
    {
        // users hardcoded for simplicity, store in a db with hashed passwords in production applications
        private List<User> _users = new List<User>
        {
            new User { Id = 1, Firstname = "Test", Lastname = "User", Username = "test", Password = "test", Role = "Admin" },
             new User { Id = 2, Firstname = "Normal", Lastname = "User", Username = "user", Password = "user", Role = "User" }
        };

        private IConfiguration _config { get; }

        private readonly ApplicationContext _context;

        public UserServices(IConfiguration configuration, ApplicationContext context)
        {
            _config = configuration;
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            // return users without passwords
            return await Task.Run(() => _users.Select(x => {
                x.Password = null;
                return x;
            }));
        }

        public async Task<string> GenerateJSONWebToken(User userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));            
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            
            var token = new JwtSecurityToken(null,
              null,
               new[]
                {                
                new Claim("fullName", userInfo.Firstname.ToString()),
                //new Claim("role",userInfo.Role),
                new Claim(ClaimTypes.Role, userInfo.Role),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Exp,DateTime.Now.AddSeconds(120).ToString())
                },
              expires: DateTime.Now.AddSeconds(180),
              signingCredentials: credentials);
            //string accessToken = new JwtSecurityTokenHandler().WriteToken(token);
            return await Task.Run(() => new JwtSecurityTokenHandler().WriteToken(token));           
        }
    }
}
