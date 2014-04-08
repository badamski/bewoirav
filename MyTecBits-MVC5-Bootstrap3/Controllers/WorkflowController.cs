using MyTecBits_MVC5_Bootstrap3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyTecBits_MVC5_Bootstrap3.Controllers
{
    public class WorkflowController : Controller
    {
        private TestDataSource _dataSource;

        public WorkflowController()
        {
            _dataSource = new TestDataSource();
        }
        //
        // GET: /Workflow/
        public ActionResult Index()
        {
            var result = _dataSource.GetCommands();

            return View(result);
        }

        //
        // GET: /Workflow/Details/5
        public ActionResult Details(int id)
        {
            var result = _dataSource.GetObject(id);

            return View(result);
        }

        //
        // GET: /Workflow/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Workflow/Create
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

        //
        // GET: /Workflow/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Workflow/Edit/5
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

        //
        // GET: /Workflow/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Workflow/Delete/5
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
