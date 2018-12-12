using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DAL;

namespace Tests_Unitaires
{
    [TestClass]
    public class KitchenToolDaoTest
    {
        [Ignore] // you can ignore this test
        [TestMethod]    // READ
        public void Test_GetMethodReturnsKitchenToolWhenGivenId()
        {
            var dao = KitchenToolDAO.Instance;

            var actual = dao.get(21);
            var expected = new DAL.KitchenTool();

            Assert.AreEqual(expected.GetType(), actual.GetType());
        }
        [Ignore] // you can ignore this test
        [TestMethod]    // CREATE
        public void Test_CreateMethodAddsEntryToDatabaseWhenGivenKitchenTool()
        {
            var dao = KitchenToolDAO.Instance;
            var kitchenToolToAdd = new DAL.KitchenTool { ID = 1000, name = "TestKitchenTool", description = "To delete ...", quantityInStock = 0 };

            dao.create(kitchenToolToAdd);

            Assert.ReferenceEquals(kitchenToolToAdd, dao.get(1000));
        }
        [Ignore] // you can ignore this test
        [TestMethod]    // UPDATE
        public void Test_UpdateMethodModifiesEntryInDatabaseWhenGivenIdAndKitchenTool()
        {
            var dao = KitchenToolDAO.Instance;

            var oldKitchenTool = dao.get(1000);
            var newKitchenTool = new DAL.KitchenTool { ID = 1000, name = "TestKitchenTool (MOD)", description = "To delete ...", quantityInStock = 0 };

            dao.update(1000, newKitchenTool);

            Assert.AreNotEqual(oldKitchenTool, newKitchenTool);
        }
        [Ignore] // you can ignore this test
        [TestMethod]    // DELETE
        public void Test_DeleteMethodRemovesEntryFromDatabaseWhenGivenKitchenToolId()
        {
            var dao = KitchenToolDAO.Instance;

            dao.delete(1000);

            Assert.IsNull(dao.get(1000));
        }
    }
}
