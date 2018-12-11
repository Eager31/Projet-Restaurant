using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DAL;

namespace Tests_Unitaires
{
    [TestClass]
    public class MemberDaoTest
    {
        [Ignore] // you can ignore this test
        [TestMethod]    // READ
        public void Test_GetMethodReturnsMemberWhenGivenName()
        {
            var dao = MemberDAO.Instance;

            var actual = dao.getByName("TestMember");
            var expected = new DAL.Member();

            Assert.AreEqual(expected.GetType(), actual.GetType());
        }
        [Ignore] // you can ignore this test
        [TestMethod]    // CREATE
        public void Test_CreateMethodAddsEntryToDatabaseWhenGivenMember()
        {
            var dao = MemberDAO.Instance;
            var memberToAdd = new DAL.Member { ID = 1000, name = "TestMember", roleID = 1 };

            dao.create(memberToAdd);

            Assert.ReferenceEquals(memberToAdd, dao.get(1000));
        }
        [Ignore] // you can ignore this test
        [TestMethod]    // UPDATE
        public void Test_UpdateMethodModifiesEntryInDatabaseWhenGivenIdAndMember()
        {
            var dao = MemberDAO.Instance;

            var oldMember = dao.get(1000);
            var newMember = new DAL.Member { ID = 1000, name = "TestMember (MOD)", roleID = 1 };

            dao.update(1000, newMember);

            Assert.AreNotEqual(oldMember, newMember);
        }
        [Ignore] // you can ignore this test
        [TestMethod]    // DELETE
        public void Test_DeleteMethodRemovesEntryFromDatabaseWhenGivenMemberId()
        {
            var dao = MemberDAO.Instance;

            dao.delete(1000);

            Assert.IsNull(dao.get(1000));
        }
    }
}
