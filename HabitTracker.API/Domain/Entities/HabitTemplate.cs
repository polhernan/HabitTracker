using HabitTracker.API.Domain.Entities;
using HabitTracker.API.Domain.Shared;

namespace HabitTracker.API.Domain;

public class HabitTemplate : EntityState
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public DateTime DayOfWeek { get; set; }
    public int TimesADay { get; set; }
    
    //? Relations
    public Guid? UserId { get; set; }
    public User? User { get; set; }
    
    public List<Habit>? Habits { get; set; }


    public HabitTemplate()
    {
        
    }
}