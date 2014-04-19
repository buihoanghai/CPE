using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL.Implement.CPE_vs1DAL;

namespace CPE_vs1
{
    public partial class Promotion : DevExpress.XtraEditors.XtraForm
    {
        #region variable
        IPromotionsDAL promotionDAL=new PromotionsDAL();
        Models.Promotion promoCur = new Models.Promotion();
        #endregion
        #region method
        private void GetAllPromotion()
        {
            GridPromotion.DataSource = promotionDAL.SelectAll();
        }
        private void GetPromoFromGrid()
        {
            promoCur = (Models.Promotion)gridViewPromotion.GetFocusedRow();
            spinDiscount.EditValue = promoCur.Discount;
            txtPromotionName.Text = promoCur.PromotionName;
        }
        private void ClearControl()
        {
            promoCur = new Models.Promotion();
            txtPromotionName.Text = "";
            spinDiscount.EditValue = 0;
        }
        private void UpdatePromotion()
        {
            GetPromoFromControl();
            promotionDAL.Update(promoCur);
        }

        private void InsertPromotion()
        {
            GetPromoFromControl();
            promotionDAL.Insert(promoCur);
        }

        private void GetPromoFromControl()
        {
            promoCur.PromotionName = txtPromotionName.Text;
            promoCur.Discount = int.Parse(spinDiscount.Text);
        }
        #endregion
        public Promotion()
        {
            InitializeComponent();
        }

        private void Promotion_Load(object sender, EventArgs e)
        {
            GetAllPromotion();
        }

        private void GridPromotion_DoubleClick(object sender, EventArgs e)
        {
            GetPromoFromGrid();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            ClearControl();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (valid.Validate())
            {
                if (promoCur.ID == 0)
                {
                    InsertPromotion();
                }
                else
                {
                    UpdatePromotion();
                }
                GetAllPromotion();
                ClearControl();
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                promoCur = (Models.Promotion)gridViewPromotion.GetFocusedRow();
                promotionDAL.DeleteByID(promoCur.ID);
                GetAllPromotion();
            }
        }

        private void txtPromotionName_MouseDown(object sender, MouseEventArgs e)
        {
            common.openOnScreenKeyboard();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            common.killOnScreenKeyboard();
        }

        
    }
}