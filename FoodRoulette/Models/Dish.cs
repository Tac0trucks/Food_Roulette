using System.ComponentModel.DataAnnotations;

namespace FoodRoulette.Models;

public class Dish
{
	[Key]
	public Guid Id { get; set; } = Guid.NewGuid();

	[Required, MaxLength(120)]
	public string Name { get; set; } = string.Empty;

	[Required, MaxLength(120)]
	public string RestaurantName { get; set; } = string.Empty;

	public CuisineType Cuisine { get; set; } = CuisineType.Other;

	public BudgetTier Budget { get; set; } = BudgetTier.Moderate;

	[Range(0, 240)]
	public int PrepTimeMinutes { get; set; }

	[Range(0, 500)]
	public double DistanceKm { get; set; }

	[MaxLength(500)]
	public string? ImageUrl { get; set; }

	public SpiceLevel Spice { get; set; } = SpiceLevel.None;

	/// <summary>Dietary needs this dish satisfies (flags).</summary>
	public DietaryTag DietaryTags { get; set; } = DietaryTag.None;

	// Navigation properties
	public ICollection<SpinHistory> SpinHistory { get; set; } = new List<SpinHistory>();
	public ICollection<SavedMeal> SavedMeals { get; set; } = new List<SavedMeal>();
}