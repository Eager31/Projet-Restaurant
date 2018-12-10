using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MemberDAO
    {
        // Singleton pattern (thread safe) \\
        private static MemberDAO instance = null;
        private static readonly object padlock = new object();

        private MemberDAO()
        {
        }

        public static MemberDAO Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                        instance = new MemberDAO();
                    return instance;
                }
            }
        }


        // CRUD \\
        public void create(Member member)
        {
            using (var db = new DataContext())
            {
                db.Member.Add(member);
                db.SaveChanges();
            }
        }

        public void delete(int id)
        {
            using (var db = new DataContext())
            {
                var memberToRemove = db.Member.Where(a => a.ID == id).FirstOrDefault<Member>();

                if (memberToRemove != null)
                {
                    db.Member.Remove(memberToRemove);
                    db.SaveChanges();
                }
            }
        }

        public Member get(int id)
        {
            Member query = null;

            using (var db = new DataContext())
            {
                query = db.Member.Where(a => a.ID == id).FirstOrDefault<Member>();
            }

            return query;
        }

        public Member getByName(String name)
        {
            Member query = null;

            using (var db = new DataContext())
            {
                query = db.Member.Where(a => a.name == name).FirstOrDefault<Member>();
            }

            return query;
        }

        public bool update(int id, Member newMember)
        {
            using (var db = new DataContext())
            {
                var memberToModify = db.Member.Where(a => a.ID == id).FirstOrDefault<Member>();

                if (memberToModify == null)
                    return false;

                memberToModify = newMember;
                db.SaveChanges();
            }

            return true;
        }
    }
}
