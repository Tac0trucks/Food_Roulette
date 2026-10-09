namespace FoodRoulette.Models;

/// <summary>Price tier: $ = 1, $$ = 2, $$$ = 3.</summary>
public enum BudgetTier
{
    Budget = 1,    // $
    Moderate = 2,  // $$
    Premium = 3    // $$$
}

public enum DiningType
{
    QuickBite = 1,
    DineIn = 2,
    Delivery = 3
}

public enum CuisineType
{
    Filipino = 1,
    Japanese = 2,
    Italian = 3,
    Mexican = 4,
    Thai = 5,
    Chinese = 6,
    Korean = 7,
    Indian = 8,
    American = 9,
    Other = 99
}

public enum SpiceLevel
{
    None = 0,
    Mild = 1,
    Medium = 2,
    Hot = 3
}

/// <summary>
/// Dietary tags. On a Dish: what the dish complies with.
/// On UserPreference: what the user requires (e.g. Halal, NutFree for a nut allergy).
/// Stored as a single int column.
/// </summary>
[Flags]
public enum DietaryTag
{
    None = 0,
    Halal = 1,
    Vegan = 2,
    GlutenFree = 4,
    NutFree = 8
}