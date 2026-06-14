using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Application.Interfaces;

namespace SchoolManagementSystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RolesController : ControllerBase
{
    private readonly IRoleRepository _roleRepository;

    public RolesController(IRoleRepository roleRepository) => _roleRepository = roleRepository;

    [HttpGet]
    public async Task<IActionResult> GetRoles()
    {
        var roles = await _roleRepository.GetAllRolesAsync();

        return Ok(roles);
    }
}