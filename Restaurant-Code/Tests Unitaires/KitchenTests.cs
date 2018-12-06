﻿using System;
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
        private Ingredients turnip;
        private List<Ingredients> ingredientsList;
        private List<KitchenTool> kitchenToolsList;
        private KitchenTool knife;
        private KitchenTool hammer;
        private List<Instruction> instructionList;
        private Instruction instructionBis;
        private List<Instruction> instructionListBis;
        private Dish entreePotato;
        private Instruction instruction1;
        private Instruction instruction2;
        private KitchenAction crush;
        private KitchenAction cut;
        private Dish crushedVegetables;
        private List<Dish> listDish;
        private Menu veganMenu;
        private Fridge fridge;
        private Supply supply;
        private Freezer freezer;

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
            carotte = new Ingredients("carrot", EnumKitchen.IngredientsType.frais, livraisonDate, experationDate);
            patatte = new Ingredients("potato", EnumKitchen.IngredientsType.frais, livraisonDate, experationDate);
            turnip = new Ingredients("turnip", EnumKitchen.IngredientsType.frais, livraisonDate, experationDate);
            ingredientsList = new List<Ingredients>
            {
                carotte,
                patatte
            };

            knife = new KitchenTool("knife", EnumKitchen.KitchenToolsType.coupant);
            hammer = new KitchenTool("hammer", EnumKitchen.KitchenToolsType.plat);
            kitchenToolsList = new List<KitchenTool>
            {
                knife,
                hammer
            };

            crush = new KitchenAction("crush", 10);
            cut = new KitchenAction("cut", 5);

            instruction1 = new Instruction(1, "Cut the carrot", kitchenToolsList, ingredientsList, cut, 5);
            instruction2 = new Instruction(2, "crush the vegetables", kitchenToolsList, ingredientsList, crush, 10);
            instructionList = new List<Instruction>
            {
                instruction1,
                instruction2
            };
            instructionBis = new Instruction(1, "Cut the potato", kitchenToolsList, ingredientsList, cut, 7);
            instructionListBis = new List<Instruction>
            {
                instructionBis
            };
            entreePotato = new Dish("Potato cutted", instructionListBis, EnumKitchen.DishType.entree, EnumKitchen.DishState.OK);
            crushedVegetables = new Dish("crushed Vegetables", instructionList, EnumKitchen.DishType.mainCourse, EnumKitchen.DishState.OK);
            listDish = new List<Dish>
            {
                entreePotato,
                crushedVegetables
            };

            veganMenu = new Menu("Vegan Menu",listDish,false);


            fridge = new Fridge(ingredientsList);
            supply = new Supply(ingredientsList);
            freezer = new Freezer(ingredientsList);
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

            //Tests pour construire un menu
        [TestMethod]
        public void IngredientsHasAttributes()
        {
            Assert.AreEqual(carotte.Name, "carrot");
            Assert.AreEqual(carotte.DateDelivered.ToString(), "01/01/2018 07:30:00");
        }

        [TestMethod]
        public void KitchenToolHasAttributes()
        {
            Assert.AreEqual(knife.Name, "knife");
        }


        [TestMethod]
        public void KitchenActionHasAttributes()
        {
            Assert.AreEqual(crush.Name, "crush");
        }

        [TestMethod]
        public void InstructionHasAttributes()
        {
            Assert.AreEqual(instruction1.Name,"Cut the carrot");
            Assert.IsTrue(instructionList.Contains(instruction1));
            Assert.AreEqual(instruction1.KitchenTool, kitchenToolsList);
            
        }

        [TestMethod]
        public void DishHasAttributes()
        {
            Assert.AreEqual(crushedVegetables.Name, "crushed Vegetables");
            Assert.AreEqual(crushedVegetables.Type, EnumKitchen.DishType.mainCourse);
        }

        [TestMethod]
        public void MenuHasAttributes()
        {
            Assert.AreEqual(crushedVegetables.Name, "crushed Vegetables");
            Assert.AreEqual(crushedVegetables.Type, EnumKitchen.DishType.mainCourse);
        }

        //Tests pour stockage
        [TestMethod]
        public void FridgeIsAStorage()
        {
            fridge.fillStorage(1, turnip);
            Assert.IsTrue(fridge.checkStorage().Contains(turnip));
            fridge.removeFromStorage(1, turnip);
            Assert.IsFalse(fridge.checkStorage().Contains(turnip));
        }

        [TestMethod]
        public void SupplyIsAStorage()
        {
            fridge.fillStorage(2, turnip);
            Assert.IsTrue(fridge.checkStorage().Contains(turnip));
            fridge.removeFromStorage(2, turnip);
            Assert.IsFalse(fridge.checkStorage().Contains(turnip));
        }

        [TestMethod]
        public void FreezerIsAStorage()
        {
            fridge.fillStorage(3, turnip);
            Assert.IsTrue(fridge.checkStorage().Contains(turnip));
            fridge.removeFromStorage(3, turnip);
            Assert.IsFalse(fridge.checkStorage().Contains(turnip));
        }

    }
}