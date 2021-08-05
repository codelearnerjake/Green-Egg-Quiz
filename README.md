# Green-Egg-Quiz

Project: 

Create a three question quiz on mountains trivia that will give feedback to the user on when answers are submitted to check. 

Description of Solution: 

This project was built in .NET 5.0 with an MVC architecture and Microsoft entity framework connected with Microsoft SQL database. 
The quiz data is retrieved on initial load, then when answers are to be checked, an ajax call is made to the controller to retrieve the answers without reloading the page. 
This project is full stack with both JavaScript and .NET 5.0 Razor pages being utilized for data retrieval. The Razor page allows for a quick initial load time, while the asynchronous retrieval by JavaScript prevents needless page reload. While the code is simple, it may have been preferable to retrieve only a key pair of question ids and solution numbers as all the question data is retrieved through the JavaScript call to check the answers. This solution has many unnecessary packages given that it is built in the .NET Framework for a very simple website: a different solution with a smaller footprint would likely be preferable.  The questions are only selectable by radio buttons, it would have been preferable to have the answer selectable by clicking the text as well. 

Run Project Locally:

Install Visual Studios 2019 and include the ASP.Net and web development add on
Clone repository from https://github.com/codelearnerjake/Green-Egg-Quiz.git
Create local sql server: “QuestionsAndAnswersDB” 
Open the Package Manager Console window and type in “Update-Database”
Click the “IIS Express” run button at the top to launch local solution

Hosted Address: 

https://greeneggquiz.azurewebsites.net/
