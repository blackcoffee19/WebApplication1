using System;
namespace WebApplication1.Models
{
    public class ListTask
    {
        public string Title{get;set;}
        public string Mission {get;set;}
        public ListTask(string title){
            this.Title = title;
            if(title.Contains("C#")){
                this.Mission = $"To {this.Title} you need to go Codecademy and try to learn at least 2 lessons, or make some projects.";
            } else if(title.Contains("Java")){
                this.Mission = $"To {this.Title} you should go to GoogleDrive and practise more exercises.";
            } else if(title.Contains("C++")){
                this.Mission = $"To {this.Title} you can go to Codecademy to review all lessons and you should go to GoogleDrive and practise more exercises.";
            } else if(title.Contains("SQL")){
                this.Mission = $"To {this.Title} you can go to Codecademy to review all lessons then you should create more tables or trying add more columns and rows.";
            } else if(title.Contains("JavaScript")){
                this.Mission = $"To {this.Title} you can go to Codecademy to review all lessons then you should practise more exercise related to JS.";
            } else {
                this.Mission = $"To {this.Title} you can learn at least 2 lessons in Codecademy.";
            }
        }        
    }
}