using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modèle.Cuisine;

namespace Tests_Unitaires
{
    /// <summary>
    /// Summary description for KitchenTests
    /// </summary>
    [TestClass]
    public class KitchenTests
    {
        public KitchenTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;
        private DateTime livraisonDate;
        private DateTime experationDate;
        private Ingredients carotte;
        private Ingredients patatte;
        private List<Ingredients> listeIngredients;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestInitialize]
        public void TestInitialize()
        {
            livraisonDate = new DateTime(2018, 1, 1, 7, 30, 0); // 1/1/2018 7:30:00
            experationDate = new DateTime(2018, 3, 1, 7, 30, 0); // 3/1/2018 7:30:00
            carotte = new Ingredients("carotte", EnumKitchen.TypeIngredients.frais, livraisonDate, experationDate);
            patatte = new Ingredients("carotte", EnumKitchen.TypeIngredients.frais, livraisonDate, experationDate);
            listeIngredients.Add(carotte);
            listeIngredients.Add(patatte);

            instruction1 = new Instruction(List<Outils>, listeIngredients);
            instruction2 = new Instruction(List<Outils>, listeIngredients);
            listeInstruction = new List<Instruction>;
            listeInstruction.add(instruction1);
            listeInstruction.add(instruction2);
            recette = new Recette("NomRecette",listeInstruction)
        }
        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void IngredientsHasAttributes()
        {
            Assert.AreEqual(carotte.Name, "carotte");
            Assert.AreEqual(carotte.DateDelivered.ToString(), "01/01/2018 07:30:00");
        }

        [TestMethod]
        public void RecipeHasAttributes()
        {
            
        }


    }
}
