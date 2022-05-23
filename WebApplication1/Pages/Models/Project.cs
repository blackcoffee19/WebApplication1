using System;

namespace WebApplication1.Models
{public class Project{
    public string nameProject {get; set;}
    public string Description {get;set;}
    public string linkPage {get;set;}
    public string ImgPage {get;set;}
    public Project(string name, string des, string link, string img) {
        this.nameProject = name;
        this.Description = des;
        this.linkPage = link;
        this.ImgPage = img;
    }
}}