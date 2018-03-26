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
    public class IngredientController : Controller
    {
        //initialize service object
        IIngredientService _ingredientService;
        IIngredientCategoryService _ingredientCategoryService;

       public IngredientController(IIngredientService ingredientService, IIngredientCategoryService ingredientCategoryService)
        {
            _ingredientService = ingredientService;
            _ingredientCategoryService = ingredientCategoryService;
        }

        public ActionResult Index()
        {
            return View(_ingredientService.GetAll());
        }

        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ingredient ingredient = _ingredientService.GetById(id);
            if (ingredient == null)
            {
                return HttpNotFound();
            }
            return View(ingredient);
        }

        // GET: IngredientCategories/Create
        public ActionResult Create()
        {
            ViewBag.IngredientCategories = _ingredientCategoryService.GetAll().ToList();

            return View();
        }

        // POST: Ingredient/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Ingredient ingredient)
        {
            if (ModelState.IsValid)
            {
                _ingredientService.Create(ingredient);
                return RedirectToAction("Index");
            }

            ViewBag.IngredientCategories = _ingredientCategoryService.GetAll().ToList();
            return View(ingredient);
        }

        // GET: Ingredient/Edit/5
        public ActionResult Edit(int id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ingredient ingredient = _ingredientService.GetById(id);
            if (ingredient == null)
            {
                return HttpNotFound();
            }

            ViewBag.IngredientCategories = _ingredientCategoryService.GetAll().ToList();
            return View(ingredient);
        }

        // POST: Ingredient/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Ingredient ingredient)
        {
            if (ModelState.IsValid)
            {
                _ingredientService.Update(ingredient);
                return RedirectToAction("Index");
            }
            ViewBag.IngredientCategories = _ingredientCategoryService.GetAll().ToList();
            return View(ingredient);
        }

        // GET: Ingredient/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ingredient ingredient = _ingredientService.GetById(id);
            if (ingredient == null)
            {
                return HttpNotFound();
            }
            return View(ingredient);
        }

        // POST: Ingredient/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ingredient ingredient = _ingredientService.GetById(id);
            _ingredientService.Delete(ingredient);
            return RedirectToAction("Index");
        }

    }
}
