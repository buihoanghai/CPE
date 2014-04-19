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
public class LoanDetail : Layer
{
    // 
    #region KHAI BÁO CÁC ĐỐI TƯỢNG VÀ BIẾN CẦN DÙNG 
    // Các thuộc tính của lớp 
    public int Loan_ID {get;set;} 
    public int RentDay {get;set;} 
    public decimal PenaltyAmount {get;set;} 
    public DateTime LoanDate {get;set;} 
    public DateTime ReturnDate {get;set;}
    public decimal RentAmount { get; set; }
    public decimal Deposit { get; set; }
    public int SiteLoan_ID {get;set;} 
    public int SiteReturn_ID {get;set;} 
    public int Status {get;set;}
    public int CPE_ID { get; set; }
    public float PromotionDisCount { get; set; }
    public string AgentCode { get; set; } 
    // Các đối tượng cần dùng của lớp 
    private DataAccessLayer.DataConfig dtConfig = new DataAccessLayer.DataConfig(); 
    private DataTable dtTable; 
    #endregion 
    // 
    #region CÁC THỦ TỤC LẤY THÔNG TIN 
    public DataTable GetListInfor() 
    { 
        dtTable = new DataTable(); 
        string sql = "SELECT ROW_NUMBER() OVER(ORDER BY ID) AS STT,* From LoanDetail"; 
        try 
        { 
            dtTable = dtConfig.GetDataTable(sql); 
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, "Get List LoanDetail", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return dtTable; 
    }
    public DataTable GetListInforCustomer(string Customer_ID)
    {
        dtTable = new DataTable();
     //   string sql = string.Format("SELECT ROW_NUMBER() OVER(ORDER BY l.ID) AS STT,l.* From LoanDetail as l inner join    CPE as c on l.CPE_ID=c.ID where l.Status<>1 and l.Loan_ID in (select lo.ID from LoanDetail as l1 inner join  LOAN as lo on l1.Loan_ID=lo.ID where lo.Status=1 and lo.Customer_ID={0})", Customer_ID);
        string sql = string.Format("SELECT ROW_NUMBER() OVER(ORDER BY l.ID) AS STT,l.* From LoanDetail as l inner join    CPE as c on l.CPE_ID=c.ID where  l.Loan_ID in (select distinct lo.ID from LoanDetail as l1 inner join  LOAN as lo on l1.Loan_ID=lo.ID where lo.Status=1 and lo.Customer_ID={0}) and (l.Status=5 or l.Status=6)", Customer_ID);
        try
        {
            dtTable = dtConfig.GetDataTable(sql);
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Error: " + ex.Message, "Get List LoanDetail", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return dtTable;
    } 
    public DataTable GetListInfor(string Loan_ID)
    {
        dtTable = new DataTable();
        string sql = "SELECT ROW_NUMBER() OVER(ORDER BY l.ID) AS STT,l.* From LoanDetail as l inner join  CPE as c on l.CPE_ID=c.ID where Loan_ID=" + Loan_ID;
        try
        {
            dtTable = dtConfig.GetDataTable(sql);
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Error: " + ex.Message, "Get List LoanDetail", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return dtTable;
    }
    public DataTable GetListByOrderOnline(string Loan_ID)
    {
        dtTable = new DataTable();
        string sql = "SELECT ROW_NUMBER() OVER(ORDER BY l.ID) AS STT,l.* From LoanDetail as l inner join  CPE as c on l.CPE_ID=c.ID where Loan_ID=" + Loan_ID;
        try
        {
            dtTable = dtConfig.GetDataTable(sql);
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Error: " + ex.Message, "Get List LoanDetail", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return dtTable;
    } 
    public DataTable GetListInfor(int ID) 
    { 
        LoanDetail obj = new LoanDetail(); 
        dtTable = new DataTable(); 
        string sql = "Select * From LoanDetail Where ID Like N'%" + ID + "%' "; 
        try 
        { 
            dtTable = new DataTable(); 
            dtTable = dtConfig.GetDataTable(sql); 
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, " Get List LoanDetail ", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return dtTable; 
    } 
    // Lấy thông tin đối tượng 
    public override Layer GetInfor(int ID) 
    { 
        LoanDetail obj = new LoanDetail(); 
        dtTable = new DataTable(); 
        string sql = "Select * From LoanDetail Where ID=N'" + ID + "' "; 
        try 
        { 
            dtTable = new DataTable(); 
            dtTable = dtConfig.GetDataTable(sql); 
            if (dtTable.Rows.Count > 0) 
            { 
                try{ obj.ID = int.Parse(dtTable.Rows[0]["ID"].ToString());} 
                catch (FormatException) { obj.ID = 0; } 
                try{ obj.Loan_ID = int.Parse(dtTable.Rows[0]["Loan_ID"].ToString());} 
                catch (FormatException) { obj.Loan_ID = 0; }
                try { obj.CPE_ID = int.Parse(dtTable.Rows[0]["CPE_ID"].ToString()); }
                catch (FormatException) { obj.CPE_ID = 0; }
                try { obj.RentDay = int.Parse(dtTable.Rows[0]["RentDay"].ToString()); }
                catch (FormatException) { obj.RentDay = 0; }
                try { obj.PenaltyAmount = Convert.ToDecimal(dtTable.Rows[0]["PenaltyAmount"].ToString()); } 
                catch (FormatException) { obj.PenaltyAmount = 0; } 
                try{ obj.LoanDate = DateTime.Parse(dtTable.Rows[0]["LoanDate"].ToString());} 
                catch (FormatException) { } 
                try{ obj.ReturnDate = DateTime.Parse(dtTable.Rows[0]["ReturnDate"].ToString());} 
                catch (FormatException) { }
                try { obj.RentAmount = Convert.ToDecimal(dtTable.Rows[0]["RentAmount"]); }
                catch (FormatException) { obj.RentAmount = 0; }
                try { obj.Deposit = Convert.ToDecimal(dtTable.Rows[0]["Deposit"]); }
                catch (FormatException) { obj.Deposit = 0; }
                try { obj.SiteLoan_ID = int.Parse(dtTable.Rows[0]["SiteLoan_ID"].ToString()); }
                catch (FormatException) { obj.SiteLoan_ID = 0; }
                try { obj.SiteReturn_ID = int.Parse(dtTable.Rows[0]["SiteReturn_ID"].ToString()); }
                catch (FormatException) { obj.SiteReturn_ID = 0; } 
                try{ obj.Status = int.Parse(dtTable.Rows[0]["Status"].ToString());} 
                catch (FormatException) { obj.Status = 0; } 
                try{ obj.Modified_By = int.Parse(dtTable.Rows[0]["Modified_By"].ToString());} 
                catch (FormatException) { obj.Modified_By = 0; } 
                try{ obj.Created = dtTable.Rows[0]["Created"].ToString();} 
                catch (FormatException) { } 
                try{ obj.Created_By = int.Parse(dtTable.Rows[0]["Created_By"].ToString());} 
                catch (FormatException) { obj.Created_By = 0; } 
                try{ obj.Modified = dtTable.Rows[0]["Modified"].ToString();} 
                catch (FormatException) { }
                try { obj.PromotionDisCount = (float)Convert.ToDecimal(dtTable.Rows[0]["PromotionDisCount"]); }
                catch (FormatException) { obj.PromotionDisCount = 0; }
                try { obj.AgentCode = dtTable.Rows[0]["AgentCode"].ToString(); }
                catch (FormatException) { } 
            } 
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, " Get Infor Object LoanDetail ", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return obj; 
    } 
    // Lấy mã ID tiếp theo 
    public string GetNextID() 
    { 
        string result = "", captionID = ""; 
        // Set your caption ID 
        captionID = "LoanDetail_"; 
        int lastID = 0; 
        string sql = "Select TOP 1 ID From LoanDetail ORDER BY ID DESC "; 
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
    public bool CheckInfor(LoanDetail obj ) 
    { 
        bool ok = true; 
        if (obj.ID == null) 
        { 
            MessageBox.Show("ID is not null", " Check Infor LoanDetail", MessageBoxButtons.OK, MessageBoxIcon.Error); 
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
        string sql = "Select Count(ID) From LoanDetail Where ID=N'" + ID + "' "; 
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
    // Thêm mới thông tin LoanDetail 
    public int Insert(LoanDetail obj ) 
    {
        base.Insert(obj);
        int result = 0;
        string sql = string.Format("Insert LoanDetail values( N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', N'{9}', N'{10}', N'{11}', N'{12}',N'{13}',N'{14}',N'{15}',N'{16}',N'{17}'); SELECT SCOPE_IDENTITY () as NewID"
            , obj.ID, obj.Loan_ID, obj.RentDay, obj.PenaltyAmount, common.toFormatTime(obj.LoanDate), common.toFormatTime(obj.ReturnDate), obj.RentAmount, obj.Deposit, obj.SiteLoan_ID, obj.SiteReturn_ID, obj.Status, obj.Modified_By, obj.Created, obj.Created_By, obj.Modified, obj.CPE_ID,obj.PromotionDisCount,obj.AgentCode);
        try
        {
            if (CheckExistPrimaryKey(obj.ID))
                MessageBox.Show("Error: Primary key have been exist", " Check Exist Primary Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                result = dtConfig.ExecuteScalarQuery1(sql);
                ITrackLogsDAL _DALTracklog = new TrackLogsDAL();
                _DALTracklog.Insert(new Models.TrackLog() { Action = "Insert LoanDetail ID: " + result, Type = "Insert", TimeAction = DateTime.Now, Staff_ID = SessionCur.staff.ID });
                //dtConfig.InsertTrackLog("Insert LoanDetail ID: " + result, "Insert");
            }
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Error: " + ex.Message, " Insert Infor LoanDetail", MessageBoxButtons.OK, MessageBoxIcon.Error);
        } 
        return result; 
    } 
    // Cập nhật thông tin LoanDetail 
    public int Update(LoanDetail obj ) 
    {
        base.Update(obj);
        int result = 0;
        string sql = string.Format("Update LoanDetail set Loan_ID= N'{1}',RentDay= N'{2}',PenaltyAmount= N'{3}', LoanDate=N'{4}',ReturnDate= N'{5}',RentAmount= N'{6}',Deposit= N'{7}',SiteLoan_ID= N'{8}',SiteReturn_ID= N'{9}',Status= N'{10}',Modified_By= N'{11}',Modified= N'{12}',PromotionDisCount=N'{13}',AgentCode=N'{14}'  where ID={0}"
            , obj.ID, obj.Loan_ID, obj.RentDay, obj.PenaltyAmount, common.toFormatTime(obj.LoanDate), common.toFormatTime(obj.ReturnDate), obj.RentAmount, obj.Deposit, obj.SiteLoan_ID, obj.SiteReturn_ID, obj.Status, obj.Modified_By, obj.Modified,obj.PromotionDisCount,obj.AgentCode);
        try
        {
            if (!CheckExistPrimaryKey(obj.ID))
                MessageBox.Show("Error: Primary key isn't exist", " Check Exist Primary Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                result = dtConfig.ExecuteNoneQuery(sql);
                ITrackLogsDAL _DALTracklog = new TrackLogsDAL();
                _DALTracklog.Insert(new Models.TrackLog() { Action = "Update LoanDetail ID: " + obj.ID, Type = "Update", TimeAction = DateTime.Now, Staff_ID = SessionCur.staff.ID });
                //dtConfig.InsertTrackLog("Update LoanDetail ID: " + obj.ID, "Update");
            }
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Error: " + ex.Message, " Update Infor LoanDetail", MessageBoxButtons.OK, MessageBoxIcon.Error);
        } 
        return result; 
    } 
    // Xóa thông tin LoanDetail 
    public int Delete(LoanDetail obj ) 
    { 
        int result = 0; 
        string sql =string.Format("Delete LoanDetail where ID='{0}'" 
            , obj.ID); 
        try 
        { 
            if(!CheckExistPrimaryKey(obj.ID)) 
                MessageBox.Show("Error: Primary key isn't exist", " Check Exist Primary Key", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            else 
            {     result = dtConfig.ExecuteNoneQuery(sql);
            ITrackLogsDAL _DALTracklog = new TrackLogsDAL();
            _DALTracklog.Insert(new Models.TrackLog() { Action = "Delete LoanDetail ID: " + obj.ID, Type = "Delete", TimeAction = DateTime.Now, Staff_ID = SessionCur.staff.ID });
             //dtConfig.InsertTrackLog("Delete LoanDetail ID: " + obj.ID, "Delete");
            }   } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, " Delete Infor LoanDetail", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return result; 
    } 
    #endregion 
    // 
}
 } 
