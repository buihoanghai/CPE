using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Interface.ICPE_vs1BAL
{
    public interface ILocationsBAL
    {
        bool Insert(Models.Location location);
        bool Update(Models.Location locationUpdate);
        bool DeleteByID(int ID);
        List<Models.Location> SelectAll();
        Models.Location SelectByID(int ID);
        bool CheckByID(int ID);
    }
}

