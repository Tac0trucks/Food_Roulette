using System.ComponentModel.DataAnnotations;

namespace FoodRoulette.Models;

/// <summary>Bookmarked dish. Should be unique per (UserId, DishId) once mapped to the DB.</summary>
public class SavedMeal
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    // Foreign keys
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    public Guid DishId { get; set; }
    public Dish Dish { get; set; } = null!;

    public DateTime SavedAt { get; set; } = DateTime.UtcNow;

    [MaxLength(280)]
    public string? Note { get; set; }
}