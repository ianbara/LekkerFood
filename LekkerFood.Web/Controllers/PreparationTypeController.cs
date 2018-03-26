using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LekkerFood.Models;
using LekkerFood.Service.Interfaces;

namespace LekkerFood.Web.Controllers
{
    public class PreparationTypeController : Controller
    {
        //initialize service object
        IPreparationTypeService _preparationTypeService;

       public PreparationTypeController(IPreparationTypeService preparationTypeService)
       {
            _preparationTypeService = preparationTypeService;
       }

        public ActionResult Index()
        {
            return View(_preparationTypeService.GetAll());
        }

        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PreparationType preparationType = _preparationTypeService.GetById(id);
            if (preparationType == null)
            {
                return HttpNotFound();
            }
            return View(preparationType);
        }

        // GET: PreparationType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PreparationType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "preparationTypeId,Name,Id")] PreparationType preparationType)
        {
            if (ModelState.IsValid)
            {
                _preparationTypeService.Create(preparationType);
                return RedirectToAction("Index");
            }

            return View(preparationType);
        }

        // GET: PreparationType/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PreparationType preparationType = _preparationTypeService.GetById(id);
            if (preparationType == null)
            {
                return HttpNotFound();
            }
            return View(preparationType);
        }

        // POST: PreparationType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "preparationTypeId,Name,Id")] PreparationType preparationType)
        {
            if (ModelState.IsValid)
            {
                _preparationTypeService.Update(preparationType);
                return RedirectToAction("Index");
            }
            return View(preparationType);
        }

        // GET: PreparationType/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PreparationType preparationType = _preparationTypeService.GetById(id);
            if (preparationType == null)
            {
                return HttpNotFound();
            }
            return View(preparationType);
        }

        // POST: PreparationType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PreparationType preparationType = _preparationTypeService.GetById(id);
            _preparationTypeService.Delete(preparationType);
            return RedirectToAction("Index");
        }

    }
}
