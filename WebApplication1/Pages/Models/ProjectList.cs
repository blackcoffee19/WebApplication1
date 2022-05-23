using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public static class ProjectList {
        public static List<Project> ListProjects() {
            return new List<Project> {
                new Project("MoviePage", "A website watch movie online, created by me and using Boostrap 4, ASP.NET to made it","/MoviePage",""),
                new Project("Login and Regiset Form","Created by ASP.NET, clients can regiest and login", "/LoginSide","")
            };
            }
    }
}