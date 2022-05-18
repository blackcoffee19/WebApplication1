using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class ArchiveMode : PageModel
    {

    public List<ListTask> orderTask = new List<ListTask>{
            new ListTask("Learning C#"),
            new ListTask("Learning Java"),
            new ListTask("Learing C++"),
            new ListTask("Learning JavaScript"),
            new ListTask("Learning SQL")
        };
    public ListTask? Displayed {get;set;}
    public void OnGet(int index)
    {
        Displayed = orderTask[0];
        if(index >= orderTask.Count || index <0){
            
        } else {
            Displayed = orderTask[index];
        }
    }

    }
}