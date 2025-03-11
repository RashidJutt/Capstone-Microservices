using Microsoft.AspNetCore.Mvc;
using Users.API.Application.DtoModels;

namespace Users.API.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    private readonly ILogger<UsersController> _logger;

    public UsersController(ILogger<UsersController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<UserDto>), StatusCodes.Status200OK)]
    public IActionResult GetUsers()
    {
        var users = new List<UserDto>
        {
            new UserDto { UserId = 1, UserName = "TestUser", Email = "tuser@test.com" },
            new UserDto { UserId = 2, UserName = "TestUser2", Email = "tuser@test.com" }
        };

        return Ok(users);
    }
}
