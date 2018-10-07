using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Aravinda Samitha"};
            return View(movie);
            //Test Commit 2
            //        return Content("Hello World");
            //        return HttpNotFound();
            //        return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "Name" });
            

        }

        public ActionResult Edit(int id) => Content("id=" + id);

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name ";
            }

            return Content(String.Format("PageIndex = {0}, SortBy = {1}", pageIndex, sortBy));
        }
    }
}