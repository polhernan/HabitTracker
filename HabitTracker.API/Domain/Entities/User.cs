using HabitTracker.API.Domain.Shared;

namespace HabitTracker.API.Domain;

public class User : EntityState
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Username  { get; set; }
    
    //? Relations
    public List<Habit>? Habits { get; set; }
    public List<HabitTemplate>? Templates { get; set; }
}