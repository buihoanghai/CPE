// Khai báo các namespace cần dùng 
using System; 
using System.Text; 
using System.Data; 
using System.Data.SqlClient; 
using CPE_vs1.DataAccessLayer; 
using System.Windows.Forms;
using DAL.Implement.CPE_vs1DAL; 

namespace CPE_vs1.BusinessLayer 
 {
// Class DataAccessLayer 
public class Loan :Layer
{
    // 
    #region KHAI BÁO CÁC ĐỐI TƯỢNG VÀ BIẾN CẦN DÙNG 
    // Các thuộc tính của lớp 
    public int Customer_ID {get;set;} 
    public int Staff_ID {get;set;}
    public int Status { get; set; }
    public string CustomerCode { get; set; }
    public string CustomerBarcode { get; set; }
    // Các đối tượng cần dùng của lớp 
    private DataAccessLayer.DataConfig dtConfig = new DataAccessLayer.DataConfig(); 
    private DataTable dtTable; 
    #endregion 
    // 
    #region CÁC THỦ TỤC LẤY THÔNG TIN 
    public DataTable GetListInfor() 
    { 
        dtTable = new DataTable(); 
        string sql = "SELECT ROW_NUMBER() OVER(ORDER BY ID) AS STT,* From Loan"; 
        try 
        { 
            dtTable = dtConfig.GetDataTable(sql); 
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, "Get List Loan", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return dtTable; 
    } 
    public DataTable GetListInfor(int ID) 
    { 
        Loan obj = new Loan(); 
        dtTable = new DataTable(); 
        string sql = "Select * From Loan Where ID Like N'%" + ID + "%' "; 
        try 
        { 
            dtTable = new DataTable(); 
            dtTable = dtConfig.GetDataTable(sql); 
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, " Get List Loan ", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return dtTable; 
    } 
    // Lấy thông tin đối tượng 
    public override Layer GetInfor(int ID) 
    { 
        Loan obj = new Loan(); 
        dtTable = new DataTable(); 
        string sql = "Select * From Loan Where ID=N'" + ID + "' "; 
        try 
        { 
            dtTable = new DataTable(); 
            dtTable = dtConfig.GetDataTable(sql); 
            if (dtTable.Rows.Count > 0) 
            { 
                try{ obj.ID = int.Parse(dtTable.Rows[0]["ID"].ToString());} 
                catch (FormatException) { obj.ID = 0; } 
                try{ obj.Customer_ID = int.Parse(dtTable.Rows[0]["Customer_ID"].ToString());} 
                catch (FormatException) { obj.Customer_ID = 0; } 
                try{ obj.Staff_ID = int.Parse(dtTable.Rows[0]["Staff_ID"].ToString());} 
                catch (FormatException) { obj.Staff_ID = 0; }
                try { obj.Status = int.Parse(dtTable.Rows[0]["Status"].ToString()); }
                catch (FormatException) { obj.Status = 0; } 
                try{ obj.Modified_By = int.Parse(dtTable.Rows[0]["Modified_By"].ToString());} 
                catch (FormatException) { obj.Modified_By = 0; } 
                try{ obj.Created = dtTable.Rows[0]["Created"].ToString();} 
                catch (FormatException) { } 
                try{ obj.Created_By = int.Parse(dtTable.Rows[0]["Created_By"].ToString());} 
                catch (FormatException) { obj.Created_By = 0; } 
                try{ obj.Modified = dtTable.Rows[0]["Modified"].ToString();} 
                catch (FormatException) { }
                try { obj.CustomerCode = dtTable.Rows[0]["CustomerCode"].ToString(); }
                catch (FormatException) { }
                try { obj.CustomerBarcode = dtTable.Rows[0]["CustomerBarcode"].ToString(); }
                catch (FormatException) { } 
            } 
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, " Get Infor Object Loan ", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return obj; 
    }
    public Layer GetInforByCustomerCode(string customercode)
    {
        Loan obj = new Loan();
        dtTable = new DataTable();
        string sql = "Select * From Loan Where CustomerCode=N'" + customercode + "' ";
        try
        {
            dtTable = new DataTable();
            dtTable = dtConfig.GetDataTable(sql);
            if (dtTable.Rows.Count > 0)
            {
                try { obj.ID = int.Parse(dtTable.Rows[0]["ID"].ToString()); }
                catch (FormatException) { obj.ID = 0; }
                try { obj.Customer_ID = int.Parse(dtTable.Rows[0]["Customer_ID"].ToString()); }
                catch (FormatException) { obj.Customer_ID = 0; }
                try { obj.Staff_ID = int.Parse(dtTable.Rows[0]["Staff_ID"].ToString()); }
                catch (FormatException) { obj.Staff_ID = 0; }
                try { obj.Status = int.Parse(dtTable.Rows[0]["Status"].ToString()); }
                catch (FormatException) { obj.Status = 0; }
                try { obj.Modified_By = int.Parse(dtTable.Rows[0]["Modified_By"].ToString()); }
                catch (FormatException) { obj.Modified_By = 0; }
                try { obj.Created = dtTable.Rows[0]["Created"].ToString(); }
                catch (FormatException) { }
                try { obj.Created_By = int.Parse(dtTable.Rows[0]["Created_By"].ToString()); }
                catch (FormatException) { obj.Created_By = 0; }
                try { obj.Modified = dtTable.Rows[0]["Modified"].ToString(); }
                catch (FormatException) { }
                try { obj.CustomerCode = dtTable.Rows[0]["CustomerCode"].ToString(); }
                catch (FormatException) { }
                try { obj.CustomerBarcode = dtTable.Rows[0]["CustomerBarcode"].ToString(); }
                catch (FormatException) { }
            }
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Error: " + ex.Message, " Get Infor Object Loan ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return obj;
    } 
    // Lấy mã ID tiếp theo 
    public string GetNextID() 
    { 
        string result = "", captionID = ""; 
        // Set your caption ID 
        captionID = "Loan_"; 
        int lastID = 0; 
        string sql = "Select TOP 1 ID From Loan ORDER BY ID DESC "; 
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
    public bool CheckInfor(Loan obj ) 
    { 
        bool ok = true; 
        if (obj.ID == null) 
        { 
            MessageBox.Show("ID is not null", " Check Infor Loan", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
        if (obj.Customer_ID == null) 
        { 
            MessageBox.Show("Customer_ID is not null", " Check Infor Loan", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
        if (obj.Staff_ID == null) 
        { 
            MessageBox.Show("Staff_ID is not null", " Check Infor Loan", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
        if (obj.Modified_By == null) 
        { 
            MessageBox.Show("Modified_By is not null", " Check Infor Loan", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
        if (obj.Created == null) 
        { 
            MessageBox.Show("Created is not null", " Check Infor Loan", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
        if (obj.Created_By == null) 
        { 
            MessageBox.Show("Created_By is not null", " Check Infor Loan", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
        if (obj.Modified == null) 
        { 
            MessageBox.Show("Modified is not null", " Check Infor Loan", MessageBoxButtons.OK, MessageBoxIcon.Error); 
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
        string sql = "Select Count(ID) From Loan Where ID=N'" + ID + "' "; 
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
    // Thêm mới thông tin Loan 
    public int Insert(Loan obj ) 
    {
        base.Insert(obj);
        int result = 0;
        string sql = string.Format(" Insert Into Loan(Customer_ID,Staff_ID,Status,Modified_By,Created,Created_By,Modified) Values( N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}',N'{7}'); SELECT SCOPE_IDENTITY () as NewID" 
            , obj.ID, obj.Customer_ID, obj.Staff_ID,obj.Status, obj.Modified_By, obj.Created, obj.Created_By, obj.Modified); 
        try 
        {
            if (CheckExistPrimaryKey(obj.ID))
                MessageBox.Show("Error: Primary key have been exist", " Check Exist Primary Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                result = dtConfig.ExecuteScalarQuery1(sql);
                ITrackLogsDAL _DALTracklog = new TrackLogsDAL();
                _DALTracklog.Insert(new Models.TrackLog() { Action = "Insert Loan ID: " + result, Type = "Insert", TimeAction = DateTime.Now, Staff_ID = SessionCur.staff.ID });
                //dtConfig.InsertTrackLog("Insert Loan ID: " + result, "Insert");
            }
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, " Insert Infor Loan", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return result; 
    } 
    // Cập nhật thông tin Loan 
    public int Update(Loan obj ) 
    {
        base.Update(obj);
        int result = 0;
        string sql = string.Format(" Update Loan Set  Customer_ID= N'{1}', Staff_ID= N'{2}', Status= N'{3}', Modified_By= N'{4}', Modified= N'{5}' where ID={0}"
            , obj.ID, obj.Customer_ID, obj.Staff_ID, obj.Status, obj.Modified_By, obj.Modified);
        try 
        {
            if (!CheckExistPrimaryKey(obj.ID))
                MessageBox.Show("Error: Primary key isn't exist", " Check Exist Primary Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else

            { result = dtConfig.ExecuteNoneQuery(sql);
            ITrackLogsDAL _DALTracklog = new TrackLogsDAL();
            _DALTracklog.Insert(new Models.TrackLog() { Action = "Update Loan ID: " + obj.ID, Type = "Update", TimeAction = DateTime.Now, Staff_ID = SessionCur.staff.ID });
            //dtConfig.InsertTrackLog("Update Loan ID: " + obj.ID, "Update");
            }
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, " Update Infor Loan", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return result; 
    } 
    // Xóa thông tin Loan 
    public int Delete(Loan obj ) 
    { 
        int result = 0; 
        string sql =string.Format(" Delete From Loan Where ID = N'{0}'" 
            , obj.ID); 
        try 
        {
            if (!CheckExistPrimaryKey(obj.ID))
                MessageBox.Show("Error: Primary key isn't exist", " Check Exist Primary Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                result = dtConfig.ExecuteNoneQuery(sql);
                ITrackLogsDAL _DALTracklog = new TrackLogsDAL();
                _DALTracklog.Insert(new Models.TrackLog() { Action = "Delete Loan ID: " + obj.ID, Type = "Delete", TimeAction = DateTime.Now, Staff_ID = SessionCur.staff.ID });
                //dtConfig.InsertTrackLog("Delete Loan ID: " + obj.ID, "Delete");
            }
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, " Delete Infor Loan", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return result; 
    } 
    #endregion 
    // 
}
 } 
