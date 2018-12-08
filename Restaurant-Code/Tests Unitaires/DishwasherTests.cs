using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modèle.Plonge;
using Modèle.Cuisine;
using Controleur.Commun.ObserverObservable;
using System.IO;
using Controleur.Cuisine;
using Modèle.Room.Element;
using Controleur.Room;

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
        private QueueKitchenTools queueKitchenTools;
        private KitchenTool dirtyKnife;
        private KitchenTool dirtyHammer;
        private List<KitchenTool> dirtyKitchenToolList;
        private DishwasherMachine dishWasherMachine;
        private QueueRoomTools queueRoomTools;
        private QueueKitchenTools queueKitchenToolsEmpty;

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
         

            queueKitchenTools = new QueueKitchenTools();
            queueRoomTools = new QueueRoomTools();

            queueKitchenTools.KitchenToolsQueue = dirtyKitchenToolList;

            queueKitchenToolsEmpty = new QueueKitchenTools();
            queueKitchenToolsEmpty.KitchenToolsQueue = dirtyKitchenToolListEmpty;



            //Récupérer la sortie standard
            StreamWriter standardOut = new StreamWriter(Console.OpenStandardOutput());

            standardOut.AutoFlush = true;

            Console.SetOut(standardOut);
        }


        [TestMethod]
        public void washDirtyKitchenToolsWorking()
        {

            int value = dishWasherMachine.wash(queueKitchenTools);  //13 elements -  3 elements (pourra être modifié dans le futur)
            Assert.AreEqual(1, value); //Working
            value = dishWasherMachine.wash(queueKitchenTools); //10 -3
            value = dishWasherMachine.wash(queueKitchenTools); // 7 - 3
            value = dishWasherMachine.wash(queueKitchenTools); //4 - 3
            value = dishWasherMachine.wash(queueKitchenTools); // 1 - 3 List Empty
            Assert.AreEqual(0, value);
            int value2 = dishWasherMachine.wash(queueKitchenToolsEmpty);
            Assert.AreEqual(0, value2); //nothing to wash
        }

        [TestMethod]
        public void observerObservableDishWasherKitchenToolsListIsNotEmpty()
        {
            QueueKitchenTools kitchenQueueTest = new QueueKitchenTools();
            QueueKitchenToolsHandler provider = new QueueKitchenToolsHandler(); //Fournit les informations de la kitchenQueueTest
            DishWasher observer1 = new DishWasher("Gilly");
            observer1.SubscribeQueueKitchenTools (provider);
            kitchenQueueTest.KitchenToolsQueue.Add(dirtyKnife);
            kitchenQueueTest.KitchenToolsQueue.Add(dirtyKnife);
            Assert.AreEqual(provider.QueueKitchenToolsStatus(kitchenQueueTest).KitchenToolsQueue.Count, kitchenQueueTest.KitchenToolsQueue.Count);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                provider.QueueKitchenToolsStatus(kitchenQueueTest); //Fournit le status aux observer
                string expected = string.Format("List contains : 2 : elements - Gilly{0}", Environment.NewLine); 
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }

        [TestMethod]
        public void observerObservableDishWasherKitchenToolsListIsEmpty()
        {
            QueueKitchenTools kitchenQueueTest = new QueueKitchenTools();
            QueueKitchenToolsHandler provider = new QueueKitchenToolsHandler(); //Fournit les informations de la kitchenQueueTest
            DishWasher observer1 = new DishWasher("Louise");
            observer1.SubscribeQueueKitchenTools(provider);
            Assert.AreEqual(provider.QueueKitchenToolsStatus(kitchenQueueTest).KitchenToolsQueue.Count, kitchenQueueTest.KitchenToolsQueue.Count);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                provider.QueueKitchenToolsStatus(kitchenQueueTest); //Fournit le status aux observer
                string expected = string.Format("List is empty - Louise{0}", Environment.NewLine);
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }

        [TestMethod]
        public void observerObservableDishWasherRoomStuffListIsNotEmpty()
        {
            QueueRoomTools roomQueueTest = new QueueRoomTools();
            QueueRoomStuffHandler provider = new QueueRoomStuffHandler(); //Fournit les informations de la kitchenQueueTest
            DishWasher observer1 = new DishWasher("Marc");
            ElementPlate plate = new ElementPlate(EnumRoom.PlateType.Flat, EnumRoom.MaterialState.Dirt);

            roomQueueTest.RoomToolsQueue.Add(plate);
            roomQueueTest.RoomToolsQueue.Add(plate);
            roomQueueTest.RoomToolsQueue.Add(plate);
            observer1.SubscribeQueueRoomStuff(provider);
            Assert.AreEqual(provider.QueueRoomToolsStatus(roomQueueTest).RoomToolsQueue.Count, roomQueueTest.RoomToolsQueue.Count);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                provider.QueueRoomToolsStatus(roomQueueTest); //Fournit le status aux observer
                string expected = string.Format("List contains : 3 : elements - Marc{0}", Environment.NewLine);
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }


 

    }
}
