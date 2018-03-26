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
    public class MeasurementTypeController : Controller
    {
        //initialize service object
       IMeasurementTypeService _measurementTypeService;

       public MeasurementTypeController(IMeasurementTypeService measurementTypeService)
       {
            _measurementTypeService = measurementTypeService;
       }

        public ActionResult Index()
        {
            return View(_measurementTypeService.GetAll());
        }

        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MeasurementType measurementType = _measurementTypeService.GetById(id);
            if (measurementType == null)
            {
                return HttpNotFound();
            }
            return View(measurementType);
        }

        // GET: MeasurementType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MeasurementType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MeasurementType measurementType)
        {
            if (ModelState.IsValid)
            {
                _measurementTypeService.Create(measurementType);
                return RedirectToAction("Index");
            }

            return View(measurementType);
        }

        // GET: MeasurementType/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MeasurementType measurementType = _measurementTypeService.GetById(id);
            if (measurementType == null)
            {
                return HttpNotFound();
            }
            return View(measurementType);
        }

        // POST: MeasurementType/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MeasurementType measurementType)
        {
            if (ModelState.IsValid)
            {
                _measurementTypeService.Update(measurementType);
                return RedirectToAction("Index");
            }
            return View(measurementType);
        }

        // GET: MeasurementType/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MeasurementType measurementType = _measurementTypeService.GetById(id);
            if (measurementType == null)
            {
                return HttpNotFound();
            }
            return View(measurementType);
        }

        // POST: MeasurementType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MeasurementType measurementType = _measurementTypeService.GetById(id);
            _measurementTypeService.Delete(measurementType);
            return RedirectToAction("Index");
        }

    }
}
