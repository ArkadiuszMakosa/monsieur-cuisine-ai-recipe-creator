using Microsoft.Playwright;

namespace monsieur_cuisine_ai_recipe.Domain.PageObjects.Pages;

/// <summary>
/// Represents the "My Recipes" page on Monsieur Cuisine.
/// URL: https://www.monsieur-cuisine.com/pl/moje-przepisy?section=all
/// </summary>
public class MyRecipesPage : BasePage
{
    public override string Url => "https://www.monsieur-cuisine.com/pl/moje-przepisy?section=all";

    private ILocator RecipeCards => Page.Locator(".recipe-card, [data-testid='recipe-card'], .recipe-item");

    public MyRecipesPage(IPage page) : base(page) { }

    /// <summary>
    /// Returns true when the page has redirected to a login page,
    /// indicating the user is not authenticated.
    /// </summary>
    public bool IsLoginRequired()
    {
        return Page.Url.Contains("accounts.lidl.com", StringComparison.OrdinalIgnoreCase)
            || Page.Url.Contains("/login", StringComparison.OrdinalIgnoreCase);
    }

    /// <summary>Returns all visible recipe card locators.</summary>
    public ILocator GetRecipeCards() => RecipeCards;

    /// <summary>Waits until the recipe list is fully loaded.</summary>
    public async Task WaitForRecipesAsync()
    {
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);
    }
}
