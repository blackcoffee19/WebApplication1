using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class Portfolio : PageModel
    {
        public string? FullName { get; set; }
        public int? Age { get; set; }
        public int? Experients { get; set; }
        public List<Language>? languages { get; set; }
        public void OnGet()
        {
            FullName = "Black Coffee";
            Age = 22;
            Experients = 6;
            languages = new List<Language>
            {
                new Language("Java", 4, "Codecademy certificate"),
                new Language("JavaScript", 4, "Codecademy certificate"),
                new Language("C++", 2, "Codecademy certificate"),
                new Language("C#", 4, "Codecademy certificate"),
                new Language("SQL", 1, "Codecademy certificate"),
                new Language("HTML", 2, "Codecademy certificate"),
                new Language("CSS", 2, "Codecademy certificate")
            };
        }
    }

    public class Language
    {
        public string Name { get; set; }
        public int exper { get; set; }
        public string certificate { get; set; }
        public Language(string name, int exper, string certi = "none")
        {
            this.Name = name;
            this.exper = exper;
            this.certificate = certi;
        }
    }
}
