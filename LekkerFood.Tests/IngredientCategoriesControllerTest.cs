using LekkerFood.Models;
using LekkerFood.Service.Interfaces;
using LekkerFood.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace LekkerFood.Tests
{
    [TestClass]
    public class IngredientCategoriesControllerTest
    {
        private Mock<IIngredientCategoryService> _ingredientCategoryServiceMock;
        IngredientCategoriesController objController;
        List<IngredientCategory> listIngredientCategory;

        [TestInitialize]
        public void Initialize()
        {

            _ingredientCategoryServiceMock = new Mock<IIngredientCategoryService>();
            objController = new IngredientCategoriesController(_ingredientCategoryServiceMock.Object);
            listIngredientCategory = new List<IngredientCategory>() {
           new IngredientCategory() { Id = 1, Name = "Poltry" },
           new IngredientCategory() { Id = 2, Name = "Meat" },
           new IngredientCategory() { Id = 3, Name = "Fish" }
          };
        }



        [TestMethod]
        public void IngredientCategory_Get_All()
        {
            //Arrange
            _ingredientCategoryServiceMock.Setup(x => x.GetAll()).Returns(listIngredientCategory);

            //Act
            var result = ((objController.Index() as ViewResult).Model) as List<IngredientCategory>;

            //Assert
            Assert.AreEqual(result.Count, 3);
            Assert.AreEqual("Poltry", result[0].Name);
            Assert.AreEqual("Meat", result[1].Name);
            Assert.AreEqual("Fish", result[2].Name);

        }

        [TestMethod]
        public void Valid_IngredientCategory_Create()
        {
            //Arrange
            IngredientCategory c = new IngredientCategory() { Name = "test1" };

            //Act
            var result = (RedirectToRouteResult)objController.Create(c);

            //Assert 
            _ingredientCategoryServiceMock.Verify(m => m.Create(c), Times.Once);
            Assert.AreEqual("Index", result.RouteValues["action"]);

        }

        [TestMethod]
        public void Invalid_IngredientCategory_Create()
        {
            // Arrange
            IngredientCategory c = new IngredientCategory() { Name = "" };
            objController.ModelState.AddModelError("Error", "Something went wrong");

            //Act
            var result = (ViewResult)objController.Create(c);

            //Assert
            _ingredientCategoryServiceMock.Verify(m => m.Create(c), Times.Never);
            Assert.AreEqual("", result.ViewName);
        }

    }
}
