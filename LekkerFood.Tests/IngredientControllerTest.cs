using LekkerFood.Models;
using LekkerFood.Service.Interfaces;
using LekkerFood.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LekkerFood.Tests
{
    [TestClass]
    public class IngredientControllerTest
    {
        private Mock<IIngredientService> _listIngredientserviceMock;
        private Mock<IIngredientCategoryService> _listIngredientCategoryserviceMock;
        IngredientController objController;
        IList<Ingredient> listIngredients = new List<Ingredient>();

        [TestInitialize]
        public void Initialize()
        {

            _listIngredientserviceMock = new Mock<IIngredientService>();
            objController = new IngredientController(_listIngredientserviceMock.Object, _listIngredientCategoryserviceMock.Object);

            listIngredients.Add(new Ingredient() { Id = 1, Name = "Chicken Breast", IngredientCategoryId = 1 });
            listIngredients.Add(new Ingredient() { Id = 2, Name = "Chicken Thigh", IngredientCategoryId = 1 });
            listIngredients.Add(new Ingredient() { Id = 3, Name = "Chicken Wings", IngredientCategoryId = 1 });
            listIngredients.Add(new Ingredient() { Id = 4, Name = "Beef Joint", IngredientCategoryId = 2 });
            listIngredients.Add(new Ingredient() { Id = 5, Name = "Beef Mince", IngredientCategoryId = 2 });
            listIngredients.Add(new Ingredient() { Id = 6, Name = "Steak", IngredientCategoryId = 2 });
            listIngredients.Add(new Ingredient() { Id = 7, Name = "Salmon Fillet", IngredientCategoryId = 3 });
            listIngredients.Add(new Ingredient() { Id = 8, Name = "Trout", IngredientCategoryId = 3 });
            listIngredients.Add(new Ingredient() { Id = 9, Name = "Fish Cakes", IngredientCategoryId = 3 });
            listIngredients.Add(new Ingredient() { Id = 10, Name = "Cheddar Cheese", IngredientCategoryId = 7 });
            listIngredients.Add(new Ingredient() { Id = 11, Name = "Mozzarella", IngredientCategoryId = 7 });
            listIngredients.Add(new Ingredient() { Id = 12, Name = "Goats Cheese", IngredientCategoryId = 7 });
            listIngredients.Add(new Ingredient() { Id = 13, Name = "Feta Cheese", IngredientCategoryId = 7 });
            listIngredients.Add(new Ingredient() { Id = 14, Name = "Parmesan Cheese", IngredientCategoryId = 7 });
            listIngredients.Add(new Ingredient() { Id = 15, Name = "Apple", IngredientCategoryId = 5 });
            listIngredients.Add(new Ingredient() { Id = 16, Name = "Pear", IngredientCategoryId = 5 });
            listIngredients.Add(new Ingredient() { Id = 17, Name = "Orange", IngredientCategoryId = 5 });
            listIngredients.Add(new Ingredient() { Id = 18, Name = "Mango", IngredientCategoryId = 5 });
            listIngredients.Add(new Ingredient() { Id = 19, Name = "Pineapple", IngredientCategoryId = 5 });
            listIngredients.Add(new Ingredient() { Id = 20, Name = "Lucy bee Coconut (Oil)", IngredientCategoryId = 10 });
            listIngredients.Add(new Ingredient() { Id = 21, Name = "Olive Oil", IngredientCategoryId = 10 });
            listIngredients.Add(new Ingredient() { Id = 22, Name = "Tobasco Sauce", IngredientCategoryId = 6 });
            listIngredients.Add(new Ingredient() { Id = 23, Name = "Chopped Tomatoes", IngredientCategoryId = 9 });
            listIngredients.Add(new Ingredient() { Id = 24, Name = "White Onions", IngredientCategoryId = 9 });
            listIngredients.Add(new Ingredient() { Id = 25, Name = "Red Onions", IngredientCategoryId = 9 });
            listIngredients.Add(new Ingredient() { Id = 26, Name = "Garlic", IngredientCategoryId = 4 });
            listIngredients.Add(new Ingredient() { Id = 27, Name = "Ginger", IngredientCategoryId = 4 });
            listIngredients.Add(new Ingredient() { Id = 28, Name = "Fresh Basil", IngredientCategoryId = 4 });
            listIngredients.Add(new Ingredient() { Id = 29, Name = "Fresh Corriander", IngredientCategoryId = 4 });
            listIngredients.Add(new Ingredient() { Id = 30, Name = "Salt", IngredientCategoryId = 4 });

        }

        [TestMethod]
        public void IngredientCategory_Get_All()
        {
            //Arrange
            _listIngredientserviceMock.Setup(x => x.GetAll()).Returns(listIngredients);

            //Act
            var result = ((objController.Index() as ViewResult).Model) as List<Ingredient>;

            //Assert
            Assert.AreEqual(result.Count, 30);
            Assert.AreEqual("Chicken Breast", result[0].Name);
            Assert.AreEqual("Chicken Thigh", result[1].Name);
            Assert.AreEqual("Chicken Wings", result[2].Name);

        }

        [TestMethod]
        public void Valid_IngredientCategory_Create()
        {
            //Arrange
            Ingredient i = new Ingredient() { Name = "Test New Ingredient" };

            //Act
            var result = (RedirectToRouteResult)objController.Create(i);

            //Assert 
            _listIngredientserviceMock.Verify(m => m.Create(i), Times.Once);
            Assert.AreEqual("Index", result.RouteValues["action"]);

        }

        [TestMethod]
        public void Invalid_IngredientCategory_Create()
        {
            // Arrange
            Ingredient c = new Ingredient() { Name = "" };
            objController.ModelState.AddModelError("Error", "Something went wrong");

            //Act
            var result = (ViewResult)objController.Create(c);

            //Assert
            _listIngredientserviceMock.Verify(m => m.Create(c), Times.Never);
            Assert.AreEqual("", result.ViewName);
        }

    }
}
