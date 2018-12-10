using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class IngredientDAO : IDAO<Ingredient>
    {
        // Singleton pattern (thread safe) \\
        private static IngredientDAO instance = null;
        private static readonly object padlock = new object();

        private IngredientDAO()
        {
        }

        public static IngredientDAO Instance
        {
            get {
                lock (padlock) {
                    if (instance == null)
                        instance = new IngredientDAO();
                    return instance;
                }
            }
        }


        // CRUD \\
        public void create(Ingredient ingredient)
        {
            using (var db = new DataContext())
            {
                db.Ingredient.Add(ingredient);
                db.SaveChanges();
            }
        }

        public void delete(int id)
        {
            using (var db = new DataContext())
            {
                var ingredientToRemove = db.Ingredient.Where(a => a.ID == id).FirstOrDefault<Ingredient>();

                if (ingredientToRemove != null)
                {
                    db.Ingredient.Remove(ingredientToRemove);
                    db.SaveChanges();
                }                
            }
        }

        public Ingredient get(int id)
        {
            Ingredient query = null;

            using (var db = new DataContext())
            {
                query = db.Ingredient.Where(a => a.ID == id).FirstOrDefault<Ingredient>();
            }

            return query;
        }

        public Ingredient getByName(string name)
        {
            Ingredient query = null;

            using (var db = new DataContext())
            {
                query = db.Ingredient.Where(a => a.name == name).FirstOrDefault<Ingredient>();
            }

            return query;
        }

        public bool update(int id, Ingredient newIngredient)
        {
            using (var db = new DataContext())
            {
                var ingredientToModify = db.Ingredient.Where(a => a.ID == id).FirstOrDefault<Ingredient>();

                if (ingredientToModify == null)
                    return false;

                ingredientToModify = newIngredient;
                db.SaveChanges();
            }

            return true;
        }
    }
}
