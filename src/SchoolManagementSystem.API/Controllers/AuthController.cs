using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Application.DTOs.Auth;
using SchoolManagementSystem.Application.Interfaces;

namespace SchoolManagementSystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController(IAuthService authService) : ControllerBase
{
    private readonly IAuthService _authService = authService;

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        var result = await _authService.LoginAsync(request);

        if (result == null)
            return Unauthorized(
                "Invalid Email or Password");

        return Ok(result);
    }
}