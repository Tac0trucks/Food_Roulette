using System.ComponentModel.DataAnnotations;

namespace FoodRoulette.Models;

/// <summary>Persistent engine settings (1-to-1 with User).</summary>
public class UserPreference
{
	[Key]
	public Guid Id { get; set; } = Guid.NewGuid();

	// Foreign key (unique) -> User
	public Guid UserId { get; set; }
	public User User { get; set; } = null!;

	public DietaryTag DietaryRestrictions { get; set; } = DietaryTag.None;

	public BudgetTier DefaultBudget { get; set; } = BudgetTier.Moderate;

	public DiningType DefaultDining { get; set; } = DiningType.DineIn;

	[Range(1, 50)]
	public int MaxRadiusKm { get; set; } = 5;

	public bool ExcludeSpicyDefault { get; set; } = true;
}