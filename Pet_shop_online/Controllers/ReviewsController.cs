using Pet_shop_online.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pet_shop_online.Controllers
{
    public class ReviewsController : Controller
    {
        private Models.AppContext db = new Models.AppContext();

        // GET: Comments
        public ActionResult Index()
        {
            return View();
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            Review rev = db.Reviews.Find(id);
            db.Reviews.Remove(rev);
            db.SaveChanges();
            return Redirect("/Products/Show/" + rev.ProductID);
        }

        [HttpPost]
        public ActionResult New(Review rev)
        {
            rev.Date = DateTime.Now;
            rev.UserID = 2; //Momentan - pana facem partea de autentificare 


            try
            {
                db.Reviews.Add(rev);
                db.SaveChanges();
                return Redirect("/Products/Show/" + rev.ProductID);
            }

            catch (Exception e)
            {
                return Redirect("/Products/Show/" + rev.ProductID);
            }

        }

        public ActionResult Edit(int id)
        {
            Review rev = db.Reviews.Find(id);
            
            return View(rev);
        }

        [HttpPut]
        public ActionResult Edit(int id, Review requestReview)
        {
            try
            {
                Review rev = db.Reviews.Find(id);
                if (TryUpdateModel(rev))
                {
                    rev.Content = requestReview.Content;
                    db.SaveChanges();
                }
                return Redirect("/Products/Show/" + rev.ProductID);
            }
            catch (Exception e)
            {
                return View();
            }

        }
    }
}