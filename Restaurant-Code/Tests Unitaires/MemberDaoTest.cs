using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DAL;

namespace Tests_Unitaires
{
    [TestClass]
    public class MemberDaoTest
    {
        [TestMethod]    // READ
        public void Test_GetMethodReturnsMemberWhenGivenId()
        {
            var dao = MemberDAO.Instance;

            var actual = dao.get(21);
            var expected = new DAL.Member();

            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]    // CREATE
        public void Test_CreateMethodAddsEntryToDatabaseWhenGivenMember()
        {
            var dao = MemberDAO.Instance;
            var memberToAdd = new DAL.Member { ID = 1000, name = "TestMember", description = "To delete ...", duration = 0 };

            dao.create(memberToAdd);

            Assert.ReferenceEquals(memberToAdd, dao.get(1000));
        }

        [TestMethod]    // UPDATE
        public void Test_UpdateMethodModifiesEntryInDatabaseWhenGivenIdAndMember()
        {
            var dao = MemberDAO.Instance;

            var oldMember = dao.get(1000);
            var newMember = new DAL.Member { ID = 1000, name = "TestMember (MOD)", description = "To delete next ...", duration = 0 };

            dao.update(1000, newMember);

            Assert.AreNotEqual(oldMember, newMember);
        }

        [TestMethod]    // DELETE
        public void Test_DeleteMethodRemovesEntryFromDatabaseWhenGivenMemberId()
        {
            var dao = MemberDAO.Instance;

            dao.delete(1000);

            Assert.IsNull(dao.get(1000));
        }
    }
}
