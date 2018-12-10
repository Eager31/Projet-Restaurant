using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DishDAO : IDAO<Dish>
    {
        // Singleton pattern (thread safe) \\
        private static DishDAO instance = null;
        private static readonly object padlock = new object();

        private DishDAO()
        {
        }

        public static DishDAO Instance
        {
            get {
                lock (padlock) {
                    if (instance == null)
                        instance = new DishDAO();
                    return instance;
                }
            }
        }


        // CRUD \\
        public void create(Dish dish)
        {
            using (var db = new DataContext())
            {
                db.Dish.Add(dish);
                db.SaveChanges();
            }
        }

        public void delete(int id)
        {
            using (var db = new DataContext())
            {
                var dishToRemove = db.Dish.Where(a => a.ID == id).FirstOrDefault<Dish>();

                if (dishToRemove != null)
                {
                    db.Dish.Remove(dishToRemove);
                    db.SaveChanges();
                }
                
            }
        }

        public Dish get(int id)
        {
            Dish query = null;

            using (var db = new DataContext())
            {
                query = db.Dish.Where(a => a.ID == id).FirstOrDefault<Dish>();
            }

            return query;
        }

        public Dish getByName(string name)
        {
            Dish query = null;

            using (var db = new DataContext())
            {
                query = db.Dish.Where(a => a.name == name).FirstOrDefault<Dish>();
            }

            return query;
        }

        public List<int> getInstructionsFromDish(int dishID)
        {
            var instructions = new List<int>();

            using (var db = new DataContext())
            {
                var query = db.InstructionInDish.Where(i => i.DishID == dishID);
                foreach(var instruction in query)
                {
                    instructions.Add(instruction.InstructionID);
                }
            }

            return instructions;
        }

        public bool update(int id, Dish newDish)
        {
            using (var db = new DataContext())
            {
                var dishToModify = db.Dish.Where(a => a.ID == id).FirstOrDefault<Dish>();

                if (dishToModify == null)
                    return false;

                dishToModify = newDish;
                db.SaveChanges();
            }

            return true;
        }
    }
}
