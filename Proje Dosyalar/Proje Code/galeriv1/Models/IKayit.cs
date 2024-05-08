using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace galeriv1
{
    interface IKayit<Tip>
    {
        void loadFromDB();
        void create(Tip obje);
        void update(Tip eskiObje, Tip yeniObje);
        void delete(Tip obje);

        DataTable getDataTable();
    }
}
