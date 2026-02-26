using Microsoft.Extensions.Configuration;
using Microsoft.Playwright;
using monsieur_cuisine_ai_recipe.Domain.PageObjects.Pages;

namespace ConsoleApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            var username = config["MonsieurCuisine:Username"]
                ?? throw new InvalidOperationException("MonsieurCuisine:Username is not configured in appsettings.json.");
            var password = config["MonsieurCuisine:Password"]
                ?? throw new InvalidOperationException("MonsieurCuisine:Password is not configured in appsettings.json.");

            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });

            var page = await browser.NewPageAsync();

            // Navigate to My Recipes page
            var myRecipesPage = new MyRecipesPage(page);
            await myRecipesPage.NavigateAsync();
            await myRecipesPage.WaitForRecipesAsync();

            // If redirected to login, authenticate first
            if (myRecipesPage.IsLoginRequired())
            {
                Console.WriteLine("User is not logged in. Performing login...");

                var loginPage = new LoginPage(page);
                await loginPage.LoginAsync(username, password);

                Console.WriteLine("Login submitted. Navigating back to My Recipes...");
                await myRecipesPage.NavigateAsync();
                await myRecipesPage.WaitForRecipesAsync();
            }

            Console.WriteLine($"Current page: {page.Url}");
            Console.WriteLine("Done. Press any key to exit.");
            Console.ReadKey();
        }
    }
}

