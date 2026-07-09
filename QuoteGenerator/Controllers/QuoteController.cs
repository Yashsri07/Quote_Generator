using Microsoft.AspNetCore.Mvc;
using RandomQuoteApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace RandomQuoteApp.Controllers
{
    public class QuoteController : Controller
    {
        private static readonly List<Quote> _quotes = new List<Quote>
        {
            new Quote { Text = "The only way to do great work is to love what you do.", Author = "Steve Jobs" },
            new Quote { Text = "Life is what happens when you're busy making other plans.", Author = "John Lennon" },
            new Quote { Text = "In the middle of difficulty lies opportunity.", Author = "Albert Einstein" },
            new Quote { Text = "Success is not final, failure is not fatal.", Author = "Winston Churchill" },
            new Quote { Text = "Believe you can and you're halfway there.", Author = "Theodore Roosevelt" },
            new Quote { Text = "The future belongs to those who believe in the beauty of their dreams.", Author = "Eleanor Roosevelt" },
            new Quote { Text = "It does not matter how slowly you go as long as you do not stop.", Author = "Confucius" },
            new Quote { Text = "Everything you've ever wanted is on the other side of fear.", Author = "George Addair" },
            new Quote { Text = "Hardships often prepare ordinary people for an extraordinary destiny.", Author = "C.S. Lewis" },
            new Quote { Text = "You miss 100% of the shots you don't take.", Author = "Wayne Gretzky" },
            new Quote { Text = "Whether you think you can or you think you can't, you're right.", Author = "Henry Ford" },
            new Quote { Text = "The only impossible journey is the one you never begin.", Author = "Tony Robbins" },
            new Quote { Text = "Do not wait to strike till the iron is hot, but make it hot by striking.", Author = "William Butler Yeats" },
            new Quote { Text = "Act as if what you do makes a difference. It does.", Author = "William James" },
            new Quote { Text = "Success usually comes to those who are too busy to be looking for it.", Author = "Henry David Thoreau" },
            new Quote { Text = "The best time to plant a tree was 20 years ago. The second best time is now.", Author = "Chinese Proverb" },
            new Quote { Text = "Your time is limited, so don't waste it living someone else's life.", Author = "Steve Jobs" },
            new Quote { Text = "The way to get started is to quit talking and begin doing.", Author = "Walt Disney" },
            new Quote { Text = "Don't let yesterday take up too much of today.", Author = "Will Rogers" },
            new Quote { Text = "It's not whether you get knocked down, it's whether you get up.", Author = "Vince Lombardi" },
            new Quote { Text = "If you are working on something exciting, it will keep you motivated.", Author = "Steve Jobs" },
            new Quote { Text = "People who are crazy enough to think they can change the world usually do.", Author = "Rob Siltanen" },
            new Quote { Text = "Failure will never overtake me if my determination to succeed is strong enough.", Author = "Og Mandino" },
            new Quote { Text = "We may encounter many defeats but we must not be defeated.", Author = "Maya Angelou" },
            new Quote { Text = "Knowing is not enough, we must apply. Willing is not enough, we must do.", Author = "Johann Wolfgang von Goethe" }
        };

        // Renders the page (Views/Quote/Index.cshtml)
        public IActionResult Index()
        {
            return View();
        }

        // Called via fetch() from JS
        [HttpGet]
        public IActionResult GetQuote()
        {
            var random = new System.Random();
            var quote = _quotes[random.Next(_quotes.Count)];
            return Json(quote); // serializes {text, author} as JSON
        }
    }
}