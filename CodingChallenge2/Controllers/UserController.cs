using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service;
using OrderManagementSystem.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace KeepNote.Controllers
{
    [ApiController]
    [Route("api/user")]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;

        public UserController(IUserService userService, IConfiguration configuration)
        {
            _userService = userService;
            _configuration = configuration;
        }

        [HttpPost("register")]
        public IActionResult RegisterUser(User user)
        {
            var result = _userService.RegisterUser(user);
            if (result)
            {
                return Created("", user); // 201 Created
            }
            return Conflict(); // 409 Conflict
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public IActionResult LoginUser(User user)
        {
            var isValid = _userService.ValidateUser(user.UserId, user.Password);
            if (isValid)
            {
                var token = _userService.GenerateJwtToken(user.UserId, user.UserName); // Pass user.UserId as an int
                return Ok(new { Token = token });
            }
            return Unauthorized();
        }


        [HttpGet("{userId}")]
        public IActionResult GetUserById(int userId)
        {
            var user = _userService.GetUserById(userId);
            if (user != null)
            {
                return Ok(user); // 200 OK
            }
            return NotFound(); // 404 Not Found
        }
    }
}