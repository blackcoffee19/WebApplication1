using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class FormSide : PageModel
    {
        [BindProperty]
        public string InputTitle {get;set;}
        [BindProperty]
        public bool Choose {get;set;}
        [BindProperty]
        public int InputMoney {get;set;}
        [BindProperty]
        public string InputReason {get;set;}
    }
}