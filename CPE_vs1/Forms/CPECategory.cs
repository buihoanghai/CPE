using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CPE_vs1
{
    public partial class CPECategory : DevExpress.XtraEditors.XtraForm
    {
        public CPECategory()
        {
            InitializeComponent();
        }

        private void textName_MouseDown(object sender, MouseEventArgs e)
        {
            common.openOnScreenKeyboard();
        }

        private void CPECategory_Click(object sender, EventArgs e)
        {
            common.killOnScreenKeyboard();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            common.killOnScreenKeyboard();
        }
        #region Set Interface
        #endregion
        #region Khai báo biến
        #endregion
        #region Các hàm trên form
        #endregion
     
    }
}
