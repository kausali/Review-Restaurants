using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using RESTauranter.Models;
using System.Linq;

namespace RESTauranter.Controllers
{
    public class HomeController : Controller
    {
        private RestContext _context;
 
        public HomeController(RestContext context)
        {
            _context = context;
        }
 
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            // List<Review> AllReviews = _context.rest.ToList();
            ViewBag.errors = new List<string>();            
            return View();
        }
        [HttpGet]
        [Route("reviews")]
        public IActionResult Reviews()
        {
            List<Review> ReviewsByUsers = _context.rest.OrderByDescending(rest =>rest.date).ToList();
            ViewBag.All_Reviews = ReviewsByUsers;
            return View("Reviews");
        }
        [HttpPost]
        [Route("/process")]
        public IActionResult Process(Review newReview)
            {
                if(ModelState.IsValid){
                _context.Add(newReview);
                _context.SaveChanges();
                return RedirectToAction("Reviews");        
            }
                else
            {
                ViewBag.errors = ModelState.Values;
                return View("Index");
            }
        }
    }
}
