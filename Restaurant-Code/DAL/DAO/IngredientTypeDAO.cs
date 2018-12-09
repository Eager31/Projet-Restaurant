using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class IngredientTypeDAO : IDAO<IngredientType>
    {
        // Singleton pattern (thread safe) \\
        private static IngredientTypeDAO instance = null;
        private static readonly object padlock = new object();

        private IngredientTypeDAO()
        {
        }

        public static IngredientTypeDAO Instance
        {
            get {
                lock (padlock) {
                    if (instance == null)
                        instance = new IngredientTypeDAO();
                    return instance;
                }
            }
        }


        // CRUD \\
        public void create(IngredientType IngredientType)
        {
            using (var db = new DataContext())
            {
                db.IngredientType.Add(IngredientType);
                db.SaveChanges();
            }
        }

        public void delete(int id)
        {
            using (var db = new DataContext())
            {
                var IngredientTypeToRemove = db.IngredientType.Where(a => a.ID == id).FirstOrDefault<IngredientType>();

                if (IngredientTypeToRemove != null)
                {
                    db.IngredientType.Remove(IngredientTypeToRemove);
                    db.SaveChanges();
                }                
            }
        }

        public IngredientType get(int id)
        {
            IngredientType query = null;

            using (var db = new DataContext())
            {
                query = db.IngredientType.Where(a => a.ID == id).FirstOrDefault<IngredientType>();
            }

            return query;
        }

        public bool update(int id, IngredientType newIngredientType)
        {
            using (var db = new DataContext())
            {
                var IngredientTypeToModify = db.IngredientType.Where(a => a.ID == id).FirstOrDefault<IngredientType>();

                if (IngredientTypeToModify == null)
                    return false;

                IngredientTypeToModify = newIngredientType;
                db.SaveChanges();
            }

            return true;
        }
    }
}
