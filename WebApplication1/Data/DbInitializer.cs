using WebApplication1.Models;
using System.Linq;
using System;

namespace WebApplication1.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DataContext context) {
            //The context EnsureCreated() method to make sure the database file exists
            context.Database.EnsureCreated();
            //uses LINQ to check for the existence of any Items. If they exist, the sample data does not need creation so the method ends
            if(context.Items.Any()){
                return;
            }
            //Create arrays Item obj. The context then uses Add() to include them in the DbSet for associated List
            var Items = new Item[]{
                new Item{Name="Milk",Cost="38.000",Calories="130 kCal",Detail="Almond Soymilk"},
                new Item{Name="Coffee",Cost="39.000",Calories="2.55 kCal",Detail="Black Coffee no sugar"},
                new Item{Name="Cookie",Cost="34.000",Calories="200 kCal",Detail="Guttask"},
                new Item{Name="Eggs",Cost="5.000",Calories="155.1 kCal",Detail="Eggs boiled"},
            };
            foreach (Item itemX in Items){
                context.Items.Add(itemX);
            }
            //SaveChanges() which persists the new data items into the database file
            context.SaveChanges();
        }
    }
}