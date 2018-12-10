using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DAL;

namespace Tests_Unitaires
{
    [TestClass]
    public class IngredientDaoTest
    {
        [TestMethod]    // READ
        public void Test_GetMethodReturnsIngredientWhenGivenId()
        {
            var dao = IngredientDAO.Instance;

            var actual = dao.get(21);
            var expected = new DAL.Ingredient();

            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]    // CREATE
        public void Test_CreateMethodAddsEntryToDatabaseWhenGivenIngredient()
        {
            var dao = IngredientDAO.Instance;
            var ingredientToAdd = new DAL.Ingredient { ID = 1000, name = "TestIngredient", quantityInStock = 0, dateArrival = new DateTime(), dateExpire = new DateTime(), typeId = 1 };

            dao.create(ingredientToAdd);

            Assert.ReferenceEquals(ingredientToAdd, dao.get(1000));
        }

        [TestMethod]    // UPDATE
        public void Test_UpdateMethodModifiesEntryInDatabaseWhenGivenIdAndIngredient()
        {
            var dao = IngredientDAO.Instance;

            var oldIngredient = dao.get(1000);
            var newIngredient = new DAL.Ingredient { ID = 1000, name = "TestIngredient (MOD)", quantityInStock = 0, dateArrival = new DateTime(), dateExpire = new DateTime(), typeId = 1 };

            dao.update(1000, newIngredient);

            Assert.AreNotEqual(oldIngredient, newIngredient);
        }

        [TestMethod]    // DELETE
        public void Test_DeleteMethodRemovesEntryFromDatabaseWhenGivenIngredientId()
        {
            var dao = IngredientDAO.Instance;

            dao.delete(1000);

            Assert.IsNull(dao.get(1000));
        }
    }
}
