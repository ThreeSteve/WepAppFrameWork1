using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspnet_get_started.Controllers
{
    public class Publications_2001_Controller : Controller
    {
        // GET: Publications_2001_
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "18:37 McClaren Publications";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "18:37 McClaren Contact";

            return View();
        }

        // GET: Publications_2001_/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Publications_2001_/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Publications_2001_/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Publications_2001_/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Publications_2001_/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Publications_2001_/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Publications_2001_/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
