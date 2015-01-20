﻿using System.Linq;
using System.Security.Cryptography;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        OdeToFoodDb _db = new OdeToFoodDb();

        public ActionResult Index( string searchTerm = null)
        {
            //var model = _db.Restaurants.ToList();

//            var model = from r in _db.Restaurants
//                orderby r.Reviews.Average(review => review.Rating) descending 
//                select new RestaurantListViewModel()
//                {
//                    Id = r.Id,
//                    Name = r.Name,
//                    City =  r.City,
//                    Country = r.Country,
//                    CountOfReviews = r.Reviews.Count()
//                };
//

            var model = _db.Restaurants
                .OrderByDescending(r => r.Reviews.Average(review => review.Rating))
                .Where(r => searchTerm == null || r.Name.StartsWith(searchTerm))
                .Take(10)
                .Select(r => new RestaurantListViewModel()
                {
                    Id = r.Id,
                    Name = r.Name,
                    City = r.City,
                    Country = r.Country,
                    CountOfReviews = r.Reviews.Count()
                });
       
            return View(model);
        }

    


        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);

        }
    }
}
