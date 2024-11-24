using Dotnet.Homeworks.Domain.Entities;
using Dotnet.Homeworks.MainProject.Dto;
using Dotnet.Homeworks.MainProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet.Homeworks.MainProject.Controllers;

[ApiController]
public class UserManagementController : ControllerBase
{
    private readonly ILogger<UserManagementController> _logger;
    
    public UserManagementController(ILogger<UserManagementController> logger)
    {
        _logger = logger;
    }
    
    [HttpPost("user")]
    public async Task<IActionResult> CreateUser(IRegistrationService registrationService, RegisterUserDto userDto, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Creating new user with email {0}", userDto.Email);
        await registrationService.RegisterAsync(userDto, cancellationToken);
        _logger.LogInformation("Created new user with email {0}", userDto.Email);
        return Ok();
    }

    [HttpGet("profile/{guid}")]
    public Task<IActionResult> GetProfile(Guid guid, CancellationToken cancellationToken) 
    {
        throw new NotImplementedException();
    }

    [HttpGet("users")]
    public Task<IActionResult> GetAllUsers(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("profile/{guid:guid}")]
    public Task<IActionResult> DeleteProfile(Guid guid, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    [HttpPut("profile")]
    public Task<IActionResult> UpdateProfile(User user, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("user/{guid:guid}")]
    public Task<IActionResult> DeleteUser(Guid guid, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}