using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface IDAO<T>
    {
        void create(T t);
        void delete(int id);
        T get(int id);
        //List<T> getAll();
        bool update(int id, T newT);
    }
}
