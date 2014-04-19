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
public class Staff : Layer
{
    // 
    #region KHAI BÁO CÁC ĐỐI TƯỢNG VÀ BIẾN CẦN DÙNG 
    // Các thuộc tính của lớp 
    public string Name {get;set;} 
    public DateTime DOB {get;set;} 
    public string Address {get;set;}
    public string Account { get; set; }
    public string Password { get; set; }
    public int Sex { get; set; }
    public int AccountType { get; set; }
    public int Site_ID { get; set; } 

    public string Phone {get;set;} 
    // Các đối tượng cần dùng của lớp 
    private DataAccessLayer.DataConfig dtConfig = new DataAccessLayer.DataConfig(); 
    private DataTable dtTable; 
    #endregion 
    // 
    #region CÁC THỦ TỤC LẤY THÔNG TIN 
    public DataTable GetListInforNotAdmin()
    {
        dtTable = new DataTable();
        string sql = "SELECT ROW_NUMBER() OVER(ORDER BY ID) AS STT,* From Staff where ID <> 1";
        try
        {
            dtTable = dtConfig.GetDataTable(sql);
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Error: " + ex.Message, "Get List Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return dtTable;
    } 
    public DataTable GetListInfor() 
    { 
        dtTable = new DataTable(); 
        string sql = "SELECT ROW_NUMBER() OVER(ORDER BY ID) AS STT,* From Staff"; 
        try 
        { 
            dtTable = dtConfig.GetDataTable(sql); 
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, "Get List Staff", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return dtTable; 
    } 
    public DataTable GetListInfor(int ID) 
    { 
        Staff obj = new Staff(); 
        dtTable = new DataTable(); 
        string sql = "Select * From Staff Where ID Like N'%" + ID + "%' "; 
        try 
        { 
            dtTable = new DataTable(); 
            dtTable = dtConfig.GetDataTable(sql); 
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, " Get List Staff ", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return dtTable; 
    } 
    // Lấy thông tin đối tượng 
    public override Layer GetInfor(int ID) 
    { 
        Staff obj = new Staff(); 
        dtTable = new DataTable(); 
        string sql = "Select * From Staff Where ID=N'" + ID + "' "; 
        try 
        { 
            dtTable = new DataTable(); 
            dtTable = dtConfig.GetDataTable(sql); 
            if (dtTable.Rows.Count > 0) 
            { 
                try{ obj.ID = int.Parse(dtTable.Rows[0]["ID"].ToString());} 
                catch (FormatException) { obj.ID = 0; } 
                obj.Name = dtTable.Rows[0]["Name"].ToString(); 
                try{ obj.DOB = DateTime.Parse(dtTable.Rows[0]["DOB"].ToString());} 
                catch (FormatException) { } 
                obj.Address = dtTable.Rows[0]["Address"].ToString();
                obj.Account = dtTable.Rows[0]["Account"].ToString();
                obj.Password = dtTable.Rows[0]["Password"].ToString();
                try { obj.Sex = int.Parse(dtTable.Rows[0]["Sex"].ToString()); } 
                catch (FormatException) { obj.Sex = 0; }
                try { obj.AccountType = int.Parse(dtTable.Rows[0]["AccountType"].ToString()); }
                catch (FormatException) { obj.Sex = 0; }
                try { obj.Site_ID = int.Parse(dtTable.Rows[0]["Site_ID"].ToString()); }
                catch (FormatException) { obj.Sex = 0; } 
                obj.Phone = dtTable.Rows[0]["Phone"].ToString(); 
                try{ obj.Created = dtTable.Rows[0]["Created"].ToString();} 
                catch (FormatException) { } 
                try{ obj.Created_By = int.Parse(dtTable.Rows[0]["Created_By"].ToString());} 
                catch (FormatException) { obj.Created_By = 0; } 
                try{ obj.Modified = dtTable.Rows[0]["Modified"].ToString();} 
                catch (FormatException) { } 
                try{ obj.Modified_By = int.Parse(dtTable.Rows[0]["Modified_By"].ToString());} 
                catch (FormatException) { obj.Modified_By = 0; } 
            } 
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, " Get Infor Object Staff ", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return obj; 
    }
    public  Layer Login(string account,string password)
    {
        Staff obj = new Staff();
        dtTable = new DataTable();
        string sql = "Select * From Staff Where account=N'" + account + "' and password=N'"+password+"' ";
        try
        {
            dtTable = new DataTable();
            dtTable = dtConfig.GetDataTable(sql);
            if (dtTable.Rows.Count > 0)
            {
                try { obj.ID = int.Parse(dtTable.Rows[0]["ID"].ToString()); }
                catch (FormatException) { obj.ID = 0; }
                obj.Name = dtTable.Rows[0]["Name"].ToString();
                try { obj.DOB = DateTime.Parse(dtTable.Rows[0]["DOB"].ToString()); }
                catch (FormatException) { }
                obj.Address = dtTable.Rows[0]["Address"].ToString();
                obj.Account = dtTable.Rows[0]["Account"].ToString();
                obj.Password = dtTable.Rows[0]["Password"].ToString();
                try { obj.Sex = int.Parse(dtTable.Rows[0]["Sex"].ToString()); }
                catch (FormatException) { obj.Sex = 0; }
                try { obj.AccountType = int.Parse(dtTable.Rows[0]["AccountType"].ToString()); }
                catch (FormatException) { obj.Sex = 0; }
                try { obj.Site_ID = int.Parse(dtTable.Rows[0]["Site_ID"].ToString()); }
                catch (FormatException) { obj.Sex = 0; }
                obj.Phone = dtTable.Rows[0]["Phone"].ToString();
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
            MessageBox.Show("Error: " + ex.Message, " Get Infor Object Staff ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return obj;
    } 

    // Lấy mã ID tiếp theo 
    public string GetNextID() 
    { 
        string result = "", captionID = ""; 
        // Set your caption ID 
        captionID = "Staff_"; 
        int lastID = 0; 
        string sql = "Select TOP 1 ID From Staff ORDER BY ID DESC "; 
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
    public bool CheckInfor(Staff obj ) 
    { 
        bool ok = true; 
        if (obj.ID == null) 
        { 
            MessageBox.Show("ID is not null", " Check Infor Staff", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
        if (obj.Name == null) 
        { 
            MessageBox.Show("Name is not null", " Check Infor Staff", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
        if (obj.Sex == null) 
        { 
            MessageBox.Show("Sex is not null", " Check Infor Staff", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
        if (obj.Created == null) 
        { 
            MessageBox.Show("Created is not null", " Check Infor Staff", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
        if (obj.Created_By == null) 
        { 
            MessageBox.Show("Created_By is not null", " Check Infor Staff", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
        if (obj.Modified == null) 
        { 
            MessageBox.Show("Modified is not null", " Check Infor Staff", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
        if (obj.Modified_By == null) 
        { 
            MessageBox.Show("Modified_By is not null", " Check Infor Staff", MessageBoxButtons.OK, MessageBoxIcon.Error); 
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
        string sql = "Select Count(ID) From Staff Where ID=N'" + ID + "' "; 
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
    // Thêm mới thông tin Staff 
    public int Insert(Staff obj ) 
    {
        base.Insert(obj);
        int result = 0; 
        string sql =string.Format(" Insert Into Staff Values( N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', N'{9}'); SELECT SCOPE_IDENTITY () AS NewID" 
            , obj.ID, obj.Name, obj.DOB, obj.Address, obj.Sex, obj.Phone, obj.Created, obj.Created_By, obj.Modified, obj.Modified_By); 
        try 
        { 
            if(CheckExistPrimaryKey(obj.ID)) 
                MessageBox.Show("Error: Primary key have been exist", " Check Exist Primary Key", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            else 
                result = dtConfig.ExecuteScalarQuery1(sql); 
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, " Insert Infor Staff", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return result; 
    } 
    // Cập nhật thông tin Staff 
    public void ChangePass(string password)
    {
        try
        {
            dtConfig.ExecuteNoneQuery(" update staff set Password=N'" + password + "' where ID=" + SessionCur.staff.ID);
            ITrackLogsDAL _DALTracklog = new TrackLogsDAL();
            _DALTracklog.Insert(new Models.TrackLog() { Action = "Login staff:" + SessionCur.staff.ID, Type = "Login", TimeAction = DateTime.Now, Staff_ID = SessionCur.staff.ID });
              //dtConfig.InsertTrackLog("Login staff:" + SessionCur.staff.ID, "Login");
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Error: " + ex.Message, " Update Infor Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
        } 
    }
    public void Logout()
    {
        try
        {
            ITrackLogsDAL _DALTracklog = new TrackLogsDAL();
            _DALTracklog.Insert(new Models.TrackLog() { Action = "Logout staff:" + SessionCur.staff.ID, Type = "Logout", TimeAction = DateTime.Now, Staff_ID = SessionCur.staff.ID });
            //dtConfig.InsertTrackLog("Logout staff:" + SessionCur.staff.ID, "Logout");
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Error: " + ex.Message, " Update Infor Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    public int Update(Staff obj ) 
    {
        base.Update(obj);
        int result = 0;
        string sql = string.Format(" Update Staff Set  Name= N'{1}', DOB= N'{2}', Address= N'{3}', Sex= N'{4}', Phone= N'{5}', Modified= N'{6}', Modified_By= N'{7}' where ID={0}"
            , obj.ID, obj.Name, obj.DOB, obj.Address, obj.Sex, obj.Phone, obj.Modified, obj.Modified_By);
        try 
        { 
            if(!CheckExistPrimaryKey(obj.ID)) 
                MessageBox.Show("Error: Primary key isn't exist", " Check Exist Primary Key", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            else 
                result = dtConfig.ExecuteNoneQuery(sql); 
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, " Update Infor Staff", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return result; 
    } 
    // Xóa thông tin Staff 
    public int Delete(Staff obj ) 
    { 
        int result = 0; 
        string sql =string.Format(" Delete From Staff Where ID = N'{0}'" 
            , obj.ID); 
        try 
        { 
            if(!CheckExistPrimaryKey(obj.ID)) 
                MessageBox.Show("Error: Primary key isn't exist", " Check Exist Primary Key", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            else 
                result = dtConfig.ExecuteNoneQuery(sql); 
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, " Delete Infor Staff", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return result; 
    } 
    #endregion 
    // 
}
 } 
