using HabitTracker.API.Domain.Shared;

namespace HabitTracker.API.Domain;

public class Habit : EntityState
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int TodayNum { get; set; }
    public bool done { get; set; }
    
    //? Relations
    public Guid? UserId { get; set; }
    public User User { get; set; }
    
    public Guid? TemplateId { get; set; }
    public HabitTemplate? Template { get; set; }
}