﻿//using System.Collections.Generic;
//using System.Linq;
//using System.Web.Mvc;
//using OdeToFood.Models;
//
//namespace OdeToFood.Controllers
//{
//    public class ReviewsController : Controller
//    {
//        //
//        // GET: /Reviews/
//        [ChildActionOnly]
//        public ActionResult BestReview()
//        {
//            var bestReview = from r in _reviews
//                orderby r.Rating descending
//                select r;
//
//            return PartialView("_Review", bestReview.First());
//        }
//
//        public ActionResult Index()
//        {
//            var model =
//                from r in _reviews
//                orderby r.Country
//                select r;
//
//            return View(model);
//        }
//
//        //
//        // GET: /Reviews/Details/5
//
//        public ActionResult Details(int id)
//        {
//            return View();
//        }
//
//        //
//        // GET: /Reviews/Create
//
//        public ActionResult Create()
//        {
//            return View();
//        }
//
//        //
//        // POST: /Reviews/Create
//
//        [HttpPost]
//        public ActionResult Create(FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add insert logic here
//
//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }
//
//        //
//        // GET: /Reviews/Edit/5
//
//        public ActionResult Edit(int id)
//        {
//            var review = _reviews.Single(r => r.Id == id);
//            return View(review);
//        }
//
//        //
//        // POST: /Reviews/Edit/5
//
//        [HttpPost]
//        public ActionResult Edit(int id, FormCollection collection)
//        {
//            var review = _reviews.Single(r => r.Id == id);
//            if (TryUpdateModel(review))
//            {
//                //..
//                return RedirectToAction("Index");
//            }
//            return View(review);
//        }
//
//        //
//        // GET: /Reviews/Delete/5
//
//        public ActionResult Delete(int id)
//        {
//            return View();
//        }
//
//        //
//        // POST: /Reviews/Delete/5
//
//        [HttpPost]
//        public ActionResult Delete(int id, FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add delete logic here
//
//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }
//
//        static List<RestaurantReview> _reviews = new List<RestaurantReview>
//        {
//            new RestaurantReview
//            {
//                Id = 1,
//                Name = "Bobs Rib Shack",
//                City = "London",
//                Country ="UK",
//                Rating = 10
//            },
//
//            new RestaurantReview
//            {
//                Id = 2,
//                Name = "Daves Thai Suprise",
//                City = "Bangkok",
//                Country ="Thailand",
//                Rating = 9
//            },
//
//            new RestaurantReview
//            {
//                Id = 3,
//                Name = "Sammy's Surf 'n' Turf",
//                City = "Sydney",
//                Country ="Australia",
//                Rating = 10
//            },
//            
//            new RestaurantReview
//            {
//                Id = 4,
//                Name = "Sergei's Delights",
//                City = "Moscow",
//                Country ="Russia",
//                Rating = 9
//            },
//
//            new RestaurantReview
//            {
//                Id = 2,
//                Name = "Ask Restaurant",
//                City = "Peterborough",
//                Country ="UK",
//                Rating = 8
//            }
//        };
//    }
//}
