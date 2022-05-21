using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public static class ListMovie{
        public static List<Movie> ToList() { 
          return new List<Movie> {
              new Movie("The Haunting of Hill House", 8.6, "Michiel Huisman, Carla Gugino, Henry Thomas, Elizabeth Reaser","Mike Flanagan","https://kenh14cdn.com/2018/10/30/2-15408757096151063293758.jpg"),
              new Movie("The Queen's Gambit", 8.6, "Anya Taylor-Joy,Bill Camp,Moses Ingram,Isla Johnston","Scott Frank","https://thegioidienanh.vn/stores/news_dataimages/phuongha/122020/23/11/1628_Poster_phim_The_Queens_Gambit.jpg"),
              new Movie("Split 2016", 7.4, "James McAvoy, Anya Taylor-Joy, Betty Buckley, Haley Lu Richardson","M. Night Shyamalan","https://www.avoir-alire.com/IMG/arton34323.jpg"),
              new Movie("What Happened to Monday", 6.8, "Noomi Rapace, Glenn Close, Willem Dafoe, Marwan Kenzari","Tommy Wirkola","https://i.pinimg.com/474x/14/aa/34/14aa347e8083c3b04c5d40cfe66bff77.jpg"),
              new Movie("Logan",8.1,"James Mangold","Hugh Jackman, Patrick Stewart, Dafne Keen, Boyd Holbrook","https://vuonbachhop.files.wordpress.com/2017/03/cxqaayzwiaab2l4.jpg")
            };
        }

    }   
}