document.addEventListener('DOMContentLoaded', () => {
    const quoteEl = document.getElementById('quote');
    const authorEl = document.getElementById('author');
    const generateBtn = document.getElementById('generateBtn');
    const refreshBtn = document.getElementById('refreshBtn');
    const copyBtn = document.getElementById('copyBtn');

    async function fetchQuote() {
        try {
            quoteEl.textContent = "Loading...";
            const response = await fetch('/Quote/GetQuote'); // matches controller/action
            if (!response.ok) throw new Error('Network response was not ok');

            const data = await response.json();
            quoteEl.textContent = data.text;
            authorEl.textContent = `- ${data.author}`;
        } catch (err) {
            quoteEl.textContent = "Could not fetch quote. Try again.";
            console.error(err);
        }
    }

    generateBtn.addEventListener('click', fetchQuote);
    refreshBtn.addEventListener('click', fetchQuote); // same action, reused

    copyBtn.addEventListener('click', () => {
        const text = `${quoteEl.textContent} ${authorEl.textContent}`;
        navigator.clipboard.writeText(text)
            .then(() => {
                copyBtn.textContent = "Copied!";
                setTimeout(() => copyBtn.textContent = "copy quote", 1500);
            })
            .catch(err => console.error('Copy failed', err));
    });
});