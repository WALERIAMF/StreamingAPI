using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreamingAPI.Controllers
{
    public class SeriaController : Controller
    {
        // GET: SeriaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SeriaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SeriaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SeriaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SeriaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SeriaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SeriaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SeriaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
