monsieur-cuisine-ai-recipe.Domain.Generator console application is for using Playwright nuget packages to open 
https://www.monsieur-cuisine.com/pl/moje-przepisy?section=all
and login if user is not logged in, by typeing username and password from application config. 

All pages mapping should be in separated file - 1 page - 1 class representation in monsieur-cuisine-ai-recipe.Domain.PageObjects in some structure. 


Goal is to map this pages:
- https://www.monsieur-cuisine.com/pl/moje-przepisy?section=all
- https://www.monsieur-cuisine.com/pl/create-recipe?devices=mc-smart
- https://accounts.lidl.com/Account/Login?ReturnUrl=%2Fconnect%2Fauthorize%2Fcallback%3Flanguage%3Dpl-PL%26country%3DPL%26response_type%3Dcode%26redirect_uri%3Dhttps%253A%252F%252Fwww.monsieur-cuisine.com%252Fsso%252Fpost%252Flogin%252Fredirect%252F%26client_id%3Dmonsieurcuisinewebcompanionclient%26nonce%3D623ae1d2558181fc1c0cc07e5c203aab%26state%3Dad67184af14696d7b35652f9483badec%26scope%3Dopenid%2520profile%2520openid#login
- https://accounts.lidl.com/Account/Login?ReturnUrl=%2Fconnect%2Fauthorize%2Fcallback%3Flanguage%3Dpl-PL%26country%3DPL%26response_type%3Dcode%26redirect_uri%3Dhttps%253A%252F%252Fwww.monsieur-cuisine.com%252Fsso%252Fpost%252Flogin%252Fredirect%252F%26client_id%3Dmonsieurcuisinewebcompanionclient%26nonce%3D623ae1d2558181fc1c0cc07e5c203aab%26state%3Dad67184af14696d7b35652f9483badec%26scope%3Dopenid%2520profile%2520openid#login


Goal is to:
- Create stepsToDo.md file with all required tasks to acomplish this task
- Start to implement all requirements step by step
- on every step mark task in stepsToDo.md file as done. 