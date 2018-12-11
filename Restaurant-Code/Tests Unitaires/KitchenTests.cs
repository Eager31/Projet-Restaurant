using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modèle.Cuisine;
using Controleur.Commun.ObserverObservable;
using Controleur.Room;
using System.IO;
using Controleur.Temps;
using Controleur.Cuisine;
using Modèle.Room;
using Controleur.Commun;

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
        private KitchenAction chopVegetables;
        private Dish crushedVegetables;
        private List<Dish> listDish;
        private Menu veganMenu;
        private Fridge fridge;
        private Supply supply;
        private Freezer freezer;
        private Counter counter;
        private Cook cook;
        private List<Order> orderList;
        private Order orderDishPotatoAndVegetables;

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
            chopVegetables = new KitchenAction("Chop Vegetables", 10);

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
            entreePotato = new Dish("Potato cutted","Wonderfull potato cutted as a Salad", instructionListBis, EnumKitchen.DishType.entree, EnumKitchen.DishState.preparing);
            crushedVegetables = new Dish("crushed Vegetables", "Any vegan would love vegetables", instructionList, EnumKitchen.DishType.mainCourse, EnumKitchen.DishState.preparing);
            listDish = new List<Dish>
            {
                entreePotato,
                crushedVegetables
            };

            veganMenu = new Menu("Vegan Menu",listDish,false);


            fridge = new Fridge(ingredientsList);
            supply = new Supply(ingredientsList);
            freezer = new Freezer(ingredientsList);

            counter = new Counter();


            /* Fonct Kitchen */
            cook = new Cook("GillyCuisto");

            List<Menu> listMenu = new List<Menu>();
            listMenu.Add(veganMenu);
            /* On crée un order qui va demander un veganMenu*/
            orderDishPotatoAndVegetables = new Order(listMenu, 1);


            orderList = new List<Order>();
            orderList.Add(orderDishPotatoAndVegetables);
        }

            //Tests pour construire un menu
        [TestMethod]
        public void ingredientsHasAttributes()
        {
            Assert.AreEqual(carotte.name, "carrot");
            Assert.AreEqual(carotte.dateDelivered.ToString(), "01/01/2018 07:30:00");
        }

        [TestMethod]
        public void kitchenToolHasAttributes()
        {
            Assert.AreEqual(knife.name, "knife");
        }


        [TestMethod]
        public void kitchenActionHasAttributes()
        {
            Assert.AreEqual(crush.name, "crush");
        }

        [TestMethod]
        public void instructionHasAttributes()
        {
            Assert.AreEqual(instruction1.name,"Cut the carrot");
            Assert.IsTrue(instructionList.Contains(instruction1));
            Assert.AreEqual(instruction1.kitchenTool, kitchenToolsList);
            
        }

        [TestMethod]
        public void dishHasAttributes()
        {
            Assert.AreEqual(crushedVegetables.name, "crushed Vegetables");
            Assert.AreEqual(crushedVegetables.type, EnumKitchen.DishType.mainCourse);
        }

        [TestMethod]
        public void menuHasAttributes()
        {
            Assert.AreEqual(crushedVegetables.name, "crushed Vegetables");
            Assert.AreEqual(crushedVegetables.type, EnumKitchen.DishType.mainCourse);
        }

        //Tests pour stockage
        [TestMethod]
        public void fridgeIsAStorage()
        {
            fridge.fillStorage(1, turnip);
            Assert.IsTrue(fridge.checkStorage().Contains(turnip));
            fridge.removeFromStorage(1, turnip);
            Assert.IsFalse(fridge.checkStorage().Contains(turnip));
        }

        [TestMethod]
        public void supplyIsAStorage()
        {
            fridge.fillStorage(2, turnip);
            Assert.IsTrue(fridge.checkStorage().Contains(turnip));
            fridge.removeFromStorage(2, turnip);
            Assert.IsFalse(fridge.checkStorage().Contains(turnip));
        }

        [TestMethod]
        public void freezerIsAStorage()
        {
            fridge.fillStorage(3, turnip);
            Assert.IsTrue(fridge.checkStorage().Contains(turnip));
            fridge.removeFromStorage(3, turnip);
            Assert.IsFalse(fridge.checkStorage().Contains(turnip));
        }

        //Décorateur sur plats
        [TestMethod]
        public void decoratorTest()
        {
            Assert.AreEqual(crushedVegetables.description, "Any vegan would love vegetables");
            crushedVegetables = new Salt(crushedVegetables);
            Assert.AreEqual(crushedVegetables.description, "Any vegan would love vegetables, with salt");
            crushedVegetables = new Pepper(crushedVegetables);
            Assert.AreEqual(crushedVegetables.description, "Any vegan would love vegetables, with salt, with pepper");
            crushedVegetables = new Cream(crushedVegetables);
            Assert.AreEqual(crushedVegetables.description, "Any vegan would love vegetables, with salt, with pepper, with cream");
        }

        //Comptoir
        [TestMethod]
        public void isReturningActualLenght()
        {
            counter.tabDish[0] = entreePotato;
            Assert.AreEqual(counter.actualLengthTab(), 1);
            counter.tabDish[7] = entreePotato;
            Assert.AreEqual(counter.actualLengthTab(), 2);
            counter.tabDish[0] = null;
            Assert.AreEqual(counter.actualLengthTab(), 1);
        }

        [TestMethod]
        public void isTabFull()
        {
            for (int i = 0; i < counter.tabDish.Length; i++)
            {
                counter.tabDish[i] = entreePotato;
            }
            Assert.IsTrue(counter.isTabFull());

        }

        [TestMethod]
        public void observerObservableButlerCounterIsNotEmpty()
        {
            Counter counter = new Counter();
            CounterHandler provider = new CounterHandler(); //Fournit les informations de la kitchenQueueTest
            Butler observer1 = new Butler("David");


            counter.tabDish[0] = entreePotato;
            counter.tabDish[1] = entreePotato;
            counter.tabDish[2] = entreePotato;
            counter.tabDish[3] = entreePotato;
            observer1.SubscribeCounter(provider);
            //Assert.AreEqual(provider.CounterStatus(counter).TabDish.Length, counter.TabDish.Length);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                provider.CounterStatus(counter); //Fournit le status aux observer
                string expected = string.Format("Counter contains : 4 : elements - David{0}", Environment.NewLine);
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }

        [TestMethod]
        public void observerObservableAnyActorCounterIsNotEmpty()
        {
            Counter counter = new Counter();
            Butler observer3 = new Butler("John"); //John can't check counter normaly :o
            CounterHandler provider = new CounterHandler(); //Fournit les informations de la kitchenQueueTest
           
            counter.tabDish[0] = entreePotato;
            counter.tabDish[1] = entreePotato;
            counter.tabDish[2] = entreePotato;
            counter.tabDish[3] = entreePotato;
            observer3.SubscribeCounter(provider); //John observe the counter now :)

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                provider.CounterStatus(counter); //Fournit le status aux observer
                string expected = string.Format("Counter contains : 4 : elements - John{0}", Environment.NewLine);
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }
        [TestMethod]
        public void observerObservableAnyActorWatchingClock()
        {
            Clock clock = new Clock();
            Butler studentObserver = new Butler("Student"); //Student can't check counter normaly :o
            ClockHandler provider = new ClockHandler();

            studentObserver.SubscribeClock(provider); //student is watching the clock

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                provider.ClockStatus(clock); //Fournit le status aux observer
                string expected = string.Format("The clock is watched - Student{0}", Environment.NewLine);
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }

        [TestMethod]
        public void cookPrepareDishTest()
        {
            List<Dish> dishListReturn = new List<Dish>();
            PrepareDish preparingDish = new PrepareDish();
            Dish lastDish = new Dish(null, null, null, null, null);

            /*Before cooking*/
            foreach (Menu mdish in orderDishPotatoAndVegetables.orderList) //veganMenu
            {
                foreach (Dish dish in mdish.dishList) //entreePotato,crushedVegetables
                {
                    Assert.AreEqual(dish.state, EnumKitchen.DishState.preparing);
                }
            }

            KitchenClerck kc = new KitchenClerck("Idoia");
            Cook c = new Cook("David");
            dishListReturn = preparingDish.act(orderDishPotatoAndVegetables, kc, c); //cook

            /*After cooking*/
                foreach (Dish dish in dishListReturn) //entreePotato,crushedVegetables
                {
                    Assert.AreEqual(dish.state, EnumKitchen.DishState.OK);
                //Les noms correspondent aussi
                    lastDish = dish;
                }
            Assert.AreEqual(lastDish.name, "crushed Vegetables");
        }
        
        
        [TestMethod]
        public void cookPrepareMorningDishTest()
        {
            
            PrepareMorningDish preparingMorningDish = new PrepareMorningDish();
            Dish dishtmp = preparingMorningDish.act(); //<==> cook.Action("PrepareMonringDish", orderEntreePotato);
            //Le plat doit avoir le même nom que la commande & être dans le State "Ok"
            Assert.AreEqual(dishtmp.name, "Spceial dessert");
            Assert.AreEqual(dishtmp.type, EnumKitchen.DishType.dessert);
            Assert.AreEqual(dishtmp.state, EnumKitchen.DishState.OK);
        }
        

        [TestMethod]
        public void cookCheckIfPlateAvailibility()
        {
            // orderDishPotatoAndVegetables == VeganMenu == entreePotato + crushedVegetables
            List<Order> listOrder = new List<Order>();
            listOrder.Add(orderDishPotatoAndVegetables);
            int[] tabNumber = new int[15];

            OrderTable orderTbl = new OrderTable(listOrder, tabNumber);
            IsDishAchievable isDishAvailable = new IsDishAchievable(); // <==> MainChef call

            List<Ingredients> fridgeContainer = new List<Ingredients>();
            Fridge frige = new Fridge(fridgeContainer);

            Assert.IsFalse(isDishAvailable.act(orderTbl, frige)); //Renvoi false car le fridge est vide, et ne contient pas le nécessaire
            frige.fillStorage(5, carotte);
            frige.fillStorage(5, patatte);
            Assert.IsTrue(isDishAvailable.act(orderTbl, frige)); //Maintenant que le frigo contient les ingrédients ==> True
        }

        [TestMethod]
        public void clerkCookHelpTheCook()
        {
            //Acteurs
            Cook mazCook = new Cook("mazCook"); //Ne va rien faire
            KitchenClerck dorian = new KitchenClerck("Dorian"); //Va s'occuper de cook à la place du chef

            //Instructions - Le "Chop Vegetables" est le seul nom d'instruction que le comis sait faire ==> 'chopVegetables'
            Instruction chopVegetables1 = new Instruction(1, "chop the vegetables", kitchenToolsList, ingredientsList, chopVegetables, 10); 
            Instruction chopVegetables2 = new Instruction(1, "chop the vegetables", kitchenToolsList, ingredientsList, chopVegetables, 10);
            List<Instruction> cookForKClerck = new List<Instruction>
            {
                chopVegetables1,
                chopVegetables2
            };
            Dish chop1 = new Dish("chop1", "chop1 created by Clerck", cookForKClerck, EnumKitchen.DishType.mainCourse, EnumKitchen.DishState.preparing);
            Dish chop2 = new Dish("chop2", "chop1 created by Clerck", cookForKClerck, EnumKitchen.DishType.mainCourse, EnumKitchen.DishState.preparing);
            List<Dish> dishListForClerck = new List<Dish>
            {
                chop1,
                chop2
            };
            Menu menuForClerck = new Menu("ClerckMenu", dishListForClerck, false);
            List<Menu> menuForClerckList = new List<Menu>
            {
                menuForClerck
            };

            Order orderForClerck = new Order(menuForClerckList, 5);
            List<Dish> dishListReturn = new List<Dish>();
            PrepareDish preparingDish = new PrepareDish();
            Dish lastDish = new Dish(null, null, null, null, null);
            //mazCook.Action("PrepareDish", orderForClerck, dorian); //Les plats vont être commencé par Maz, mais vu qu'il n'y a que des "Chop Vegetables"
            //<==>
            dishListReturn = preparingDish.act(orderForClerck, dorian, mazCook); //On passe par ça pour récup une data à la place
            // C'est le clerck qui s'en occupe (dorian).
            foreach (Dish dish in dishListReturn)
            {
                Assert.AreEqual(dish.state, EnumKitchen.DishState.OK);
                lastDish = dish;
            }
            Assert.AreEqual(lastDish.name, "chop2");


        }

    }
}
