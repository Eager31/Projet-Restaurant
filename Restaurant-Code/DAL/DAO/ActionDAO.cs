using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ActionDAO : IDAO<Action>
    {
        // Singleton pattern (thread safe) \\
        private static ActionDAO instance = null;
        private static readonly object padlock = new object();

        private ActionDAO()
        {
        }

        public static ActionDAO Instance
        {
            get {
                lock (padlock) {
                    if (instance == null)
                        instance = new ActionDAO();
                    return instance;
                }
            }
        }


        // CRUD \\
        public void create(Action action)
        {
            using (var db = new DataContext())
            {
                db.Action.Add(action);
                db.SaveChanges();
            }
        }

        public void delete(int id)
        {
            using (var db = new DataContext())
            {
                var actionToRemove = db.Action.Where(a => a.ID == id).FirstOrDefault<Action>();

                if (actionToRemove != null)
                {
                    db.Action.Remove(actionToRemove);
                    db.SaveChanges();
                }
            }
        }

        public Action get(int id)
        {
            Action query = null;

            using (var db = new DataContext())
            {
                query = db.Action.Where(a => a.ID == id).FirstOrDefault<Action>();
            }

            return query;
        }

        public bool update(int id, Action newAction)
        {
            using (var db = new DataContext())
            {
                var actionToModify = db.Action.Where(a => a.ID == id).FirstOrDefault<Action>();

                if (actionToModify == null)
                    return false;

                actionToModify = newAction;
                db.SaveChanges();
            }

            return true;
        }
    }
}
