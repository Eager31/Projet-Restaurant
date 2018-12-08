using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modèle.Room;
using Modèle.Room.Element;
using Modèle.Cuisine;

namespace Tests_Unitaires
{
    /// <summary>
    /// Description résumée pour RoomTests
    /// </summary>
    [TestClass]
    public class RoomModelTests
    {
        public RoomModelTests()
        {
            //
            // TODO: ajoutez ici la logique du constructeur
            //
        }

        private TestContext testContextInstance;
        private ElementBread bread;
        private ElementGlass glass;
        private ElementJug jug;
        private ElementPlate plate;
        private ElementTablecloth tablecloth;
        private ElementTowel towel;
        private ElementWater water;
        private Drink drink;
        private ElementTable table;
        private Room room;
        private Square square;
        private Row row;
        private BookingForm bookingForm;
        private DateTime bookingHour;


        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active, ainsi que ses fonctionnalités.
        ///</summary>
        ///
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

            bread = new ElementBread(EnumRoom.BreadType.White, EnumRoom.MaterialState.OK);
            glass = new ElementGlass(EnumRoom.GlassType.Water, EnumRoom.MaterialState.OK);
            jug = new ElementJug(EnumRoom.JugType.Cristal, EnumRoom.MaterialState.OK);
            plate = new ElementPlate(EnumRoom.PlateType.Flat, EnumRoom.MaterialState.OK);
            tablecloth = new ElementTablecloth(EnumRoom.TableclothType.Square, EnumRoom.MaterialState.OK);
            towel = new ElementTowel(EnumRoom.TowelType.Paper, EnumRoom.MaterialState.OK);
            water = new ElementWater(EnumRoom.WaterType.Tap, EnumRoom.MaterialState.OK);
            drink = new Drink("coca", EnumRoom.DrinkType.Coca);
            table = new ElementTable(
                10,
                10,
                "libre",
                false,
                bread,
                water,
                plate,
                tablecloth,
                towel,
                glass
                );
            row = new Row(10, table);
            square = new Square(1, row);
            room = new Room(1, square);
            bookingForm = new BookingForm("foo", table, bookingHour);
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
            Assert.AreEqual(EnumRoom.JugType.Cristal, jug.type);
            Assert.AreEqual(EnumRoom.PlateType.Flat, plate.type);
            Assert.AreEqual(EnumRoom.TableclothType.Square, tablecloth.type);
            Assert.AreEqual(EnumRoom.TowelType.Paper, towel.type);
            Assert.AreEqual(EnumRoom.WaterType.Tap, water.type);
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
            Assert.AreEqual("Water", water.name);
        }

        [TestMethod]
        public void TableHasValidAttributes()
        {
            Assert.AreEqual(10, table.chairAmount);
            Assert.AreEqual(10, table.tableNumber);
            Assert.AreEqual("libre", table.state);
            Assert.AreEqual(false, table.isReserved);
            Assert.AreEqual(bread, table.bread);
            Assert.AreEqual(water, table.water);
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
            table.water = null;

            Assert.AreEqual(null, table.bread);
            Assert.AreEqual(null, table.water);
        }

        [TestMethod]
        public void IsBookingFormValid()
        {

            Assert.AreEqual("foo", bookingForm.name);
            Assert.AreEqual(table, bookingForm.table);
            Assert.AreEqual(bookingHour, bookingForm.hour);
        }
    }
}
