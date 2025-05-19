using HabitTracker.API.Application.Contexts.Users;
using HabitTracker.API.Application.Contexts.Users.Commands;
using HabitTracker.API.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HabitTracker.API.WebApi.Controllers;

[ApiController]
public class UsersController : Controller
{
    
    
    private readonly IMediator _bus;

    
    public UsersController(IMediator bus)
    {
        _bus = bus;
    }


    [HttpPost("v1/users/")]
    public async Task<ActionResult<User>> SaveUser([FromBody] SaveUserRequest request)
    {
        var saveUserCommand = new SaveUserCommand(request);
        var user = await _bus.Send(saveUserCommand);

        return Ok(user);
    }
}