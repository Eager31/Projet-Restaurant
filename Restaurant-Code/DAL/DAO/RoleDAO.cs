using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RoleDAO
    {
        // Singleton pattern (thread safe) \\
        private static RoleDAO instance = null;
        private static readonly object padlock = new object();

        private RoleDAO()
        {
        }

        public static RoleDAO Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                        instance = new RoleDAO();
                    return instance;
                }
            }
        }


        // CRUD \\
        public void create(Role role)
        {
            using (var db = new DataContext())
            {
                db.Role.Add(role);
                db.SaveChanges();
            }
        }

        public void delete(int id)
        {
            using (var db = new DataContext())
            {
                var roleToRemove = db.Role.Where(a => a.ID == id).FirstOrDefault<Role>();

                if (roleToRemove != null)
                {
                    db.Role.Remove(roleToRemove);
                    db.SaveChanges();
                }
            }
        }

        public Role get(int id)
        {
            Role query = null;

            using (var db = new DataContext())
            {
                query = db.Role.Where(a => a.ID == id).FirstOrDefault<Role>();
            }

            return query;
        }

        public Role getByName(string name)
        {
            Role query = null;

            using (var db = new DataContext())
            {
                query = db.Role.Where(a => a.name == name).FirstOrDefault<Role>();
            }

            return query;
        }

        public bool update(int id, Role newRole)
        {
            using (var db = new DataContext())
            {
                var roleToModify = db.Role.Where(a => a.ID == id).FirstOrDefault<Role>();

                if (roleToModify == null)
                    return false;

                roleToModify = newRole;
                db.SaveChanges();
            }

            return true;
        }
    }
}
