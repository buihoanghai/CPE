using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPE_vs1.BusinessLayer
{
    abstract class Parrent
    {
        public abstract Parrent getObj();
    }
    class Child1 : Parrent
    {
        Child1 getO()
        {
            return new Child1();
        }
        public override Parrent getObj()
        {
            return getO();
        }
    }
    public abstract class Layer
    {
        public int ID;
       public string Created;
       public string Modified;
       public int Created_By;
       public int Modified_By;
       public Layer()
        {
            try
            {
                Created = common.toFormatTime(DateTime.Now);
                Modified = common.toFormatTime(DateTime.Now);
                Created_By = SessionCur.staff.ID;
                Modified_By = SessionCur.staff.ID;
            }
            catch { }
        }
       public abstract Layer GetInfor(int ID);
       public int Insert(Layer layer)
       {
           Created = common.toFormatTime(DateTime.Now);
           Modified = common.toFormatTime(DateTime.Now);
           Created_By = SessionCur.staff.ID;
           Modified_By = SessionCur.staff.ID;
           return 0;
       }
       public int Update(Layer layer)
       {
           layer.Modified = common.toFormatTime(DateTime.Now);
           Modified_By = SessionCur.staff.ID;
           return 0;
       }
    }
}
