using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using RESTauranter.Models;
using System.Linq;

namespace RESTauranter.Controllers
{
    public class HomeController : Controller
    {

        private RESTContext _context;
 
        public HomeController(RESTContext context)
        {
            _context = context;
        }

        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("process")]
        public IActionResult Process(Review review)
        {
            if(ModelState.IsValid) {
                Review newReview = new Review
                {
                    ReviewerName = review.ReviewerName,
                    RestaurantName = review.RestaurantName,
                    ReviewText = review.ReviewText,
                    Stars = review.Stars,
                    DateOfVisit = review.DateOfVisit,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };

                _context.Add(newReview);
                _context.SaveChanges();
            }

            return RedirectToAction("Reviews");
        }

        [HttpGet]
        [Route("reviews")]
        public IActionResult Reviews()
        {
            ViewBag.Reviews = _context.Reviews.ToList();
            return View();
        }
    }
}
