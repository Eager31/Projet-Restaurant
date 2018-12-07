using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface IDAO
    {
        void create(Object obj);
        Object get(int id);
        void update(Object obj);
        void delete(Object obj);
    }
}
