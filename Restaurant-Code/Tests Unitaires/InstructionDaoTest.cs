using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DAL;

namespace Tests_Unitaires
{
    [TestClass]
    public class InstructionDaoTest
    {
        [TestMethod]    // READ
        public void Test_GetMethodReturnsInstructionWhenGivenName()
        {
            var dao = InstructionDAO.Instance;

            var actual = dao.getByName("TestInstruction");
            var expected = new DAL.Instruction();

            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]    // CREATE
        public void Test_CreateMethodAddsEntryToDatabaseWhenGivenInstruction()
        {
            var dao = InstructionDAO.Instance;
            var instructionToAdd = new DAL.Instruction { ID = 1000, name = "TestInstruction", description = "To delete ...", actionId = 1, ingredientId = 1, toolId = 1 };

            dao.create(instructionToAdd);

            Assert.ReferenceEquals(instructionToAdd, dao.get(1000));
        }

        [TestMethod]    // UPDATE
        public void Test_UpdateMethodModifiesEntryInDatabaseWhenGivenIdAndInstruction()
        {
            var dao = InstructionDAO.Instance;

            var oldInstruction = dao.get(1000);
            var newInstruction = new DAL.Instruction { ID = 1000, name = "TestInstruction (MOD)", description = "To delete ...", actionId = 1, ingredientId = 1, toolId = 1 };

            dao.update(1000, newInstruction);

            Assert.AreNotEqual(oldInstruction, newInstruction);
        }

        [TestMethod]    // DELETE
        public void Test_DeleteMethodRemovesEntryFromDatabaseWhenGivenInstructionId()
        {
            var dao = InstructionDAO.Instance;

            dao.delete(1000);

            Assert.IsNull(dao.get(1000));
        }
    }
}
