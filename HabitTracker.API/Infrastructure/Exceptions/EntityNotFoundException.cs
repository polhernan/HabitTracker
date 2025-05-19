namespace HabitTracker.API.Infrastructure.Exceptions;

public class EntityNotFoundException : Exception
{
    public EntityNotFoundException() : base("Entity not found")
    {
    }
    public EntityNotFoundException(string message) : base(message)
    {
    }
    public EntityNotFoundException(string message,Exception ex) : base(message,ex)
    {
    }
}