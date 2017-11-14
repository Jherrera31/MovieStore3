using MovieStore3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MovieStore3.Controllers
{    
    public class MovieController : Controller
    {
        public readonly MoviesStoreContext _db;

        public MovieController()
        {
            _db = new MoviesStoreContext();
        }
        public ActionResult Index()
        {
            var movies = _db.Movies.ToList();
            
            return View(movies);
        }

        // GET: Movie/Details/5
        public ActionResult Details(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = _db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // GET: Movie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movie/Create
        [HttpPost]
        public ActionResult Create(Movie model)
        {
            try
            {
                var movie = new Movie
                {
                    Title = model.Title,
                    Rating = model.Rating,
                    Description = model.Description
                };

                _db.Movies.Add(movie);
                _db.SaveChanges();


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Edit/5
        public ActionResult Edit(int id)
        {
            Movie movie = _db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // POST: Movie/Edit/5
        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(movie).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        // GET: Movie/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = _db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }
        // POST: Movie/Delete/5
        [HttpPost]
        public ActionResult Delete(FormCollection fcNotUsed, int id = 0)
        {
            var movie = _db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            _db.Movies.Remove(movie);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
