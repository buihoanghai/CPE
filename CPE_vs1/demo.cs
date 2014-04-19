using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CPE_vs1.BusinessLayer;
using CPE_vs1.DataAccessLayer;

namespace CPE_vs1
{
    public partial class demo : DevExpress.XtraEditors.XtraForm
    {
        public demo()
        {
            InitializeComponent();
        }
        private void demo_Load(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            gridControl1.DataSource= staff.GetListInfor();
        }
    }
}