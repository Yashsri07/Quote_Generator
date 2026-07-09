Random Quote Generator

A simple web application built with ASP.NET Core MVC that generates random inspirational quotes at the click of a button. Users can generate a new quote, refresh it, or copy it to their clipboard.

Deployed Link :- https://quote-generator-1-7td9.onrender.com

Features


🎲 Generate a random quote from a curated list
🔄 Refresh to get a new quote instantly
📋 Copy the current quote and author to clipboard
🎨 Clean, responsive UI with smooth animations
⚡ Fast, lightweight — no external quote APIs required


Tech Stack


Backend: ASP.NET Core MVC (.NET 10)
Frontend: HTML5, CSS3, Vanilla JavaScript (fetch() API)
Font: Poppins via Google Fonts


Project Structure

QuoteGenerator/
├── Controllers/
│   ├── HomeController.cs
│   └── QuoteController.cs      # Serves random quotes as JSON
├── Models/
│   └── Quote.cs                # Quote model (Text, Author)
├── Views/
│   └── Home/
│       └── Index.cshtml        # Main UI
├── wwwroot/
│   ├── css/
│   │   └── site.css
│   └── js/
│       └── site.js             # Handles fetch() calls & UI updates
├── Dockerfile
└── README.md

Getting Started

Prerequisites


.NET SDK 10.0 or later
Visual Studio 2022 / VS Code (optional but recommended)


Run Locally


Clone the repository


bash   git clone https://github.com/<your-username>/QuoteGenerator.git
   cd QuoteGenerator


Restore dependencies


bash   dotnet restore


Run the application


bash   dotnet run


Open your browser and navigate to the URL shown in the terminal (e.g. https://localhost:5001)


How It Works


The user clicks Generate Quote or Refresh Quote.
JavaScript (site.js) sends a fetch() request to /Quote/GetQuote.
QuoteController picks a random quote from an in-memory list and returns it as JSON.
The page updates the quote and author without a full page reload.
Copy Quote copies the current quote text to the clipboard using the Clipboard API.


Deployment

This project includes a Dockerfile and is ready to deploy on platforms that support Docker-based deployments, such as Render:


Push your code to GitHub.
Create a new Web Service on Render.
Connect your GitHub repository.
Select Docker as the environment — Render will automatically detect and use the included Dockerfile.
Deploy — Render will provide a live URL once the build completes.


Future Improvements


 Fetch quotes from an external quotes API
 Add category/tag-based quote filtering
 Add a "favorite quotes" feature with local storage/database
 Add unit tests for the controller logic


License

This project is open source and available under the MIT License.
