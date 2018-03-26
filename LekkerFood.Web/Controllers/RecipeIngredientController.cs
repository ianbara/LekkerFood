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
    public class RecipeIngredientController : Controller
    {
        //initialize service object
        IRecipeService _recipeService;
        IIngredientService _ingredientService;
        IRecipeIngredientService _recipeIngredientService;
        IMeasurementTypeService _measurementTypeService;
        IPreparationTypeService _preparationTypeService;

        public RecipeIngredientController(IRecipeService recipeService, IRecipeIngredientService recipeCategoryService, IIngredientService ingredientService, IMeasurementTypeService measurementTypeService, IPreparationTypeService preparationTypeService)
        {
            _recipeService = recipeService;
            _ingredientService = ingredientService;
            _recipeIngredientService = recipeCategoryService;
            _measurementTypeService = measurementTypeService;
            _preparationTypeService = preparationTypeService;
        }

        public ActionResult Index()
        {
            return View(_recipeIngredientService.GetAll());
        }

        public ActionResult AddIngredientsToRecipe(int id)
        {
            Recipe recipe = _recipeService.GetById(id);
            if (recipe == null)
            {
                return HttpNotFound();
            }

            RecipeIngredient recipeIngredient = new RecipeIngredient();
            recipeIngredient.Recipe = recipe;
            recipeIngredient.RecipeId = id;

            return View(recipeIngredient);
        }

        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RecipeIngredient recipeIngredient = _recipeIngredientService.GetById(id);
            if (recipeIngredient == null)
            {
                return HttpNotFound();
            }
            return View(recipeIngredient);
        }

        // GET: RecipeCategories/Create
        public ActionResult Create()
        {
            PopulateSeletLists();

            return View();
        }

        // GET: RecipeCategories/Create
        public ActionResult AddIngredientToRecipe(int recipeId)
        {
            Recipe recipe = _recipeService.GetById(recipeId);

            if (recipe == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound, "Recipe could not be found with the id -" + recipeId.ToString());
            }

            RecipeIngredient recipeIngredient = new RecipeIngredient(recipeId);
            recipeIngredient.Recipe = recipe;

            PopulateSeletLists();

            return PartialView("~/Views/RecipeIngredient/_CreateForRecipe.cshtml", recipeIngredient);
        }

        // POST: Recipe/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateRecipeIngredient(RecipeIngredient recipeIngredient)
        {
            if (ModelState.IsValid)
            {
                _recipeIngredientService.Create(recipeIngredient);
                
                IEnumerable<RecipeIngredient> recipeIngredientList = new List<RecipeIngredient>();
                recipeIngredientList = _recipeIngredientService.GetAll().Where(ri => ri.RecipeId == recipeIngredient.RecipeId);

                return PartialView("~/Views/RecipeIngredient/_ListRecipeIngredients.cshtml", recipeIngredientList);
            }

            PopulateSeletLists();
            return PartialView("~/Views/RecipeIngredient/_CreateForRecipe.cshtml", recipeIngredient);
        }

        public ActionResult EditIngredientRecipe(int recipeIngredientId)
        {
            RecipeIngredient recipeIngredient = _recipeIngredientService.GetById(recipeIngredientId);

            if (recipeIngredient == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound, "Recipe Ingredient could not be found with the id -" + recipeIngredientId.ToString());
            }
            PopulateSeletLists();

            return View("~/Views/RecipeIngredient/EditRecipeIngredient.cshtml", recipeIngredient);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditRecipeIngredientPost(RecipeIngredient recipeIngredient)
        {
            if (ModelState.IsValid)
            {
                _recipeIngredientService.Update(recipeIngredient);
                return RedirectToAction("Index");
            }
            PopulateSeletLists();
            return View(recipeIngredient);
        }


        // GET: Recipe/Edit/5
        public ActionResult Edit(int id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RecipeIngredient recipeIngredient = _recipeIngredientService.GetById(id);
            if (recipeIngredient == null)
            {
                return HttpNotFound();
            }

            PopulateSeletLists();

            return View(recipeIngredient);
        }



        // POST: Recipe/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(RecipeIngredient recipeIngredient)
        {
            if (ModelState.IsValid)
            {
                _recipeIngredientService.Update(recipeIngredient);
                return RedirectToAction("Index");
            }
            PopulateSeletLists();
            return View(recipeIngredient);
        }

        // GET: Recipe/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RecipeIngredient recipeIngredient = _recipeIngredientService.GetById(id);
            if (recipeIngredient == null)
            {
                return HttpNotFound();
            }
            return View(recipeIngredient);
        }

        // POST: Recipe/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RecipeIngredient recipeIngredient = _recipeIngredientService.GetById(id);
            _recipeIngredientService.Delete(recipeIngredient);
            return RedirectToAction("Index");
        }


        private void PopulateSeletLists()
        {
            ViewBag.Recipes = _recipeService.GetAll().ToList();
            ViewBag.Ingredients = _ingredientService.GetAll().ToList();
            ViewBag.MeasurementTypes = _measurementTypeService.GetAll().ToList();
            ViewBag.PreparationTypes = _preparationTypeService.GetAll().ToList();
        }

    }
}
