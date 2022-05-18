using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;
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

        public List<ListTask> orderTask = new List<ListTask>{
            new ListTask("Learning C#"),
            new ListTask("Learning Java"),
            new ListTask("Learing C++"),
            new ListTask("Learning JavaScript"),
            new ListTask("Learning SQL")
        };
        public List<ListTask>? choose {get;set;}
        public ListTask? Display {get;set;}
        public void OnGet()
        {
            choose = new List<ListTask>();
            while(choose.Count <=3){
                int ran = RandomIndex(orderTask.Count);
                choose.Add(orderTask[ran]);
            };
        }

    }
}