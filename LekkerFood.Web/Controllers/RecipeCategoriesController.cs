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
    public class RecipeCategoriesController : Controller
    {
        //initialize service object
       IRecipeCategoryService _recipeCategoryService;

       public RecipeCategoriesController(IRecipeCategoryService RecipeCategoryService)
       {
           _recipeCategoryService = RecipeCategoryService;
       }

        public ActionResult Index()
        {
            return View(_recipeCategoryService.GetAll());
        }

        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RecipeCategory RecipeCategory = _recipeCategoryService.GetById(id);
            if (RecipeCategory == null)
            {
                return HttpNotFound();
            }
            return View(RecipeCategory);
        }

        // GET: RecipeCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RecipeCategories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RecipeCategoryId,Name,Id")] RecipeCategory RecipeCategory)
        {
            if (ModelState.IsValid)
            {
                _recipeCategoryService.Create(RecipeCategory);
                return RedirectToAction("Index");
            }

            return View(RecipeCategory);
        }

        // GET: RecipeCategories/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RecipeCategory RecipeCategory = _recipeCategoryService.GetById(id);
            if (RecipeCategory == null)
            {
                return HttpNotFound();
            }
            return View(RecipeCategory);
        }

        // POST: RecipeCategories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RecipeCategoryId,Name,Id")] RecipeCategory RecipeCategory)
        {
            if (ModelState.IsValid)
            {
                _recipeCategoryService.Update(RecipeCategory);
                return RedirectToAction("Index");
            }
            return View(RecipeCategory);
        }

        // GET: RecipeCategories/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RecipeCategory RecipeCategory = _recipeCategoryService.GetById(id);
            if (RecipeCategory == null)
            {
                return HttpNotFound();
            }
            return View(RecipeCategory);
        }

        // POST: RecipeCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RecipeCategory RecipeCategory = _recipeCategoryService.GetById(id);
            _recipeCategoryService.Delete(RecipeCategory);
            return RedirectToAction("Index");
        }

    }
}
