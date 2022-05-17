using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        protected readonly ILogger<IndexModel> _logger;

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
            int num = RandomIndex(greeting.Count);
            return greeting[num];
        }
        public int RandomIndex(int maxi) {
            Random ran = new Random();
            int num = ran.Next(0, maxi);
            return num;
        }
        public void OnGet()
        {   
        }
    }
    public class Task
    {
        public string Title{get;set;}
        public string Mission {get;set;}
        public Task(string title){
            this.Title = title;
            if(title.Contains("C#")){
                this.Mission = $"To {this.Title} you need to go Codecademy and try to learn at least 2 lessons, or make some projects.";
            } else if(title.Contains("Java")){
                this.Mission = $"To {this.Title} you should go to GoogleDrive and practise more exercises.";
            } else if(title.Contains("C++")){
                this.Mission = $"To {this.Title} you can go to Codecademy to review all lessons and you should go to GoogleDrive and practise more exercises.";
            } else if(title.Contains("SQL")){
                this.Mission = $"To {this.Title} you can go to Codecademy to review all lessons then you should create more tables or trying add more columns and rows.";
            } else if(title.Contains("JavaScript")){
                this.Mission = $"To {this.Title} you can go to Codecademy to review all lessons then you should practise more exercise related to JS.";
            } else {
                this.Mission = $"To {this.Title} you can learn at least 2 lessons in Codecademy.";
            }
        }        
    }
}