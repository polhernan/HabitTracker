
using HabitTracker.API.Domain;
using HabitTracker.API.Domain.Entities;

namespace HabitTracker.API.Application.Contexts.Users.Commands;

public class SaveUserCommand : IRequest<User>
{
    
    
    public SaveUserRequest Request { get; }


    public SaveUserCommand(SaveUserRequest request)
    {
        Request = request;
    }
}