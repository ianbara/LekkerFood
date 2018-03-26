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
    public class IngredientCategoriesController : Controller
    {
        //initialize service object
       IIngredientCategoryService _ingredientCategoryService;

       public IngredientCategoriesController(IIngredientCategoryService ingredientCategoryService)
       {
           _ingredientCategoryService = ingredientCategoryService;
       }

        public ActionResult Index()
        {
            return View(_ingredientCategoryService.GetAll());
        }

        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IngredientCategory ingredientCategory = _ingredientCategoryService.GetById(id);
            if (ingredientCategory == null)
            {
                return HttpNotFound();
            }
            return View(ingredientCategory);
        }

        // GET: IngredientCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IngredientCategories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IngredientCategoryId,Name,Id")] IngredientCategory ingredientCategory)
        {
            if (ModelState.IsValid)
            {
                _ingredientCategoryService.Create(ingredientCategory);
                return RedirectToAction("Index");
            }

            return View(ingredientCategory);
        }

        // GET: IngredientCategories/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IngredientCategory ingredientCategory = _ingredientCategoryService.GetById(id);
            if (ingredientCategory == null)
            {
                return HttpNotFound();
            }
            return View(ingredientCategory);
        }

        // POST: IngredientCategories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IngredientCategoryId,Name,Id")] IngredientCategory ingredientCategory)
        {
            if (ModelState.IsValid)
            {
                _ingredientCategoryService.Update(ingredientCategory);
                return RedirectToAction("Index");
            }
            return View(ingredientCategory);
        }

        // GET: IngredientCategories/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IngredientCategory ingredientCategory = _ingredientCategoryService.GetById(id);
            if (ingredientCategory == null)
            {
                return HttpNotFound();
            }
            return View(ingredientCategory);
        }

        // POST: IngredientCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IngredientCategory ingredientCategory = _ingredientCategoryService.GetById(id);
            _ingredientCategoryService.Delete(ingredientCategory);
            return RedirectToAction("Index");
        }

    }
}
