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
public class Package : Layer
{
    // 
    #region KHAI BÁO CÁC ĐỐI TƯỢNG VÀ BIẾN CẦN DÙNG 
    // Các thuộc tính của lớp 
    public int Days {get;set;} 
    public string Name {get;set;} 
    public int EOM {get;set;} 
    public decimal Price {get;set;} 
    // Các đối tượng cần dùng của lớp 
    private DataAccessLayer.DataConfig dtConfig = new DataAccessLayer.DataConfig(); 
    private DataTable dtTable; 
    #endregion 
    // 
    #region CÁC THỦ TỤC LẤY THÔNG TIN 
    public DataTable GetListInfor() 
    { 
        dtTable = new DataTable(); 
        string sql = "SELECT ROW_NUMBER() OVER(ORDER BY ID) AS STT,* From Package"; 
        try 
        { 
            dtTable = dtConfig.GetDataTable(sql); 
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, "Get List Package", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return dtTable; 
    }
    public DataTable GetListInfor(string CPE_ID)
    {
        dtTable = new DataTable();
        string sql = "SELECT ROW_NUMBER() OVER(ORDER BY ID) AS STT,* From Package";
        try
        {
            dtTable = dtConfig.GetDataTable(sql);
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Error: " + ex.Message, "Get List Package", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return dtTable;
    } 
    public DataTable GetListInfor1()
    {
        dtTable = new DataTable();
        string sql = "SELECT ROW_NUMBER() OVER(ORDER BY p.ID) AS STT,p.* From Package p";
        try
        {
            dtTable = dtConfig.GetDataTable(sql);
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Error: " + ex.Message, "Get List Package", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return dtTable;
    } 
    public DataTable GetListInfor(int ID) 
    { 
        Package obj = new Package(); 
        dtTable = new DataTable(); 
        string sql = "Select * From Package Where ID Like N'%" + ID + "%' "; 
        try 
        { 
            dtTable = new DataTable(); 
            dtTable = dtConfig.GetDataTable(sql); 
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, " Get List Package ", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return dtTable; 
    } 
    // Lấy thông tin đối tượng 
    public override Layer GetInfor(int ID) 
    { 
        Package obj = new Package(); 
        dtTable = new DataTable(); 
        string sql = "Select * From Package Where ID=N'" + ID + "' "; 
        try 
        { 
            dtTable = new DataTable(); 
            dtTable = dtConfig.GetDataTable(sql); 
            if (dtTable.Rows.Count > 0) 
            { 
                try{ obj.ID = int.Parse(dtTable.Rows[0]["ID"].ToString());} 
                catch (FormatException) { obj.ID = 0; } 
                try{ obj.Days = int.Parse(dtTable.Rows[0]["Days"].ToString());} 
                catch (FormatException) { obj.Days = 0; } 
                obj.Name = dtTable.Rows[0]["Name"].ToString(); 
                try{ obj.EOM = int.Parse(dtTable.Rows[0]["EOM"].ToString());} 
                catch (FormatException) { obj.EOM = 0; }
                try { obj.Price = Convert.ToDecimal(dtTable.Rows[0]["Price"].ToString()); } 
                catch (FormatException) { obj.Price = 0; } 
                try{ obj.Modified = dtTable.Rows[0]["Modified"].ToString();} 
                catch (FormatException) { } 
                try{ obj.Modified_By = int.Parse(dtTable.Rows[0]["Modified_By"].ToString());} 
                catch (FormatException) { obj.Modified_By = 0; } 
                try{ obj.Created = dtTable.Rows[0]["Created"].ToString();} 
                catch (FormatException) { } 
                try{ obj.Created_By = int.Parse(dtTable.Rows[0]["Created_By"].ToString());} 
                catch (FormatException) { obj.Created_By = 0; } 
            } 
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, " Get Infor Object Package ", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return obj; 
    } 
    // Lấy mã ID tiếp theo 
    public string GetNextID() 
    { 
        string result = "", captionID = ""; 
        // Set your caption ID 
        captionID = "Package_"; 
        int lastID = 0; 
        string sql = "Select TOP 1 ID From Package ORDER BY ID DESC "; 
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
    public bool CheckInfor(Package obj ) 
    { 
        bool ok = true; 
        if (obj.ID == null) 
        { 
            MessageBox.Show("ID is not null", " Check Infor Package", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
      
      
        if (obj.Price == null) 
        { 
            MessageBox.Show("Price is not null", " Check Infor Package", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
        if (obj.Modified == null) 
        { 
            MessageBox.Show("Modified is not null", " Check Infor Package", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
        if (obj.Modified_By == null) 
        { 
            MessageBox.Show("Modified_By is not null", " Check Infor Package", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
        if (obj.Created == null) 
        { 
            MessageBox.Show("Created is not null", " Check Infor Package", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
        if (obj.Created_By == null) 
        { 
            MessageBox.Show("Created_By is not null", " Check Infor Package", MessageBoxButtons.OK, MessageBoxIcon.Error); 
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
        string sql = "Select Count(ID) From Package Where ID=N'" + ID + "' "; 
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
    // Thêm mới thông tin Package 
    public int Insert(Package obj ) 
    {
        base.Insert(obj);
        int result = 0;
        string sql = string.Format(" Insert Into Package Values( N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}') ; SELECT SCOPE_IDENTITY () As NewID" 
            , obj.ID,  obj.Days, obj.Name, obj.EOM,obj.Price, obj.Modified, obj.Modified_By, obj.Created, obj.Created_By); 
        try 
        { 
            if(CheckExistPrimaryKey(obj.ID)) 
                MessageBox.Show("Error: Primary key have been exist", " Check Exist Primary Key", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            else 
                result = dtConfig.ExecuteScalarQuery1(sql); 
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, " Insert Infor Package", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return result; 
    } 
    // Cập nhật thông tin Package 
    public int Update(Package obj ) 
    {
        base.Update(obj);
        int result = 0;
        obj.Modified = common.toFormatTime(DateTime.Now);
        string sql =string.Format(" Update Package Set   Days= N'{1}', Name= N'{2}', EOM= N'{3}',  Price= N'{4}', Modified= N'{5}', Modified_By= N'{6}'" 
            , obj.ID, obj.Days, obj.Name, obj.EOM, obj.Price, obj.Modified, obj.Modified_By)
		 +" Where ( ID = '"+ obj.ID+"')"; 
        try 
        { 
            if(!CheckExistPrimaryKey(obj.ID)) 
                MessageBox.Show("Error: Primary key isn't exist", " Check Exist Primary Key", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            else 
                result = dtConfig.ExecuteNoneQuery(sql); 
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, " Update Infor Package", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return result; 
    } 
    // Xóa thông tin Package 
    public int Delete(Package obj ) 
    { 
        int result = 0; 
        string sql =string.Format(" Delete From Package Where ID = N'{0}'" 
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
            MessageBox.Show("Error: " + ex.Message, " Delete Infor Package", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return result; 
    } 
    #endregion 
    // 
}
 } 
