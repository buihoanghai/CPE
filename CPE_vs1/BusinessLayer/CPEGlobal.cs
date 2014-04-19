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
    public class CPEGlobal : Layer
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


    public string Name {get;set;}
    public decimal Price { get; set; }
    public decimal Deposit { get; set; }
    public string Description {get;set;} 
    // Các đối tượng cần dùng của lớp 
    private DataAccessLayer.DataConfig dtConfig = new DataAccessLayer.DataConfig(); 
    private DataTable dtTable; 
    #endregion 
    // 
    #region CÁC THỦ TỤC LẤY THÔNG TIN 
    public DataTable GetListInfor() 
    { 
        dtTable = new DataTable(); 
        string sql = "SELECT ROW_NUMBER() OVER(ORDER BY ID) AS STT,* From CPEGlobal"; 
        try 
        { 
            dtTable = dtConfig.GetDataTable(sql); 
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, "Get List CPEGlobal", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return dtTable; 
    } 
    public DataTable GetListInfor(int ID) 
    { 
        CPEGlobal obj = new CPEGlobal(); 
        dtTable = new DataTable(); 
        string sql = "Select * From CPEGlobal Where ID Like N'%" + ID + "%' "; 
        try 
        { 
            dtTable = new DataTable(); 
            dtTable = dtConfig.GetDataTable(sql); 
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, " Get List CPEGlobal", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return dtTable; 
    } 
    // Lấy thông tin đối tượng 
    CPEGlobal getCPE(string sql)
    {
        CPEGlobal obj = new CPEGlobal();
        dtTable = new DataTable();
        try
        {
            dtTable = new DataTable();
            dtTable = dtConfig.GetDataTable(sql);
            if (dtTable.Rows.Count > 0)
            {
                try { obj.ID = int.Parse(dtTable.Rows[0]["ID"].ToString()); }
                catch (FormatException) { obj.ID = 0; }
                obj.Name = dtTable.Rows[0]["Name"].ToString();
                try { obj.Price = Convert.ToDecimal(dtTable.Rows[0]["Price"]); }
                catch (FormatException) { obj.Price = 0; }
                try { obj.Deposit = Convert.ToDecimal(dtTable.Rows[0]["Deposit"]); }
                catch (FormatException) { obj.Deposit = 0; }
                obj.Description = dtTable.Rows[0]["Description"].ToString();
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
            MessageBox.Show("Error: " + ex.Message, " Get Infor Object CPEGlobal", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return obj;
    }
    public CPEGlobal GetInfor(string CPE)
    {
        string sql = string.Format("Select * From CPEGlobal Where Barcode=N'{0}' or SerialNumber=N'{0}' ", CPE);
        return getCPE(sql);
    }
    public override Layer GetInfor(int ID) 
    {
        string sql = "Select * From CPEGlobal Where ID=N'" + ID + "' ";
        return getCPE(sql);
    } 
    // Lấy mã ID tiếp theo 
    public string GetNextID() 
    { 
        string result = "", captionID = ""; 
        // Set your caption ID 
        captionID = "CPE_"; 
        int lastID = 0; 
        string sql = "Select TOP 1 ID From CPEGlobal ORDER BY ID DESC "; 
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
    public bool CheckInfor(CPEGlobal obj ) 
    { 
        bool ok = true; 
        if (obj.ID == null) 
        { 
            MessageBox.Show("ID is not null", " Check Infor CPE", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
        if (obj.Name == null) 
        { 
            MessageBox.Show("Name is not null", " Check Infor CPE", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
        if (obj.Price == null) 
        { 
            MessageBox.Show("Price is not null", " Check Infor CPE", MessageBoxButtons.OK, MessageBoxIcon.Error); 
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
        string sql = "Select Count(ID) From CPEGlobal Where ID=N'" + ID + "' "; 
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
    // Thêm mới thông tin CPEGlobal
    public int Insert(CPEGlobal obj ) 
    {
        base.Insert(obj);
        int result = 0;
        string sql = string.Format(" Insert Into CPEGlobalValues( N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}',N'{8}'); SELECT SCOPE_IDENTITY () As NewID"
            , obj.ID, obj.Name, obj.Price, obj.Deposit, obj.Description, obj.Modified_By, obj.Modified, obj.Created, obj.Created_By); 
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
    // Cập nhật thông tin CPEGlobal
    public int Update(CPEGlobal obj ) 
    {
        base.Update(obj);
        int result = 0;
        obj.Modified = common.toFormatTime(DateTime.Now);
        string sql = string.Format(" Update CPEGlobalSet Name= N'{1}', Price= N'{2}',  Deposit= N'{3}',Description= N'{4}', Modified_By= N'{5}', Modified= N'{6}',where ID={0}"
            , obj.ID,   obj.Name, obj.Price,obj.Deposit, obj.Description, obj.Modified_By, obj.Modified);
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
    // Xóa thông tin CPEGlobal
    public int Delete(CPEGlobal obj ) 
    { 
        int result = 0; 
        string sql =string.Format(" Delete From CPEGlobal Where ID = N'{0}'" 
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
    #endregion 
    // 
}
 } 
