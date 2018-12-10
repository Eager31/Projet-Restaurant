using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InstructionDAO : IDAO<Instruction>
    {
        // Singleton pattern (thread safe) \\
        private static InstructionDAO instance = null;
        private static readonly object padlock = new object();

        private InstructionDAO()
        {
        }

        public static InstructionDAO Instance
        {
            get {
                lock (padlock) {
                    if (instance == null)
                        instance = new InstructionDAO();
                    return instance;
                }
            }
        }


        // CRUD \\
        public void create(Instruction instruction)
        {
            using (var db = new DataContext())
            {
                db.Instruction.Add(instruction);
                db.SaveChanges();
            }
        }

        public void delete(int id)
        {
            using (var db = new DataContext())
            {
                var instructionToRemove = db.Instruction.Where(a => a.ID == id).FirstOrDefault<Instruction>();

                if (instructionToRemove != null)
                {
                    db.Instruction.Remove(instructionToRemove);
                    db.SaveChanges();
                }                
            }
        }

        public Instruction get(int id)
        {
            Instruction query = null;

            using (var db = new DataContext())
            {
                query = db.Instruction.Where(a => a.ID == id).FirstOrDefault<Instruction>();
            }

            return query;
        }

        public Instruction getByName(string name)
        {
            Instruction query = null;

            using (var db = new DataContext())
            {
                query = db.Instruction.Where(a => a.name == name).FirstOrDefault<Instruction>();
            }

            return query;
        }

        public bool update(int id, Instruction newInstruction)
        {
            using (var db = new DataContext())
            {
                var instructionToModify = db.Instruction.Where(a => a.ID == id).FirstOrDefault<Instruction>();

                if (instructionToModify == null)
                    return false;

                instructionToModify = newInstruction;
                db.SaveChanges();
            }

            return true;
        }
    }
}
