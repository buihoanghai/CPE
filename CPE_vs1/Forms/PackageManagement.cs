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
    public partial class PackageManagement : DevExpress.XtraEditors.XtraForm
    {
        public PackageManagement()
        {
            InitializeComponent();
            SetComboboxAlgorithm(new LookUpAlgorithm());
            SetGridAlgorithm(new DevGridAlgorithm());
        }
        #region Set các interface
        void SetComboboxAlgorithm(IComboboxAlgorithm ICombo)
        {
            this.ICombo = ICombo;
        }
        void SetGridAlgorithm(IGridAlgorithm IGrid)
        {
            this.IGrid = IGrid;
        }
        #endregion
       
        #region Khai báo biến
        IGridAlgorithm IGrid;
        IComboboxAlgorithm ICombo;
        CPE_vs1.BusinessLayer.Package packageCur = new CPE_vs1.BusinessLayer.Package();
        enum Tab
        {
            Recently = 0,
            DataBase
        };
        #endregion
        #region các hàm trên form
        void getPackageCurValueInForm()
        {
            packageCur.Days = common.parseInt(textDay.Text);
            packageCur.Name = textPackageName.Text;
            packageCur.EOM = common.parseInt(LookUpEOM.EditValue);
          //  packageCur.DepositAmount = common.parseDecimal(textDepositAmount.Text);
            packageCur.Price = Convert.ToDecimal(textPackagePrice.Text);
        }
        void loadListPackage()
        {
            gridControlDatabase.DataSource = packageCur.GetListInfor1();
        }
     
        void loadRowCur()
        {
            DataRow dt = IGrid.getRowCur(gridViewDatabase);
            if (dt == null)
                return;
            packageCur =(Package) packageCur.GetInfor(common.parseInt(dt["ID"]));
            loadValueInForm();
            //ControlPackgeRecords.Enabled = false;
        }
        void LoadPackageCur()
        {
            textDay.Text = common.toString(packageCur.Days);
            textPackageName.Text = packageCur.Name;
            textPackagePrice.Text = common.toString(packageCur.Price);
            LookUpEOM.EditValue = packageCur.EOM;
        }
        void loadValueInForm()
        {
            LoadPackageCur();
        }
        void newPackageCurInForm()
        {
            packageCur = new BusinessLayer.Package();
            textDay.Text = "";
            textPackageName.Text = "";
            textPackagePrice.Text = "";
            ControlPackgeRecords.Enabled = true;
        }

        #endregion
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            newPackageCurInForm();
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
                BusinessLayer.Package package =(Package) packageCur.GetInfor(common.parseInt(dt["ID"]));
                package.Delete(package);
                loadListPackage();
                ControlPackgeRecords.Enabled = true;
            }
        }
        private void Package_Load(object sender, EventArgs e)
        {
            loadListPackage();
            ICombo.loadLookUp(EnumConfig.getTableFromEnum(EnumConfig.OEM.Nomarl), LookUpEOM);
            LookUpEOM.ItemIndex = 0;
            newPackageCurInForm();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            getPackageCurValueInForm();
            if (packageCur.ID == 0)
                packageCur.ID = packageCur.Insert(packageCur);
            else
            {
                packageCur.Update(packageCur);
            }
            if (packageCur.ID >0)
            {
                loadListPackage();
                newPackageCurInForm();
            }
        }
     
        private void gridViewDatabase_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            loadRowCur();
        }

        private void textPackageName_MouseDown(object sender, MouseEventArgs e)
        {
            common.openOnScreenKeyboard();
        }

        private void PackageManagement_Click(object sender, EventArgs e)
        {
            common.killOnScreenKeyboard();
            UserSession.ResetTimer();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            common.killOnScreenKeyboard();
            UserSession.ResetTimer();
        }

    }
}