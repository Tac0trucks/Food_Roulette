using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodRoulette.Models;

public class User
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required, MaxLength(30)]
    public string Username { get; set; } = string.Empty;

    [Required, MaxLength(80)]
    public string DisplayName { get; set; } = string.Empty;

    [Required, EmailAddress, MaxLength(254)]
    public string Email { get; set; } = string.Empty;

    public bool IsEmailVerified { get; set; }

    [Required]
    public string PasswordHash { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation properties
    public UserPreference? Preference { get; set; }
    public ICollection<SpinHistory> SpinHistory { get; set; } = new List<SpinHistory>();
    public ICollection<SavedMeal> SavedMeals { get; set; } = new List<SavedMeal>();

    /// <summary>Avatar initials, e.g. "John Doe" -> "JD". Computed, not stored.</summary>
    [NotMapped]
    public string Initials => string.Concat(
        DisplayName
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Take(2)
            .Select(part => char.ToUpperInvariant(part[0])));
}