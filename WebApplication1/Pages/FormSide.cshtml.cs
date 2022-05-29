using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;
namespace WebApplication1.Pages
{
    public class FormSide : PageModel
    {
        [BindProperty]
        public string InputName {get;set;}
        [BindProperty]
        public string InputMoney {get;set;}
        [BindProperty]
        public string Calo {get;set;}
        [BindProperty]
        public string Details {get;set;}

        public string RequestMethod
        { get; set; }

        public string RequestValues
        { get; set; }
        public List<Item> listItem {get;set;}

        public async Task OnGetAsync() {
            listItem = new List<Item>();
            RequestMethod = "GET";
            RequestValues = "n/a";
            InputName = "Apple";
            InputMoney = "23.000";
            Calo ="21";
            Details ="Apples is a heathy fruit";
            //listItem.Add(new Item(InputName,InputMoney,Calo,Details));
            using (StreamWriter writer = new StreamWriter("log.txt", append: true))
            {
                await writer.WriteLineAsync($"OnGetAsync() called at {DateTime.Now}.");
            }
        }
        public async Task OnPostAsync(){
            RequestMethod = "POST";
            RequestValues = GetFormValues();
            //listItem.Add(new Item(InputName,InputMoney,Calo,Details));
            using (StreamWriter writer = new StreamWriter("log.txt", append: true))
            {
              await writer.WriteLineAsync($"OnPostAsync() called at {DateTime.Now}.");
            }
        }
        private string GetFormValues(bool ignoreRequestVerificationToken = true)
        {
            string formData = "";
            string separator = " | ";

            foreach (var pair in this.Request.Form)
            {   
              if (ignoreRequestVerificationToken && pair.Key == "__RequestVerificationToken")
              {     
                continue;   
              }     
              else      
              {     
                formData += pair.Key + ":    " + Request.Form[pair.Key] + separator;
              }
            }

            if (formData.EndsWith(separator))
            {
              formData = formData.Substring(0, formData.Length - separator.Length);
            }
            return formData;
        }
    }
}