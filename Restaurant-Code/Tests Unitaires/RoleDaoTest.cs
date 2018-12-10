using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DAL;

namespace Tests_Unitaires
{
    [TestClass]
    public class RoleDaoTest
    {
        [TestMethod]    // READ
        public void Test_GetMethodReturnsRoleWhenGivenId()
        {
            var dao = RoleDAO.Instance;

            var actual = dao.get(21);
            var expected = new DAL.Role();

            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]    // CREATE
        public void Test_CreateMethodAddsEntryToDatabaseWhenGivenRole()
        {
            var dao = RoleDAO.Instance;
            var roleToAdd = new DAL.Role { ID = 1000, name = "TestRole", nbStaffMember = 0 };

            dao.create(roleToAdd);

            Assert.ReferenceEquals(roleToAdd, dao.get(1000));
        }

        [TestMethod]    // UPDATE
        public void Test_UpdateMethodModifiesEntryInDatabaseWhenGivenIdAndRole()
        {
            var dao = RoleDAO.Instance;

            var oldRole = dao.get(1000);
            var newRole = new DAL.Role { ID = 1000, name = "TestRole (MOD)", nbStaffMember = 0 };

            dao.update(1000, newRole);

            Assert.AreNotEqual(oldRole, newRole);
        }

        [TestMethod]    // DELETE
        public void Test_DeleteMethodRemovesEntryFromDatabaseWhenGivenRoleId()
        {
            var dao = RoleDAO.Instance;

            dao.delete(1000);

            Assert.IsNull(dao.get(1000));
        }
    }
}
