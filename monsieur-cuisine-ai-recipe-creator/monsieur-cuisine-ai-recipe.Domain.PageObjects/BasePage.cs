using Microsoft.Playwright;

namespace monsieur_cuisine_ai_recipe.Domain.PageObjects.Pages;

public abstract class BasePage
{
    protected readonly IPage Page;

    protected BasePage(IPage page)
    {
        Page = page;
    }

    public abstract string Url { get; }

    public async Task NavigateAsync()
    {
        await Page.GotoAsync(Url);
    }
}
