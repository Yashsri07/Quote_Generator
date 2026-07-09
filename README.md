# Random Quote Generator

A simple web application built with **ASP.NET Core MVC** that generates random inspirational quotes at the click of a button. Users can generate a new quote, refresh it, or copy it to their clipboard.

deployed link:- https://quote-generator-1-7td9.onrender.com

## Features

- 🎲 Generate a random quote from a curated list
- 🔄 Refresh to get a new quote instantly
- 📋 Copy the current quote and author to clipboard
- 🎨 Clean, responsive UI with smooth animations
- ⚡ Fast, lightweight — no external quote APIs required

## Tech Stack

- **Backend:** ASP.NET Core MVC (.NET 10)
- **Frontend:** HTML5, CSS3, Vanilla JavaScript (`fetch()` API)
- **Font:** [Poppins](https://fonts.google.com/specimen/Poppins) via Google Fonts

## Project Structure

```
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
```

## Getting Started

### Prerequisites

- [.NET SDK 10.0](https://dotnet.microsoft.com/download) or later
- Visual Studio 2022 / VS Code (optional but recommended)

### Run Locally

1. Clone the repository
   ```bash
   git clone https://github.com/<your-username>/QuoteGenerator.git
   cd QuoteGenerator
   ```

2. Restore dependencies
   ```bash
   dotnet restore
   ```

3. Run the application
   ```bash
   dotnet run
   ```

4. Open your browser and navigate to the URL shown in the terminal (e.g. `https://localhost:5001`)

## How It Works

1. The user clicks **Generate Quote** or **Refresh Quote**.
2. JavaScript (`site.js`) sends a `fetch()` request to `/Quote/GetQuote`.
3. `QuoteController` picks a random quote from an in-memory list and returns it as JSON.
4. The page updates the quote and author without a full page reload.
5. **Copy Quote** copies the current quote text to the clipboard using the Clipboard API.


## License

This project is open source and available under the [MIT License](LICENSE).
