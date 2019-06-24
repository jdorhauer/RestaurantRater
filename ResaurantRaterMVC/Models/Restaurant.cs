using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ResaurantRaterMVC.Models
{
    public class Restaurant
    {
        public int RestaurantID { get; set; }
        public string Name { get; set; }
        public string FoodType { get; set; }
        public double Rating { get; set; }
    }

    public class RestaurantDbContent : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}