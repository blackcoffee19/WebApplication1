using System;
namespace WebApplication1.Models
{
    public class Daily{
        public string TitleD {get;set;}
        public int Cost {get;set;}
        public string Reason {get;set;}
        public Daily(string titleD, int cost, string reason){
            this.TitleD = titleD;
            this.Cost = cost;
            this.Reason = reason; 
        }


    }
}