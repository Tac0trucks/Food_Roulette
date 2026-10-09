using System.ComponentModel.DataAnnotations;

namespace FoodRoulette.Models;

/// <summary>One log entry per spin result (User 1..* SpinHistory, Dish 1..* SpinHistory).</summary>
public class SpinHistory
{
	[Key]
	public Guid Id { get; set; } = Guid.NewGuid();

	// Foreign keys
	public Guid UserId { get; set; }
	public User User { get; set; } = null!;

	public Guid DishId { get; set; }
	public Dish Dish { get; set; } = null!;

	public DateTime SpunAt { get; set; } = DateTime.UtcNow;

	/// <summary>Dining mode selected for this spin (session override).</summary>
	public DiningType DiningType { get; set; }

	/// <summary>Optional user feedback, 1-5. Null = not rated yet.</summary>
	[Range(1, 5)]
	public int? Rating { get; set; }
}