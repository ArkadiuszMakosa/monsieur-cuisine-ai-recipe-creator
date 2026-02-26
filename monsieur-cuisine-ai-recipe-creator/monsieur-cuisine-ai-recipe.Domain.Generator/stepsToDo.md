# Steps To Do

## Setup
- [x] Create stepsToDo.md file
- [x] Add Playwright NuGet package to PageObjects project
- [x] Add Playwright NuGet package and config packages to Generator project
- [x] Add PageObjects project reference to Generator project

## Page Objects (monsieur-cuisine-ai-recipe.Domain.PageObjects)
- [x] Create BasePage.cs – base class wrapping IPage
- [x] Create LoginPage.cs – Lidl login page (accounts.lidl.com)
- [x] Create MyRecipesPage.cs – My Recipes page (moje-przepisy)
- [x] Create CreateRecipePage.cs – Create Recipe page

## Generator Console App
- [x] Add appsettings.json with Username/Password config
- [x] Implement Program.cs – launch Playwright, open MyRecipes, detect login state, auto-login if needed

## Validation
- [ ] Build solution successfully
