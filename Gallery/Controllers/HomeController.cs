using Gallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Gallery.Controllers
{
    public class HomeController : Controller
    {
        PhotoDBcontext db = new PhotoDBcontext();

        public ActionResult Index(int placesid=1) 
        {
            var places = db.place.ToList();
            Session["places"] = places;

            var photos = db.photo.Where(p => p.placeID == placesid);
            return View("Index",photos);
        }
    }
}
