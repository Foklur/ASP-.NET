using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesTasks.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public char RandLetter { get; set; }
        public string ShowYear() {
            return $"Now {DateTime.Now.Year} year";
        }
        public void OnGet()
        {
            Random random = new Random();
            int randNum = random.Next(1, 26);
            RandLetter = (char)('A' + randNum);
        }
    }
}
