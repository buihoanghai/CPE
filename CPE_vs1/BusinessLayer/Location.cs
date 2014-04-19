// Khai báo các namespace cần dùng 
using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using CPE_vs1.DataAccessLayer;
using System.Windows.Forms;

namespace CPE_vs1.BusinessLayer
{
    // Class DataAccessLayer 
    public  class Location : Layer
    {
        // 
        #region KHAI BÁO CÁC ĐỐI TƯỢNG VÀ BIẾN CẦN DÙNG
        // Các thuộc tính của lớp 
        public int Site_ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        // Các đối tượng cần dùng của lớp 
        private DataAccessLayer.DataConfig dtConfig = new DataAccessLayer.DataConfig();
        private DataTable dtTable;
        #endregion
        // 
        #region CÁC THỦ TỤC LẤY THÔNG TIN
        public DataTable GetListInfor()
        {
            dtTable = new DataTable();
            string sql = "SELECT ROW_NUMBER() OVER(ORDER BY ID) AS STT,* From Location";
            try
            {
                dtTable = dtConfig.GetDataTable(sql);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Get List Location", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dtTable;
        }
        public DataTable GetListInfor(int ID)
        {
            Location obj = new Location();
            dtTable = new DataTable();
            string sql = "Select * From Location Where ID Like N'%" + ID + "%' ";
            try
            {
                dtTable = new DataTable();
                dtTable = dtConfig.GetDataTable(sql);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, " Get List Location ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dtTable;
        }
        public DataTable GetListInforBySite(int Site_ID)
        {
            dtTable = new DataTable();
            string sql = string.Format("SELECT ROW_NUMBER() OVER(ORDER BY ID) AS STT,* From Location where Site_ID={0}", Site_ID);
            try
            {
                dtTable = dtConfig.GetDataTable(sql);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Get List Location", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dtTable;
        } 
        // Lấy thông tin đối tượng 
        public override Layer GetInfor(int ID)
        {
            Location obj = new Location();
            dtTable = new DataTable();
            string sql = "Select * From Location Where ID=N'" + ID + "' ";
            try
            {
                dtTable = new DataTable();
                dtTable = dtConfig.GetDataTable(sql);
                if (dtTable.Rows.Count > 0)
                {
                    try { obj.ID = int.Parse(dtTable.Rows[0]["ID"].ToString()); }
                    catch (FormatException) { obj.ID = 0; }
                    try { obj.Site_ID = int.Parse(dtTable.Rows[0]["Site_ID"].ToString()); }
                    catch (FormatException) { obj.Site_ID = 0; }
                    obj.Name = dtTable.Rows[0]["Name"].ToString();
                    obj.Address = dtTable.Rows[0]["Address"].ToString();
                    try { obj.Created = dtTable.Rows[0]["Created"].ToString(); }
                    catch (FormatException) { }
                    try { obj.Created_By = int.Parse(dtTable.Rows[0]["Created_By"].ToString()); }
                    catch (FormatException) { obj.Created_By = 0; }
                    try { obj.Modified = dtTable.Rows[0]["Modified"].ToString(); }
                    catch (FormatException) { }
                    try { obj.Modified_By = int.Parse(dtTable.Rows[0]["Modified_By"].ToString()); }
                    catch (FormatException) { obj.Modified_By = 0; }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, " Get Infor Object Location ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return obj;
        }
        // Lấy mã ID tiếp theo 
        public string GetNextID()
        {
            string result = "", captionID = "";
            // Set your caption ID 
            captionID = "Location_";
            int lastID = 0;
            string sql = "Select TOP 1 ID From Location ORDER BY ID DESC ";
            try
            {
                result = dtConfig.ExecuteScalarQuery(sql);
                result = result.Remove(0, captionID.Length);
                lastID = int.Parse(result);
            }
            catch { }
            do
            {
                lastID++;
                result = lastID.ToString();
                while (result.Length < 5)
                    result = "0" + result;
                result = captionID + result;
            }
            while (CheckExistPrimaryKey(result));
            return result;
        }
        // Kiểm tra thông tin  
        public bool CheckInfor(Location obj)
        {
            bool ok = true;
            if (obj.ID == null)
            {
                MessageBox.Show("ID is not null", " Check Infor Location", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (obj.Site_ID == null)
            {
                MessageBox.Show("Site_ID is not null", " Check Infor Location", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (obj.Created == null)
            {
                MessageBox.Show("Created is not null", " Check Infor Location", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (obj.Created_By == null)
            {
                MessageBox.Show("Created_By is not null", " Check Infor Location", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (obj.Modified == null)
            {
                MessageBox.Show("Modified is not null", " Check Infor Location", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (obj.Modified_By == null)
            {
                MessageBox.Show("Modified_By is not null", " Check Infor Location", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
        // Kiểm tra khóa chính đã tồn tại chưa? Nếu rồi thì trả về true, ngược lại thì false! 
        public bool CheckExistPrimaryKey(object ID)
        {
            bool ok = false;
            int result = 0;
            string sql = "Select Count(ID) From Location Where ID=N'" + ID + "' ";
            try
            {
                result = int.Parse(dtConfig.ExecuteScalarQuery(sql));
                if (result > 0) ok = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, " Check Exist Primary Key ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ok;
        }
        #endregion
        // 
        #region CÁC THỦ TỤC THÊM, SỬA, XÓA THÔNG TIN
        // Thêm mới thông tin Location 
        public int Insert(Location obj)
        {
            base.Insert(obj);
            int result = 0;
            string sql = string.Format("Insert into Location Values(N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}'); SELECT SCOPE_IDENTITY () As NewID"
                , obj.ID, obj.Site_ID, obj.Name, obj.Address, obj.Created, obj.Created_By, obj.Modified, obj.Modified_By);
            try
            {
                if (CheckExistPrimaryKey(obj.ID))
                    MessageBox.Show("Error: Primary key have been exist", " Check Exist Primary Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    result = dtConfig.ExecuteScalarQuery1(sql);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, " Insert Infor Location", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        // Cập nhật thông tin Location 
        public int Update(Location obj)
        {
            base.Update(obj);
            int result = 0;
            string sql = string.Format(" Update Location Set Site_ID= N'{1}', Name= N'{2}', Address= N'{3}', Modified= N'{4}', Modified_By= N'{5}' where ID={0}"
                , obj.ID, obj.Site_ID, obj.Name, obj.Address, obj.Modified, obj.Modified_By);
            try
            {
                if (!CheckExistPrimaryKey(obj.ID))
                    MessageBox.Show("Error: Primary key isn't exist", " Check Exist Primary Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    result = dtConfig.ExecuteNoneQuery(sql);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, " Update Infor Location", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        // Xóa thông tin Location 
        public int Delete(Location obj)
        {
            int result = 0;
            string sql = string.Format(" Delete From Location Where ID = N'{0}'"
                , obj.ID);
            try
            {
                if (!CheckExistPrimaryKey(obj.ID))
                    MessageBox.Show("Error: Primary key isn't exist", " Check Exist Primary Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    result = dtConfig.ExecuteNoneQuery(sql);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, " Delete Infor Location", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        #endregion
        // 
    }
}
