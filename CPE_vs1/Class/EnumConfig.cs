using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Runtime.Remoting;
namespace CPE_vs1
{
    class EnumConfig
    {
       static public  int LenghtBarcode = 13;
       public enum Tab
       {
           Recently = 0,
           DataBase
       };
        public enum CPEStatus
        {
            Available = 1,
            Deleted,
            Faulty,
            Lost,
            Rented,
            LoanMore
        };
        public enum CPEStatusPenalty
        {
            Available = 1,
            Faulty=3,
            Lost=4,
            //LoanMore=6
        };
        public enum RentStatus
        {
            Available = 1,
            Faulty,
            Lost,
            LoanOut
        };
        public enum OEM
        {
            Nomarl = 1,
            OEM
        };
        public enum Result
        {
            Fail=0,
            Success
        };
        static public Dictionary<string, int> CPEStatus1 = new Dictionary<string, int>()
        {
            {"Available",1},
            {"Faulty",2},
            {"Lost",3}
        };
        public static DataTable getTableFromDictionary(Dictionary<string, int> dic)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            foreach (var item in dic)
            {
                dt.Rows.Add(item.Key,item.Value);
            }
            return dt;
        }
         public static DataTable getTableFromEnum(object obj)
        {
            dynamic dys = Activator.CreateInstance(obj.GetType());
            dys = obj;
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            for (int i = 0; i < 100; i++)
            {
                if(common.parseInt(dys) == 0)
                {
                    i = (int)dys;
                    dt.Rows.Add(i, dys);
                  
                }
                dys++;
            }
            //while (common.parseInt(dys) == 0)
            //{
            //    i = (int)dys;
            //    dt.Rows.Add(i, dys);
            //    dys++;
            //}
            dt.Rows.Add();
            return dt;
        }
    }
}
