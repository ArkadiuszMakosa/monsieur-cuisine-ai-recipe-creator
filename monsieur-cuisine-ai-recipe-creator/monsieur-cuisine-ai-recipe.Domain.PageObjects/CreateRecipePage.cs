using Microsoft.Playwright;

namespace monsieur_cuisine_ai_recipe.Domain.PageObjects.Pages;

/// <summary>
/// Represents the "Create Recipe" page on Monsieur Cuisine.
/// URL: https://www.monsieur-cuisine.com/pl/create-recipe?devices=mc-smart
/// </summary>
public class CreateRecipePage : BasePage
{
    public override string Url => "https://www.monsieur-cuisine.com/pl/create-recipe?devices=mc-smart";

    private ILocator RecipeNameInput => Page.Locator("input[name='recipeName'], #recipeName");
    private ILocator SaveButton => Page.Locator("button[type='submit'], button:has-text('Save'), button:has-text('Zapisz')");

    public CreateRecipePage(IPage page) : base(page) { }

    /// <summary>Returns true when the create recipe form is visible.</summary>
    public async Task<bool> IsCreateFormVisibleAsync()
    {
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);
        return await RecipeNameInput.IsVisibleAsync();
    }

    /// <summary>Fills the recipe name field.</summary>
    public async Task SetRecipeNameAsync(string name)
    {
        await RecipeNameInput.FillAsync(name);
    }

    /// <summary>Submits / saves the recipe form.</summary>
    public async Task SaveAsync()
    {
        await SaveButton.ClickAsync();
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);
    }
}
