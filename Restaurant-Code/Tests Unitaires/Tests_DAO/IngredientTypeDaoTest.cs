using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DAL;

namespace Tests_Unitaires
{
    [TestClass]
    public class IngredientTypeDaoTest
    {
        [TestMethod]    // READ
        public void Test_GetMethodReturnsIngredientTypeWhenGivenId()
        {
            var dao = IngredientTypeDAO.Instance;

            var actual = dao.get(21);
            var expected = new DAL.IngredientType();

            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]    // CREATE
        public void Test_CreateMethodAddsEntryToDatabaseWhenGivenIngredientType()
        {
            var dao = IngredientTypeDAO.Instance;
            var ingredientTypeToAdd = new DAL.IngredientType { ID = 1000, name = "TestIngredientType", description = "To delete ..." };

            dao.create(ingredientTypeToAdd);

            Assert.ReferenceEquals(ingredientTypeToAdd, dao.get(1000));
        }

        [TestMethod]    // UPDATE
        public void Test_UpdateMethodModifiesEntryInDatabaseWhenGivenIdAndIngredientType()
        {
            var dao = IngredientTypeDAO.Instance;

            var oldIngredientType = dao.get(1000);
            var newIngredientType = new DAL.IngredientType { ID = 1000, name = "TestIngredientType (MOD)", description = "To delete ..." };

            dao.update(1000, newIngredientType);

            Assert.AreNotEqual(oldIngredientType, newIngredientType);
        }

        [TestMethod]    // DELETE
        public void Test_DeleteMethodRemovesEntryFromDatabaseWhenGivenIngredientTypeId()
        {
            var dao = IngredientTypeDAO.Instance;

            dao.delete(1000);

            Assert.IsNull(dao.get(1000));
        }
    }
}
