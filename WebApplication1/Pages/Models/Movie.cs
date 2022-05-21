using System;
namespace WebApplication1.Models
{
    public class Movie{
        public string TitleMovie {get;set;}
        public double IMDb {get;set;}
        public string Cast {get;set;}
        public string Director {get;set;}
        public string Image{get;set;}
        public Movie(string titleMovie, double imdb, string cast, string director, string image){
            this.TitleMovie = titleMovie;
            this.IMDb = imdb;
            this.Cast = cast;
            this.Director = director; 
            this.Image = image;
        }

    }
}