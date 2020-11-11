using Pet_shop_online.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pet_shop_online.Controllers
{
    public class CategoriesController : Controller
    {
        private Models.AppContext db = new Models.AppContext();

        // GET: Categories
        public ActionResult Index()
        {
            var categories = db.Categories;
            ViewBag.Categories = categories;
            if (TempData.ContainsKey("message"))
            {
                ViewBag.Message = TempData["message"];
            }

            return View();
        }


        public ActionResult Show(int id)
        {
            Category category = db.Categories.Find(id);
            ViewBag.Category = category;
            return View();
        }

        public ActionResult New()
        {
            return View();
        }




        [HttpPost]
        public ActionResult New(Category category)
        {
            try
            {
                db.Categories.Add(category);
                db.SaveChanges();
                TempData["message"] = "Categoria a fost adaugata cu succes!";
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View(category);
            }
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            Category category = db.Categories.Find(id);
            return View(category);

        }

        [HttpPut]
        public ActionResult Edit(int id, Category requestCategory)
        {

            try
            {
                Category category = db.Categories.Find(id);
                if (TryUpdateModel(category))
                {
                    category = requestCategory;
                    db.SaveChanges();
                    TempData["message"] = "Categoria a fost modificata cu succes!";
                    return RedirectToAction("Index");
                }

                return View(requestCategory);
            }

            catch (Exception e)
            {
                return View();
            }


        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            Category category = db.Categories.Find(id);
            db.Categories.Remove(category);
            db.SaveChanges();
            TempData["message"] = "Categoria a fost eliminata!";
            return RedirectToAction("Index");
        }
    }
}