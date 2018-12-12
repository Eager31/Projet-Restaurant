using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DAL;

namespace Tests_Unitaires
{
    [TestClass]
    public class DishDaoTest
    {

        [Ignore] // you can ignore this test
        [TestMethod]    // READ
        public void Test_GetMethodReturnsDishWhenGivenName()
        {
            var dao = DishDAO.Instance;

            var actual = dao.getByName("TestDish");
            var expected = new DAL.Dish();

            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [Ignore] // you can ignore this test
        [TestMethod]    // CREATE
        public void Test_CreateMethodAddsEntryToDatabaseWhenGivenDish()
        {
            var dao = DishDAO.Instance;
            var dishToAdd = new DAL.Dish { ID = 1000, name = "TestDish", description = "To delete ..." };

            dao.create(dishToAdd);

            Assert.ReferenceEquals(dishToAdd, dao.get(1000));
        }
        
        [Ignore] // you can ignore this test
        [TestMethod]    // UPDATE
        public void Test_UpdateMethodModifiesEntryInDatabaseWhenGivenIdAndDish()
        {
            var dao = DishDAO.Instance;

            var oldDish = dao.get(1000);
            var newDish = new DAL.Dish { ID = 1000, name = "TestDish (MOD)", description = "To delete next ..." };

            dao.update(1000, newDish);

            Assert.AreNotEqual(oldDish, newDish);
        }

        [Ignore] // you can ignore this test
        [TestMethod]    // DELETE
        public void Test_DeleteMethodRemovesEntryFromDatabaseWhenGivenDishId()
        {
            var dao = DishDAO.Instance;

            dao.delete(1000);

            Assert.IsNull(dao.get(1000));
        }
    }
}
