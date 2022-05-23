using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class ProjectsModel : PageModel
    {
        public List<Project>? GetProject {get;set;}
        public async Task<IActionResult> OnGet(){
            GetProject = ProjectList.ListProjects();
            using (StreamWriter writer = new StreamWriter("log.txt",append:true)){
                await writer.WriteLineAsync($"Client visit recorded at{DateTime.Now}");
                return Page();
            }
        }
    }
}