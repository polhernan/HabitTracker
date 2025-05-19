using HabitTracker.API.Application.Contexts.Users;
using HabitTracker.API.Application.Services;
using HabitTracker.API.Domain.Shared;

namespace HabitTracker.API.Domain.Entities;

public class User : EntityState
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Username  { get; set; }
    
    //? Relations
    public List<Habit>? Habits { get; set; }
    public List<HabitTemplate>? Templates { get; set; }


    public User()
    {
        
    }

    public User(SaveUserRequest request)
    {
        this.Id = Guid.NewGuid();
        this.Email = request.Email;
        this.Password = Crypter.Hash(request.Password);
        this.Username = request.Username;
        this.Created = DateTime.UtcNow;
        this.Modified = DateTime.UtcNow;
    }

    public void UpdateUser(SaveUserRequest request)
    {
        this.Email = request.Email;
        this.Password = Crypter.Hash(request.Password);
        this.Username = request.Username;
        this.Modified = DateTime.UtcNow;
    }
}