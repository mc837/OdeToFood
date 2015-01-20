using System.Collections.Generic;
using OdeToFood.Models;

namespace OdeToFood.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OdeToFood.Models.OdeToFoodDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(OdeToFood.Models.OdeToFoodDb context)
        {
           context.Restaurants.AddOrUpdate( r=>r.Name,
               new Restaurant{ Name = "Sabatinis", City = "New York", Country = "USA"},
               new Restaurant{ Name = "Noodles Delight", City = "Bangkok", Country = "Thailand"},
               new Restaurant
               {
                   Name = "Surf Shack",
                   City = "Sydney",
                   Country = "Australia",
                   Reviews = 
                   new List<RestaurantReview>
                   {
                       new RestaurantReview
                       {
                           Rating = 9,
                           Body = "The best food ever!",
                           ReviewerName = "Lewy"
                       }
                   }
               });
        }
    }
}
