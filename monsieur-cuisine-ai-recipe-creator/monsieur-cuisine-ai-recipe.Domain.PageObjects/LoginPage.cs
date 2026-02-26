using Microsoft.Playwright;

namespace monsieur_cuisine_ai_recipe.Domain.PageObjects.Pages;

/// <summary>
/// Represents the Lidl accounts login page used to authenticate into Monsieur Cuisine.
/// URL: https://accounts.lidl.com/Account/Login
/// </summary>
public class LoginPage : BasePage
{
    public override string Url => "https://accounts.lidl.com/Account/Login";

    private ILocator EmailInput => Page.Locator("input[name='Email'], input[type='email'], #Email");
    private ILocator PasswordInput => Page.Locator("input[name='Password'], input[type='password'], #Password");
    private ILocator SubmitButton => Page.Locator("button[type='submit'], input[type='submit']");

    public LoginPage(IPage page) : base(page) { }

    /// <summary>Returns true when the login form is visible on the current page.</summary>
    public async Task<bool> IsLoginFormVisibleAsync()
    {
        return await EmailInput.IsVisibleAsync();
    }

    /// <summary>Fills in credentials and submits the login form.</summary>
    public async Task LoginAsync(string username, string password)
    {
        await EmailInput.FillAsync(username);
        await PasswordInput.FillAsync(password);
        await SubmitButton.ClickAsync();
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);
    }
}
