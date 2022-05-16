using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public string Greeting()
        {
            List<string> greeting = new List<string>
            {
                "console.log(\"Hello, World!\");",
                "Console.WriteLine(\"Hello, World!\")",
                "std:cout<< \"Hello, World!\"",
                "System.out.println(\"Hello, World!\")",
                "echo \"Hello, World!\""
            };
            Random ran = new Random();
            int num = ran.Next(0, greeting.Count);
            return greeting[num];
        }
        public void OnGet()
        {

        }
    }
}