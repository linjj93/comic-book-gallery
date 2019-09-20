using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octoupus' life and his one, last, great act of revenge! Even if Spider-Man survives... <b>will Peter Parker</b>?</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Script"},
                    new Artist() {Name = "Humberto Ramos", Role = "Pencils"},
                    new Artist() {Name = "Victor Olazaba", Role = "Inks"},
                    new Artist() {Name = "Edgar Delgado", Role = "Colors"},
                    new Artist() {Name = "Chris Eliopoulos", Role = "Letters"},
                }

            };
            

            return View(comicBook);
            
        }
    }
}