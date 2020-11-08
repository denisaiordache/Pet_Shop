using Pet_shop_online.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pet_shop_online.Controllers
{
    public class CommentsController : Controller
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
            Comment comm = db.Comments.Find(id);
            db.Comments.Remove(comm);
            db.SaveChanges();
            return Redirect("/Products/Show/" + comm.ProductID);
        }

        [HttpPost]
        public ActionResult New(Comment comm)
        {
            comm.Date = DateTime.Now;
            try
            {
                db.Comments.Add(comm);
                db.SaveChanges();
                return Redirect("/Products/Show/" + comm.ProductID);
            }

            catch (Exception e)
            {
                return Redirect("/Products/Show/" + comm.ProductID);
            }

        }

        public ActionResult Edit(int id)
        {
            Comment comm = db.Comments.Find(id);
            
            return View(comm);
        }

        [HttpPut]
        public ActionResult Edit(int id, Comment requestComment)
        {
            try
            {
                Comment comm = db.Comments.Find(id);
                if (TryUpdateModel(comm))
                {
                    comm.Content = requestComment.Content;
                    db.SaveChanges();
                }
                return Redirect("/Products/Show/" + comm.ProductID);
            }
            catch (Exception e)
            {
                return View();
            }

        }
    }
}