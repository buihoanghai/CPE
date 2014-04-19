using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DevExpress.XtraEditors;

namespace CPE_vs1.Interface
{
    interface IComboboxAlgorithm
    {
        void loadLookUp(DataTable dt, LookUpEdit lk);
    }
    public class LookUpAlgorithm : IComboboxAlgorithm
    {
        public void loadLookUp(DataTable dt, LookUpEdit lk)
        {
            lk.Properties.DataSource = dt;
            //lk.ItemIndex = 0;
        }
    }
}
