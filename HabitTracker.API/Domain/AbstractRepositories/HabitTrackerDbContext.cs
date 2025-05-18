using Microsoft.EntityFrameworkCore;

namespace HabitTracker.API.Domain.AbstractRepositories;

public class HabitTrackerDbContext : DbContext
{

    public HabitTrackerDbContext(DbContextOptions<HabitTrackerDbContext> options) : base(options) { }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Habit> Habits { get; set; }
    public DbSet<HabitTemplate> Templates { get; set; }
    
}