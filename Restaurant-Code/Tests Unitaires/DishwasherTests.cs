using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modèle.Plonge;
using Modèle.Cuisine;

namespace Tests_Unitaires
{
    /// <summary>
    /// Summary description for DishwasherTests
    /// </summary>
    [TestClass]
    public class DishwasherTests
    {
        public DishwasherTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;
        private WashingMachine washingMachine;
        private List<KitchenTool> dirtyKitchenToolListEmpty;
        private KitchenTool dirtyKnife;
        private KitchenTool dirtyHammer;
        private List<KitchenTool> dirtyKitchenToolList;
        private DishwasherMachine dishWasherMachine;

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

        [TestInitialize]
        public void initializedTest()
        {

            dirtyKnife = new KitchenTool("knife", EnumKitchen.KitchenToolsType.dirt);
            dirtyHammer = new KitchenTool("hammer", EnumKitchen.KitchenToolsType.dirt);
            dirtyKitchenToolList = new List<KitchenTool>
            {
                //10 knife
                dirtyKnife,
                dirtyKnife,
                dirtyKnife,
                dirtyKnife,
                dirtyKnife,
                dirtyKnife,
                dirtyKnife,
                dirtyKnife,
                dirtyKnife,
                dirtyKnife,
                //3 hammer
                dirtyHammer,
                dirtyHammer,
                dirtyHammer,

            };
            dishWasherMachine = new DishwasherMachine();
            washingMachine = new WashingMachine();
            dirtyKitchenToolListEmpty = new List<KitchenTool> { };

        }


        [TestMethod]
        public void washDirtyKitchenToolsWorking()
        {
            int value = dishWasherMachine.wash(dirtyKitchenToolList);  //13 elements -  3 elements (pourra être modifié dans le futur)
            Assert.AreEqual(1, value); //Working
            value = dishWasherMachine.wash(dirtyKitchenToolList); //10 -3
            value = dishWasherMachine.wash(dirtyKitchenToolList); // 7 - 3
            value = dishWasherMachine.wash(dirtyKitchenToolList); //4 - 3
            value = dishWasherMachine.wash(dirtyKitchenToolList); // 1 - 3 List Empty
            Assert.AreEqual(0, value);

            int value2 = dishWasherMachine.wash(dirtyKitchenToolListEmpty);
            Assert.AreEqual(0, value2); //nothing to wash


        }
    }
}
