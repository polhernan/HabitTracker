using HabitTracker.API.Domain;
using HabitTracker.API.Domain.AbstractRepositories;
using HabitTracker.API.Domain.Entities;
using HabitTracker.API.Infrastructure.Exceptions;

namespace HabitTracker.API.Application.Contexts.Users.Commands.Handlers;

public class SaveUserCommandHandler : IRequestHandler<SaveUserCommand, User>
{
    
    
    private readonly HabitTrackerDbContext _context;


    public SaveUserCommandHandler(HabitTrackerDbContext context)
    {
        _context = context;
    }
    
    
    public async Task<User> Handle(SaveUserCommand request, CancellationToken cancellationToken)
    {
        User? user;
        if (request.Request.Id == null || request.Request.Id.Equals(Guid.Empty))
        {
            user = new User(request.Request);
        }
        else
        {
            user = _context.Users.FirstOrDefault(u => u.Id == request.Request.Id);
            
            if(user == null)
                throw new EntityNotFoundException($"User with id {request.Request.Id} not found");
            
            user.UpdateUser(request.Request);
        }
        
        _context.Users.Add(user);
        
        await _context.SaveChangesAsync();
        
        return user;
    }
}