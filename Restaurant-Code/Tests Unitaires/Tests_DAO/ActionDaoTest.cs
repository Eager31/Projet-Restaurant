using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DAL;

namespace Tests_Unitaires
{
    [TestClass]
    public class ActionDaoTest
    {
        [TestMethod]    // READ
        public void Test_GetMethodReturnsActionWhenGivenId()
        {
            var dao = ActionDAO.Instance;

            var actual = dao.get(21);
            var expected = new DAL.Action();

            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]    // CREATE
        public void Test_CreateMethodAddsEntryToDatabaseWhenGivenAction()
        {
            var dao = ActionDAO.Instance;
            var actionToAdd = new DAL.Action { ID = 1000, name = "TestAction", description = "To delete ...", duration = 0 };

            dao.create(actionToAdd);

            Assert.ReferenceEquals(actionToAdd, dao.get(1000));
        }

        [TestMethod]    // UPDATE
        public void Test_UpdateMethodModifiesEntryInDatabaseWhenGivenIdAndAction()
        {
            var dao = ActionDAO.Instance;

            var oldAction = dao.get(1000);
            var newAction = new DAL.Action { ID = 1000, name = "TestAction (MOD)", description = "To delete next ...", duration = 0 };

            dao.update(1000, newAction);

            Assert.AreNotEqual(oldAction, newAction);
        }

        [TestMethod]    // DELETE
        public void Test_DeleteMethodRemovesEntryFromDatabaseWhenGivenId()
        {
            var dao = ActionDAO.Instance;

            dao.delete(1000);

            Assert.IsNull(dao.get(1000));
        }
    }
}
