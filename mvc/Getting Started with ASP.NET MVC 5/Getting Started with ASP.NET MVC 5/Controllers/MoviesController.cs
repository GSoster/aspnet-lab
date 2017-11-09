using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Getting_Started_with_ASP.NET_MVC_5.Models;

namespace Getting_Started_with_ASP.NET_MVC_5.Controllers
{
    public class MoviesController : Controller
    {
        private MovieDBContext db = new MovieDBContext();

        // GET: Movies
        // ID is used to search like this: Movies/index/ghost
        // instead of Movies?searchString=ghost
        //it follows the App_Start\RouteConfig.cs file pattern
        public ActionResult Index(string movieGenre, string searchString)
        {
            //get all the genres from the database (but not duplicate them)
            var GenreList = new List<String>();
            var GenreQry = from d in db.Movies
                           orderby d.Genre
                           select d.Genre;

            GenreList.AddRange(GenreQry.Distinct());
            //allows to access the data (genres) as a dropdown listbox
            ViewBag.movieGenre = new SelectList(GenreList);
            //If we wanted "Comedy" as default option: 
            //ViewBag.movieGenre = new SelectList(GenreLst, "Comedy");

            var movies = from m in db.Movies select m;

            if (!string.IsNullOrEmpty(searchString))            
                movies = movies.Where(s => s.Title.Contains(searchString));


            if (!string.IsNullOrEmpty(movieGenre))
                movies = movies.Where(x => x.Genre == movieGenre);

            return View(movies);
        }

        // GET: Movies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // GET: Movies/Create
        // displays the initial Create form
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // handles the form post.
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        // The ModelState.IsValid check whether the movie has any validation errors
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,ReleaseDate,Genre,Price, Rating")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Movies.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movie);
        }

        // GET: Movies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost] //This attribute specifies that the overload of the Edit method can be invoked only for POST requests.
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,ReleaseDate,Genre,Price, Rating")] Movie movie)
        {
            // The ModelState.IsValid method verifies that the data submitted in the form can be used to modify (edit or update) a Movie object
            if (ModelState.IsValid)
            {
                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        // GET: Movies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Movie movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        //teste only
        /// Movies/upfaz/asdasd
        public string UpFaz(string id)
        {
            string name = id;
            if (string.IsNullOrEmpty(name))
                return "Veio vazio!";
            else
                return "Veio cheio + " + name;            
        }

    }
}
