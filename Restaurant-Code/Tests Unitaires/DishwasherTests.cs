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
using Controleur.Temps;
using Modèle.Room;

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
        private QueueRoomStuff queueRoomTools;
        private QueueKitchenTools queueKitchenToolsEmpty;
        private QueueRoomStuff queueRoomStuff;
        private List<RoomStuff> dirtyRoomStuff;
        private ElementTowel towel;

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

            dirtyKnife = new KitchenTool("knife", EnumKitchen.KitchenToolsType.Dirt);
            dirtyHammer = new KitchenTool("hammer", EnumKitchen.KitchenToolsType.Dirt);
            dirtyKitchenToolList = new List<KitchenTool>
            {
                
                dirtyKnife,
                dirtyHammer,

            };
            dishWasherMachine = new DishwasherMachine();

            dirtyKitchenToolListEmpty = new List<KitchenTool> { };
         

            queueKitchenTools = new QueueKitchenTools();
            queueRoomTools = new QueueRoomStuff();
            

            queueKitchenTools.kitchenToolsQueue = dirtyKitchenToolList;

            queueKitchenToolsEmpty = new QueueKitchenTools();
            queueKitchenToolsEmpty.kitchenToolsQueue = dirtyKitchenToolListEmpty;


            /* Même principe mais avec RoomStuff*/
            washingMachine = new WashingMachine();
            queueRoomStuff = new QueueRoomStuff();
            towel = new ElementTowel(EnumRoom.TowelType.Paper,EnumRoom.MaterialState.Dirt);
            dirtyRoomStuff = new List<RoomStuff>()
            {
                towel,
                towel

            };
            queueRoomStuff.roomToolsQueue = dirtyRoomStuff;


            //Récupérer la sortie standard
            StreamWriter standardOut = new StreamWriter(Console.OpenStandardOutput());

            standardOut.AutoFlush = true;

            Console.SetOut(standardOut);
        }


        [TestMethod]
        public void washDirtyKitchenToolsWorking()
        {
            dishWasherMachine.addToWash(queueKitchenTools);
            dishWasherMachine.wash(); 
            Assert.AreEqual(dirtyKnife.type, EnumKitchen.KitchenToolsType.OK);
            Assert.AreEqual(dirtyHammer.type, EnumKitchen.KitchenToolsType.OK);
            Assert.AreEqual(dishWasherMachine.toolsToWash.Count, 0); //La machine à laver est vidée et prête
        }

        [TestMethod]
        public void observerObservableDishWasherKitchenToolsListIsNotEmpty()
        {
            QueueKitchenTools kitchenQueueTest = new QueueKitchenTools();
            QueueKitchenToolsHandler provider = new QueueKitchenToolsHandler(); //Fournit les informations de la kitchenQueueTest
            DishWasher observer1 = new DishWasher("Gilly");
            observer1.SubscribeQueueKitchenTools (provider);
            kitchenQueueTest.kitchenToolsQueue.Add(dirtyKnife);
            kitchenQueueTest.kitchenToolsQueue.Add(dirtyKnife);
            Assert.AreEqual(provider.QueueKitchenToolsStatus(kitchenQueueTest).kitchenToolsQueue.Count, kitchenQueueTest.kitchenToolsQueue.Count);

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
            Assert.AreEqual(provider.QueueKitchenToolsStatus(kitchenQueueTest).kitchenToolsQueue.Count, kitchenQueueTest.kitchenToolsQueue.Count);

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
            QueueRoomStuff roomQueueTest = new QueueRoomStuff();
            QueueRoomStuffHandler provider = new QueueRoomStuffHandler(); //Fournit les informations de la kitchenQueueTest
            DishWasher observer1 = new DishWasher("Marc");
            ElementPlate plate = new ElementPlate(EnumRoom.PlateType.Flat, EnumRoom.MaterialState.Dirt);

            roomQueueTest.roomToolsQueue.Add(plate);
            roomQueueTest.roomToolsQueue.Add(plate);
            roomQueueTest.roomToolsQueue.Add(plate);
            observer1.SubscribeQueueRoomStuff(provider);
            Assert.AreEqual(provider.QueueRoomToolsStatus(roomQueueTest).roomToolsQueue.Count, roomQueueTest.roomToolsQueue.Count);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                provider.QueueRoomToolsStatus(roomQueueTest); //Fournit le status aux observer
                string expected = string.Format("List contains : 3 : elements - Marc{0}", Environment.NewLine);
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }

        [TestMethod]
        public void observerObservableMachinerWatchingClock()
        {
            Clock clock = Clock.Instance;
            WashingMachine machine = new WashingMachine(); //Student can't check counter normaly :o
            ClockHandler provider = new ClockHandler();

            machine.SubscribeClock(provider); //student is watching the clock

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                provider.ClockStatus(clock); //Fournit le status aux observer
                string expected = string.Format("The clock is watched - Washing Machine{0}", Environment.NewLine);
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }

        [TestMethod]
        public void dishWasherCleanKitchenWareTest()
        {
            DishWasher dishWasher = new DishWasher("Maz");
            dishWasher.actionDishWasher("CleanKitchenware", dishWasherMachine, queueKitchenTools); //1 dirty Knife et 1 dirty Hammer de base;
                                                                                         // Les objets sont lavés et retirés de la queueKitchenTools

            Assert.AreEqual(queueKitchenTools.kitchenToolsQueue.Count, 0); //Plus aucun élement dans notre queue

            //Imaginons que nous avons 15 élements dans notre queue
            for (int i = 0; i < 15; i++)
            {
                queueKitchenTools.kitchenToolsQueue.Add(dirtyKnife);
            }

            dishWasher.actionDishWasher("CleanKitchenware", dishWasherMachine, queueKitchenTools);
            Assert.AreEqual(queueKitchenTools.kitchenToolsQueue.Count, 5); //La capacité de la machine à laver est de 10, queue = 5
        }

        [TestMethod]
        public void disWasherCleanRoomStuffTest()
        {
            DishWasher dishWasher = new DishWasher("Maz");
            dishWasher.actionDishWasher("CleanTableware", washingMachine, queueRoomStuff); //2 towel
                                                                                         
            Assert.AreEqual(queueRoomStuff.roomToolsQueue.Count, 0); //Plus aucun élement dans notre queue

            //Imaginons que nous avons 15 élements dans notre queue
            for (int i = 0; i < 15; i++)
            {
                queueRoomStuff.roomToolsQueue.Add(towel);
            }

            dishWasher.actionDishWasher("CleanTableware", washingMachine, queueRoomStuff);
            Assert.AreEqual(queueRoomStuff.roomToolsQueue.Count, 10); //La capacité de la machine à laver est de 5, queue = 10
        }

        [TestMethod]
        public void observerObservableDishWasherReceiveWillWasWhenNeeded()
        {

            DishWasher dishWasher = new DishWasher("dishWasher"); //Student can't check counter normaly :o
            QueueKitchenToolsHandler provider = new QueueKitchenToolsHandler();
            
            dishWasher.SubscribeQueueKitchenTools(provider); //student is watching the clock

            //queueKitchenTools // dirtyKnife,dirtyHammer,

            provider.QueueKitchenToolsStatus(queueKitchenTools); //Fournit le status aux observer - Demandant de wash
     
        }
    }
}
