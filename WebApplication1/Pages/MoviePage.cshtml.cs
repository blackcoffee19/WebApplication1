using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class MoviePage : PageModel
    {
        public List<Movie> list {get;set;}
        public void OnGet(){
            list = ListMovie.ToList();
        }
    }
}