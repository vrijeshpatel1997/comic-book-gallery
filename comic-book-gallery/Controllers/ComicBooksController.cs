﻿using comic_book_gallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;

namespace comic_book_gallery.Controllers
{
    public class ComicBooksController : Controller
    {

        public ActionResult Detail()
        {

            ComicBook comic = new ComicBook() {
                SeriesTitle = "The amazibg spiderman",
                IssueNumber = 700,
                DescriptionHTML = "<p> Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {

                    new Artist () { Name = "Dan Slott", Role = " Script"},
                      new Artist () { Name = "Humberto Ramos", Role = "Pencils"},
                        new Artist () { Name = "Victor Olazaba", Role = "Inks"},
                          new Artist () { Name = "Edgar Delgado", Role = "Colors"},
                            new Artist () { Name = "Chris Eliopoulos", Role = "Letters"},
                }



            };


          

     

            return View(comic);


        }
    }
}
   