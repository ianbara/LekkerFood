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
    public class RecipeController : Controller
    {
        //initialize service object
        IRecipeService _recipeService;
        IRecipeCategoryService _recipeCategoryService;

       public RecipeController(IRecipeService recipeService, IRecipeCategoryService recipeCategoryService)
        {
            _recipeService = recipeService;
            _recipeCategoryService = recipeCategoryService;
        }

        public ActionResult Index()
        {
            return View(_recipeService.GetAll());
        }

        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipe recipe = _recipeService.GetById(id);
            if (recipe == null)
            {
                return HttpNotFound();
            }
            return View(recipe);
        }

        // GET: RecipeCategories/Create
        public ActionResult Create()
        {
            ViewBag.RecipeCategories = _recipeCategoryService.GetAll().ToList();

            return View();
        }

        // POST: Recipe/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                _recipeService.Create(recipe);
                return RedirectToAction("Index");
            }

            ViewBag.RecipeCategories = _recipeCategoryService.GetAll().ToList();
            return View(recipe);
        }

        // GET: Recipe/Edit/5
        public ActionResult Edit(int id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipe recipe = _recipeService.GetById(id);
            if (recipe == null)
            {
                return HttpNotFound();
            }

            ViewBag.RecipeCategories = _recipeCategoryService.GetAll().ToList();
            return View(recipe);
        }

        // POST: Recipe/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                _recipeService.Update(recipe);
                return RedirectToAction("Index");
            }
            ViewBag.RecipeCategories = _recipeCategoryService.GetAll().ToList();
            return View(recipe);
        }

        // GET: Recipe/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipe recipe = _recipeService.GetById(id);
            if (recipe == null)
            {
                return HttpNotFound();
            }
            return View(recipe);
        }

        // POST: Recipe/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Recipe recipe = _recipeService.GetById(id);
            _recipeService.Delete(recipe);
            return RedirectToAction("Index");
        }

    }
}
