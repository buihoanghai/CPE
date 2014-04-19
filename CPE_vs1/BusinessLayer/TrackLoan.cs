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
    public class TrackLoan : Layer
{
    // 
    #region KHAI BÁO CÁC ĐỐI TƯỢNG VÀ BIẾN CẦN DÙNG 
    // Các thuộc tính của lớp 
      int costOfPurchase=  0; 
public int CostOfPurchase 
{
get {
    return CostOfPurchase;
}
    set{
        costOfPurchase = value;
    }
}


public int LoanDetail_ID { get; set; }
public int Package_ID { get; set; }
public int Type { get; set; }
//public DateTime Modified {get;set;} 
    // Các đối tượng cần dùng của lớp 
    private DataAccessLayer.DataConfig dtConfig = new DataAccessLayer.DataConfig(); 
    private DataTable dtTable; 
    #endregion 
    // 
    #region CÁC THỦ TỤC LẤY THÔNG TIN 
    public DataTable GetListInfor() 
    { 
        dtTable = new DataTable(); 
        string sql = "SELECT ROW_NUMBER() OVER(ORDER BY ID) AS STT,* From TrackLoan"; 
        try 
        { 
            dtTable = dtConfig.GetDataTable(sql); 
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, "Get List TrackLoan", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return dtTable; 
    } 
    public DataTable GetListInfor(int ID) 
    { 
        TrackLoan obj = new TrackLoan(); 
        dtTable = new DataTable(); 
        string sql = "Select * From TrackLoan Where ID Like N'%" + ID + "%' "; 
        try 
        { 
            dtTable = new DataTable(); 
            dtTable = dtConfig.GetDataTable(sql); 
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, " Get List TrackLoan", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return dtTable; 
    } 
    // Lấy thông tin đối tượng 
    TrackLoan getCPE(string sql)
    {
        TrackLoan obj = new TrackLoan();
        dtTable = new DataTable();
        try
        {
            dtTable = new DataTable();
            dtTable = dtConfig.GetDataTable(sql);
            if (dtTable.Rows.Count > 0)
            {
                try { obj.ID = int.Parse(dtTable.Rows[0]["ID"].ToString()); }
                catch (FormatException) { obj.ID = 0; }
                try { obj.LoanDetail_ID = int.Parse(dtTable.Rows[0]["LoanDetail_ID"].ToString()); }
                catch (FormatException) { obj.LoanDetail_ID = 0; }
                try { obj.Package_ID = int.Parse(dtTable.Rows[0]["Package_ID"].ToString()); }
                catch (FormatException) { obj.Package_ID = 0; }
                try { obj.Type = int.Parse(dtTable.Rows[0]["Type"].ToString()); }
                catch (FormatException) { obj.Type = 0; }
                try { obj.Modified_By = int.Parse(dtTable.Rows[0]["Modified_By"].ToString()); }
                catch (FormatException) { obj.Modified_By = 0; }
                try { obj.Created = dtTable.Rows[0]["Created"].ToString(); }
                catch (FormatException) { }
                try { obj.Created_By = int.Parse(dtTable.Rows[0]["Created_By"].ToString()); }
                catch (FormatException) { obj.Created_By = 0; }
                try { obj.Modified = dtTable.Rows[0]["Modified"].ToString(); }
                catch (FormatException) { }
            }
            else
                return null;
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Error: " + ex.Message, " Get Infor Object TrackLoan", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return obj;
    }
    public TrackLoan GetInfor(string CPE)
    {
        string sql = string.Format("Select * From TrackLoan Where Barcode=N'{0}' or SerialNumber=N'{0}' ", CPE);
        return getCPE(sql);
    }
    public override Layer GetInfor(int ID) 
    {
        string sql = "Select * From TrackLoan Where ID=N'" + ID + "' ";
        return getCPE(sql);
    } 
    // Lấy mã ID tiếp theo 
    public string GetNextID() 
    { 
        string result = "", captionID = ""; 
        // Set your caption ID 
        captionID = "CPE_"; 
        int lastID = 0; 
        string sql = "Select TOP 1 ID From TrackLoan ORDER BY ID DESC "; 
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
    public bool CheckInfor(TrackLoan obj ) 
    { 
        bool ok = true; 
        if (obj.ID == null) 
        { 
            MessageBox.Show("ID is not null", " Check Infor CPE", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
        if (obj.Modified_By == null) 
        { 
            MessageBox.Show("Modified_By is not null", " Check Infor CPE", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
        if (obj.Created == null) 
        { 
            MessageBox.Show("Created is not null", " Check Infor CPE", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
        if (obj.Created_By == null) 
        { 
            MessageBox.Show("Created_By is not null", " Check Infor CPE", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
        if (obj.Modified == null) 
        { 
            MessageBox.Show("Modified is not null", " Check Infor CPE", MessageBoxButtons.OK, MessageBoxIcon.Error); 
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
        string sql = "Select Count(ID) From TrackLoan Where ID=N'" + ID + "' "; 
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
    // Thêm mới thông tin TrackLoan
    public int Insert(TrackLoan obj ) 
    {
        base.Insert(obj);
        int result = 0;
        string sql = string.Format(" Insert Into TrackLoan Values( N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}'); SELECT SCOPE_IDENTITY () As NewID"
            , obj.ID, obj.LoanDetail_ID, obj.Package_ID, obj.Type, obj.Created, obj.Created_By, obj.Modified, obj.Modified_By); 
        try 
        { 
            if(CheckExistPrimaryKey(obj.ID)) 
                MessageBox.Show("Error: Primary key have been exist", " Check Exist Primary Key", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            else 
                result = dtConfig.ExecuteScalarQuery1(sql); 
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, " Insert Infor CPE", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return result; 
    } 
    // Cập nhật thông tin TrackLoan
    public int Update(TrackLoan obj ) 
    {
        base.Update(obj);
        int result = 0;
        obj.Modified = common.toFormatTime(DateTime.Now);
        string sql = string.Format(" Update TrackLoan Set LoanDetail_ID= N'{1}', Package_ID= N'{2}',  Type= N'{3}',Modified_By= N'{4}', Modified= N'{5}',where ID={0}"
            , obj.ID, obj.LoanDetail_ID, obj.Package_ID, obj.Type, obj.Modified_By, obj.Modified);
        try 
        { 
            if(!CheckExistPrimaryKey(obj.ID)) 
                MessageBox.Show("Error: Primary key isn't exist", " Check Exist Primary Key", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            else 
                result = dtConfig.ExecuteNoneQuery(sql); 
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, " Update Infor CPE", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return result; 
    } 
    // Xóa thông tin TrackLoan
    public int Delete(TrackLoan obj ) 
    { 
        int result = 0; 
        string sql =string.Format(" Delete From TrackLoan Where ID = N'{0}'" 
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
            MessageBox.Show("Error: " + ex.Message, " Delete Infor CPE", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return result; 
    }
    public int DeleteByLoanID(int LoanDetail_ID)
    {
        int result = 0;
        string sql = string.Format(" Delete From TrackLoan Where LoanDetail_ID = N'{0}'"
            , LoanDetail_ID);
        try
        {
                result = dtConfig.ExecuteNoneQuery(sql);
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Error: " + ex.Message, " Delete Infor CPE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return result;
    }
    public int DeleteByLoanIDReturn(int LoanDetail_ID)
    {
        int result = 0;
        string sql = string.Format(" Delete From TrackLoan Where Type=2 and LoanDetail_ID = N'{0}'"
            , LoanDetail_ID);
        try
        {
            result = dtConfig.ExecuteNoneQuery(sql);
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Error: " + ex.Message, " Delete Infor CPE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return result;
    } 
    #endregion 
    // 
}
 } 
