namespace FoodRouletteApp.Models;

public class DishItem
{
    public string Name { get; set; } = "";
    public string Place { get; set; } = "";
    public string Cuisine { get; set; } = "";
    public int Budget { get; set; } = 2; // 1, 2, or 3
    public int Mins { get; set; } = 20;
    public string Dist { get; set; } = "1.0 mi";
    public string ImgId { get; set; } = "";
    public bool IsSpicy { get; set; } = false;
}

public class HistoryItem
{
    public string Name { get; set; } = "";
    public string Place { get; set; } = "";
    public string When { get; set; } = "";
    public string Tag { get; set; } = "";
    public string Rating { get; set; } = "";
}

public class AppState
{
    public event Action? OnChange;

    // Authentication State (Guest Flow Removed)
    public bool IsAuthenticated { get; set; } = false;
    public string DisplayName { get; set; } = "John Doe";
    public string Username { get; set; } = "johndoe";
    public string Email { get; set; } = "john@example.com";
    public string Initials => "JD";

    // Roulette Preferences (from Settings)
    public List<string> DietaryRestrictions { get; set; } = new() { "Halal", "Nut Allergy" };
    public int DefaultBudget { get; set; } = 2;
    public string DefaultDining { get; set; } = "Dine-In";
    public int MaxRadiusKm { get; set; } = 5;
    public bool ExcludeSpicyDefault { get; set; } = true;

    // Data Counters
    public int SpinCount { get; set; } = 142;
    public int BookmarksCount { get; set; } = 18;

    public void NotifyChanged() => OnChange?.Invoke();
}