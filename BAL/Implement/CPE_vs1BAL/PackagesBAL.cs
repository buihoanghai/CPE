using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL.Interface.ICPE_vs1BAL;
using DAL.Implement.CPE_vs1DAL;

namespace BAL.Implement.CPE_vs1BAL
{
    public class PackagesBAL:IPackagesBAL
    {
        public IPackagesDAL IPackageDAL = new PackagesDAL();
        public bool Insert(Models.Package package)
        {
            return IPackageDAL.Insert(package);
        }
        public bool Update(Models.Package packageUpdate)
        {
            return IPackageDAL.Update(packageUpdate);
        }
        public bool DeleteByID(int ID)
        {
            return IPackageDAL.DeleteByID(ID);
        }
        public List<Models.Package> SelectAll()
        {
            return IPackageDAL.SelectAll();
        }
        public Models.Package SelectByID(int ID)
        {
            return IPackageDAL.SelectByID(ID);
        }
        public bool CheckByID(int ID)
        {
            return IPackageDAL.CheckByID(ID);
        }
    }
}

