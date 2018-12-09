using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KitchenToolDAO : IDAO<KitchenTool>
    {
        // Singleton pattern (thread safe) \\
        private static KitchenToolDAO instance = null;
        private static readonly object padlock = new object();

        private KitchenToolDAO()
        {
        }

        public static KitchenToolDAO Instance
        {
            get {
                lock (padlock) {
                    if (instance == null)
                        instance = new KitchenToolDAO();
                    return instance;
                }
            }
        }


        // CRUD \\
        public void create(KitchenTool kitchenTool)
        {
            using (var db = new DataContext())
            {
                db.KitchenTool.Add(kitchenTool);
                db.SaveChanges();
            }
        }

        public void delete(int id)
        {
            using (var db = new DataContext())
            {
                var kitchenToolToRemove = db.KitchenTool.Where(a => a.ID == id).FirstOrDefault<KitchenTool>();

                if (kitchenToolToRemove != null)
                {
                    db.KitchenTool.Remove(kitchenToolToRemove);
                    db.SaveChanges();
                }                
            }
        }

        public KitchenTool get(int id)
        {
            KitchenTool query = null;

            using (var db = new DataContext())
            {
                query = db.KitchenTool.Where(a => a.ID == id).FirstOrDefault<KitchenTool>();
            }

            return query;
        }

        public bool update(int id, KitchenTool newKitchenTool)
        {
            using (var db = new DataContext())
            {
                var kitchenToolToModify = db.KitchenTool.Where(a => a.ID == id).FirstOrDefault<KitchenTool>();

                if (kitchenToolToModify == null)
                    return false;

                kitchenToolToModify = newKitchenTool;
                db.SaveChanges();
            }

            return true;
        }
    }
}
