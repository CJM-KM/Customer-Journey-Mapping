using Microsoft.AspNetCore.Mvc;
using CustomerJourney.API.Data;
using CustomerJourney.API.Models;
using CustomerJourney.API.Services;

namespace CustomerJourney.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly JwtService _jwtService;

        public AuthController(AppDbContext context, JwtService jwtService)
        {
            _context = context;
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel model)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == model.Username);
            if (user == null || user.PasswordHash != model.Password) // Replace with proper hashing
                return Unauthorized();

            var token = _jwtService.GenerateToken(user.Username);
            return Ok(new { token });
        }
    }
}
