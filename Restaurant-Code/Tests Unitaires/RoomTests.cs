using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modèle.Room;
using Modèle.Room.Element;
using Modèle.Cuisine;
using Controleur.Room;
using System.Threading;
using Controleur.Commun;

namespace Tests_Unitaires
{

    [TestClass]
    public class RoomTests
    {
        public RoomTests()
        {
        }

        private TestContext testContextInstance;

        // Model
        private ElementBread bread;
        private ElementGlass glass;
        private ElementJug jug;
        private ElementPlate plate;
        private ElementTablecloth tablecloth;
        private ElementTowel towel;
        private Drink drink;
        private ElementTable table;
        private Room room;
        private Square square;
        private Row row;
        private BookingForm bookingForm;
        private DateTime bookingHour;
        private Card card;

        //Controler
        private Butler butler;
        private ClerkRoom clerkRoom;
        private Client client;
        private ClientPool clientPool;
        private HeadWaiter headWaiter;
        private Waiter waiter;


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
            bookingHour = new DateTime(2018, 12, 12);

            // Model
            bread = new ElementBread(EnumRoom.BreadType.White, EnumRoom.MaterialState.OK);
            glass = new ElementGlass(EnumRoom.GlassType.Water, EnumRoom.MaterialState.OK);
            jug = new ElementJug(EnumRoom.JugType.Tap, EnumRoom.MaterialState.OK);
            plate = new ElementPlate(EnumRoom.PlateType.Flat, EnumRoom.MaterialState.OK);
            tablecloth = new ElementTablecloth(EnumRoom.TableclothType.Square, EnumRoom.MaterialState.OK);
            towel = new ElementTowel(EnumRoom.TowelType.Paper, EnumRoom.MaterialState.OK);
            drink = new Drink("coca", EnumRoom.DrinkType.Coca);
            table = new ElementTable(
                10,
                10,
                "free",
                false,
                plate,
                tablecloth,
                towel,
                glass,
                bread,
                jug
                );
            row = new Row(10, table);
            square = new Square(1, row);
            room = new Room(1, square);
            bookingForm = new BookingForm("foo", table, bookingHour);
            BookingList.bookingList.Add(bookingForm);


            // Controller
            butler = new Butler("foo");
            clerkRoom = new ClerkRoom("foo");
            clientPool = new ClientPool();
            headWaiter = new HeadWaiter("foo", square);
            waiter = new Waiter("foo", square, row);
            client = new Client("foo", 10, 0);

            Card card = new Card(null, null);
        }
        #region Attributs de tests supplémentaires
        //
        // Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        // Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test de la classe
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Utilisez ClassCleanup pour exécuter du code une fois que tous les tests d'une classe ont été exécutés
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void DrinkHasAType()
        {
            Assert.AreEqual(EnumRoom.DrinkType.Coca, drink.type);
            Assert.AreEqual("coca", drink.name);
        }

        [TestMethod]
        public void ElementHasAType()
        {
            Assert.AreEqual(EnumRoom.BreadType.White, bread.type);
            Assert.AreEqual(EnumRoom.GlassType.Water, glass.type);
            Assert.AreEqual(EnumRoom.JugType.Tap, jug.type);
            Assert.AreEqual(EnumRoom.PlateType.Flat, plate.type);
            Assert.AreEqual(EnumRoom.TableclothType.Square, tablecloth.type);
            Assert.AreEqual(EnumRoom.TowelType.Paper, towel.type);
        }

        [TestMethod]
        public void ElementHasAName()
        {
            Assert.AreEqual("Bread", bread.name);
            Assert.AreEqual("Glass", glass.name);
            Assert.AreEqual("Jug", jug.name);
            Assert.AreEqual("Plate", plate.name);
            Assert.AreEqual("Tablecloth", tablecloth.name);
            Assert.AreEqual("Towel", towel.name);
        }

        [TestMethod]
        public void TableHasValidAttributes()
        {
            Assert.AreEqual(10, table.chairAmount);
            Assert.AreEqual(10, table.tableNumber);
            Assert.AreEqual("free", table.state);
            Assert.AreEqual(false, table.isReserved);
            Assert.AreEqual(bread, table.bread);
            Assert.AreEqual(plate, table.plate);
            Assert.AreEqual(tablecloth, table.tablecloth);
            Assert.AreEqual(towel, table.towel);
            Assert.AreEqual(glass, table.glass);

        }

        [TestMethod]
        public void RowHasAttributes()
        {
            Assert.AreEqual(10, row.number);
            Assert.AreEqual(table, row.table);
        }

        [TestMethod]
        public void SquareHasAttributes()
        {
            Assert.AreEqual(1, square.number);
            Assert.AreEqual(row, square.row);
        }

        [TestMethod]
        public void RoomHasAttributes()
        {
            Assert.AreEqual(1, room.number);
            Assert.AreEqual(square, room.square);
        }

        [TestMethod]
        public void RemoveBreadandWaterOnTable()
        {
            table.bread = null;
            table.jug = null;

            Assert.AreEqual(null, table.bread);
            Assert.AreEqual(null, table.jug);
        }

        [TestMethod]
        public void IsBookingFormValid()
        {

            Assert.AreEqual("foo", bookingForm.name);
            Assert.AreEqual(table, bookingForm.table);
            Assert.AreEqual(bookingHour, bookingForm.hour);
        }

        [TestMethod]
        public void BulterHasAName()
        {
            Assert.AreEqual("foo", butler.name);
        }

        [TestMethod]
        public void ClerkRoomHasAName()
        {
            Assert.AreEqual("foo", clerkRoom.name);
        }

        [TestMethod]
        public void ClientHasAttributes()
        {
            Assert.AreEqual("foo", client.name);
            Assert.AreEqual(10, client.number);
        }

        [TestMethod]
        public void HeadWaiterHasANameAndASquare()
        {
            Assert.AreEqual("foo", headWaiter.name);
            Assert.AreEqual(square, headWaiter.square);

        }

        [TestMethod]
        public void ThereAreTwoTypeOfClient()
        {
            Client stressedClient = new Client("foo", 10, 0, "StressedOut");
            Client relaxedClient = new Client("foo", 10, 0, "Relaxed");
            Assert.AreNotEqual(stressedClient, relaxedClient );

        }

        [TestMethod]
        public void isBringBreadAndJugAreWorking()
        {
            table.bread = null;
            table.jug = null;

            waiter.Action("BringBread", table, EnumRoom.BreadType.White);
            waiter.Action("BringJug", table, EnumRoom.BreadType.White, EnumRoom.JugType.Tap);

            ElementBread newbBread = new ElementBread(EnumRoom.BreadType.White, EnumRoom.MaterialState.OK);
            ElementJug newJug = new ElementJug(EnumRoom.JugType.Tap, EnumRoom.MaterialState.OK);

            Assert.AreEqual(newbBread.name, table.bread.name);
            Assert.AreEqual(newJug.name, table.jug.name);

        }

        [TestMethod]
        public void IsTheTableEmptyWhenWeUseCleanTable() // i don't test the socket here /!\
        {
            waiter.Action("CleanTable", table);
            Assert.AreEqual(null, table.bread);
            Assert.AreEqual(null, table.card);
            Assert.AreEqual(null, table.glass);
            Assert.AreEqual(null, table.jug);
            Assert.AreEqual(null, table.plate);
            Assert.AreEqual(null, table.tablecloth);
            Assert.AreEqual(null, table.towel);
 
        }

        [TestMethod]
        public void CanTheHeadWaiterBringTheCard()
        {
            table.card = null;
            headWaiter.Action("BringMenu", table, card);
            Assert.AreEqual(card, table.card);

        }

        [TestMethod]
        public void CanAClientWithReservationHaveATable() // this method test "VerifyReservation" but also "AssignTable" and "PlaceClient"
        {
            ClientList.clientList.Add(client);
            table.isReserved = true;
            butler.Action("VerifyReservation", client);

            Assert.AreEqual(client.tableNumber, table.tableNumber);

        }
    }
}
