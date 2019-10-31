using Microsoft.VisualStudio.TestTools.UnitTesting;

using SMS.BusinessLogic;
using System.Collections.Generic;


namespace SMS.BusinessLogicTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void IngredientsTest()
        {
            var ing1 = new Ingredient { NameEnglish = "Tomate", NameFrench = "Tomato", NameDutch = "tomaat", Allergene = false };
            var ing2 = new Ingredient { NameEnglish = "Cheese", NameFrench = "Fromage", NameDutch = "Kaas", Allergene = true };
            var ing3 = new Ingredient { NameEnglish = "Salad", NameFrench = "Salade", NameDutch = "Salade", Allergene = false };
            var ing4 = new Ingredient { NameEnglish = "Onion", NameFrench = "Oignon", NameDutch = "Ui", Allergene = true };

            //Act
            var ingredientName = ing1.GetIngredientName(Language.English);
            var ingredientName2 = ing2.GetIngredientName(Language.French);
            var ingredientName3 = ing3.GetIngredientName(Language.Dutch);
            var ingredientName4 = ing4.GetIngredientName(Language.English);

            //assert
            Assert.AreEqual("Tomate", ingredientName);
            Assert.AreEqual("Fromage*", ingredientName2);
            Assert.AreEqual("Salade", ingredientName3);
            Assert.AreEqual("Onion*", ingredientName4);
        }

        [TestMethod]
        public void SandwichTest()
        {
            var ing1 = new Ingredient { NameFrench = "Tartare de boeuf", NameEnglish = "Beef tartare", NameDutch = "Tartaar van Rundvlees", Allergene = false };
            var ing2 = new Ingredient { NameFrench = "cornichon", NameEnglish = "pickle", NameDutch = "Augurkje", Allergene = false };
            var ing3 = new Ingredient { NameFrench = "cacahuète", NameEnglish = "peanut", NameDutch = "Pinda", Allergene = true };

            List<Ingredient> ingredientList = new List<Ingredient> { ing1, ing2, ing3}; // instead of ingredientList.Add(ing1); ingredientList.Add(ing1);

            var san1 = new Sandwich { NameEnglish = "Sandwich English", NameFrench = "Sandiwch French", NameDutch = "Sandiwch Dutch", Ingredient = ingredientList };

            //Act
            string text = san1.GetIngredientList(Language.Dutch);

            //Assert
            Assert.AreEqual("Tartaar van Rundvlees, Augurkje, Pinda*", text);
        }
    }
}
