using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DAL;

namespace Tests_Unitaires
{
    [TestClass]
    public class RoleDaoTest
    {
        [Ignore] // you can ignore this test
        [TestMethod]    // READ
        public void Test_GetMethodReturnsRoleWhenGivenName()
        {
            var dao = RoleDAO.Instance;

            var actual = dao.getByName("TestRole");
            var expected = new DAL.Role();

            Assert.AreEqual(expected.GetType(), actual.GetType());
        }
        [Ignore] // you can ignore this test
        [TestMethod]    // CREATE
        public void Test_CreateMethodAddsEntryToDatabaseWhenGivenRole()
        {
            var dao = RoleDAO.Instance;
            var roleToAdd = new DAL.Role { ID = 1000, name = "TestRole", nbStaffMember = 0 };

            dao.create(roleToAdd);

            Assert.ReferenceEquals(roleToAdd, dao.get(1000));
        }
        [Ignore] // you can ignore this test
        [TestMethod]    // UPDATE
        public void Test_UpdateMethodModifiesEntryInDatabaseWhenGivenIdAndRole()
        {
            var dao = RoleDAO.Instance;

            var oldRole = dao.get(1000);
            var newRole = new DAL.Role { ID = 1000, name = "TestRole (MOD)", nbStaffMember = 0 };

            dao.update(1000, newRole);

            Assert.AreNotEqual(oldRole, newRole);
        }
        [Ignore] // you can ignore this test
        [TestMethod]    // DELETE
        public void Test_DeleteMethodRemovesEntryFromDatabaseWhenGivenRoleId()
        {
            var dao = RoleDAO.Instance;

            dao.delete(1000);

            Assert.IsNull(dao.get(1000));
        }
    }
}
