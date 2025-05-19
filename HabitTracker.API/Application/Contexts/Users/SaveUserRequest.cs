namespace HabitTracker.API.Application.Contexts.Users;

public class SaveUserRequest
{
    public Guid? Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}