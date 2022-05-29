using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class ListItem {
        public List<Item> listItem {get;set;}
        public ListItem(string name, string cost, string calo, string detail){
            listItem = new List<Item>();
        }
    }
}