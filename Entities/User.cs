namespace JwtAuthApi.Entities;

public class User
{
    // public Guid Id { get; set; }
    public string Username { get; set; } = string.Empty;
    // public string Email { get; set; }
    public string PasswordHash { get; set; } = string.Empty;
    // public DateTime CreatedAt { get; set; }
    // public DateTime? UpdatedAt { get; set; }
    // public DateTime? DeletedAt { get; set; }
    // public List<Role> Roles { get; set; }
}