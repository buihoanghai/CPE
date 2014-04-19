using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CPE_vs1.BusinessLayer;
using CPE_vs1.Interface;
namespace CPE_vs1
{
    public partial class PenaltyManagement : DevExpress.XtraEditors.XtraForm
    {
        public PenaltyManagement()
        {
            InitializeComponent();
            SetGridAlgorithm(new DevGridAlgorithm());
            SetComboboxAlgorithm(new LookUpAlgorithm());
        }
        #region Set các interface
        void SetGridAlgorithm(IGridAlgorithm IGrid)
        {
            this.IGrid = IGrid;
        }
        void SetComboboxAlgorithm(IComboboxAlgorithm ICombo)
        {
            this.ICombo = ICombo;
        }
        #endregion
        #region Khai báo biến
        IGridAlgorithm IGrid;
        IComboboxAlgorithm ICombo;
        Penalty penaltyCur = new Penalty();
        enum Tab
        {
            Recently = 0,
            DataBase
        };
        #endregion
        #region các hàm trên form
        void getPenaltyCurValueInForm()
        {
            penaltyCur.Amount = Convert.ToDecimal(textAmount.Text);
            penaltyCur.Percents = common.parseInt(textPercent.Text);
            penaltyCur.Title = textTitle.Text;
            penaltyCur.StatusCPE = Convert.ToInt16( LookUpStatus.EditValue);
        }
        void loadListPenalty()
        {
            gridControlDataBase.DataSource = penaltyCur.GetListInforByPackage();
        }
        void LoadPenaltyCur()
        {
            textAmount.Text = common.toString(penaltyCur.Amount);
            textPercent.Text = common.toString(penaltyCur.Percents);
            textTitle.Text = common.toString(penaltyCur.Title);
            LookUpStatus.EditValue = penaltyCur.StatusCPE;
        }
        void loadRowCur()
        {
            DataRow dt = IGrid.getRowCur(gridViewDatabase);
            if (dt == null)
                return;
            penaltyCur =(Penalty) penaltyCur.GetInfor(common.parseInt(dt["ID"]));
            loadValueInForm();
            ControlPackagePanaltyRecords.Enabled = false;
        }
        void loadValueInForm()
        {
            LoadPenaltyCur();
        }
        void newPenaltyCurInForm()
        {
            penaltyCur = new Penalty();
            textTitle.Text = "";
            textPercent.Text = "";
            textAmount.Text = "";
            ControlPackagePanaltyRecords.Enabled = true;
        }

        #endregion
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            newPenaltyCurInForm();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            loadRowCur();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want delete it?", "Warn!", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                DataRow dt = IGrid.getRowCur(gridViewDatabase);
                Penalty penalty = (Penalty)penaltyCur.GetInfor(common.parseInt(dt["ID"]));
                penalty.Delete(penalty);
                loadListPenalty();
                ControlPackagePanaltyRecords.Enabled = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            getPenaltyCurValueInForm();
            if (penaltyCur.ID == 0)
                penaltyCur.ID = penaltyCur.Insert(penaltyCur);
            else
            {
                penaltyCur.Update(penaltyCur);
            }
            loadListPenalty();
            newPenaltyCurInForm();
        }
        private void gridViewNew_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            loadRowCur();
        }

        private void PackagePenalty_Load(object sender, EventArgs e)
        {
            ICombo.loadLookUp(EnumConfig.getTableFromEnum(EnumConfig.CPEStatusPenalty.Available), LookUpStatus);
            loadListPenalty();
            newPenaltyCurInForm();
            LookUpStatus.ItemIndex = 0;
        }

        private void textTitle_MouseDown(object sender, MouseEventArgs e)
        {
            common.openOnScreenKeyboard();
        }

        private void PenaltyManagement_Click(object sender, EventArgs e)
        {
            common.killOnScreenKeyboard();
            UserSession.ResetTimer();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            common.killOnScreenKeyboard();
            UserSession.ResetTimer();
        }

        private void gridControlDataBase_DoubleClick(object sender, EventArgs e)
        {
            loadRowCur();
        }
    }
}