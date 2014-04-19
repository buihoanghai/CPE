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
    public class CPE : Layer
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

    public string Barcode {get;set;}
    public int Site_ID {get;set;} 
    public int Status {get;set;}
    public int CPECategory_ID { get; set; }
    public string SIMNo { get; set; }
    //public DateTime Modified {get;set;} 
    // Các đối tượng cần dùng của lớp 
    private DataAccessLayer.DataConfig dtConfig = new DataAccessLayer.DataConfig(); 
    private DataTable dtTable; 
    #endregion 
    // 
    #region CÁC THỦ TỤC LẤY THÔNG TIN 
    public DataTable GetAllListBySite(int site)
    {
        dtTable = new DataTable();
        string sql = "Select ROW_NUMBER() OVER(ORDER BY ID) AS STT, * From CPE Where dbo.CPE.Site_ID = " + site;
        try
        {
            dtTable = dtConfig.GetDataTable(sql);
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Error: " + ex.Message, "Get List CPE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return dtTable;
    } 
        public DataTable GetListBySite(int site)
    {
        dtTable = new DataTable();
        string sql = "SELECT ROW_NUMBER() OVER(ORDER BY dbo.CPE.ID) AS STT, dbo.CPE.* FROM dbo.Staff INNER JOIN dbo.CPE ON dbo.Staff.Site_ID = dbo.CPE.Site_ID WHERE (dbo.Staff.AccountType = 1) AND (dbo.CPE.Site_ID = " + site + ") order by ID desc";
        try
        {
            dtTable = dtConfig.GetDataTable(sql);
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Error: " + ex.Message, "Get List CPE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return dtTable;
    } 
        public DataTable GetListInfor() 
    { 
        dtTable = new DataTable();
        string sql = "SELECT ROW_NUMBER() OVER(ORDER BY ID) AS STT,* From CPE order by ID desc"; 
        try 
        { 
            dtTable = dtConfig.GetDataTable(sql); 
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, "Get List CPE", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return dtTable; 
    }
        public DataTable GetListInforBySite(int site)
        {
            dtTable = new DataTable();
            string sql = "SELECT ROW_NUMBER() OVER(ORDER BY ID) AS STT,* From CPE where Site_ID="+site+" order by ID desc";
            try
            {
                dtTable = dtConfig.GetDataTable(sql);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Get List CPE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dtTable;
        } 
    public DataTable GetListInfor(int ID) 
    { 
        CPE obj = new CPE(); 
        dtTable = new DataTable(); 
        string sql = "Select * From CPE Where ID Like N'%" + ID + "%' "; 
        try 
        { 
            dtTable = new DataTable(); 
            dtTable = dtConfig.GetDataTable(sql); 
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, " Get List CPE ", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return dtTable; 
    } 
    // Lấy thông tin đối tượng 
    CPE getCPE(string sql)
    {
        CPE obj = new CPE();
        dtTable = new DataTable();
        try
        {
            dtTable = new DataTable();
            dtTable = dtConfig.GetDataTable(sql);
            if (dtTable.Rows.Count > 0)
            {
                try { obj.ID = int.Parse(dtTable.Rows[0]["ID"].ToString()); }
                catch (FormatException) { obj.ID = 0; }
                obj.Barcode = dtTable.Rows[0]["Barcode"].ToString();
                obj.SIMNo = dtTable.Rows[0]["SIMNo"].ToString();
            
                try { obj.Site_ID = int.Parse(dtTable.Rows[0]["Site_ID"].ToString()); }
                catch (FormatException) { obj.Site_ID = 0; }
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
                try { obj.CPECategory_ID =int.Parse( dtTable.Rows[0]["CPECategory_ID"].ToString()); }
                catch (FormatException) { obj.CPECategory_ID = 0; }
            }
            else
                return null;
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Error: " + ex.Message, " Get Infor Object CPE ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return obj;
    }
    public CPE GetInfor(string CPE, int Site_ID)
    {
        string sql = string.Format("Select * From CPE Where Status= 1 and  Barcode=N'{0}' and Site_ID = {1}", CPE,Site_ID);
        return getCPE(sql);
    }
    public CPE GetInfor1(string CPE)
    {
        string sql = string.Format("Select * From CPE Where Barcode=N'{0}'", CPE);
        return getCPE(sql);
    }
    public CPE GetInfor2(string CPE)
    {
        string sql = string.Format("Select * From CPE Where (Status= 5 or Status= 6) and Barcode=N'{0}'", CPE);
        return getCPE(sql);
    }
    public override Layer GetInfor(int ID) 
    {
        string sql = "Select * From CPE Where ID=N'" + ID + "' ";
        return getCPE(sql);
    } 
    // Lấy mã ID tiếp theo 
    public string GetNextID() 
    { 
        string result = "", captionID = ""; 
        // Set your caption ID 
        captionID = "CPE_"; 
        int lastID = 0; 
        string sql = "Select TOP 1 ID From CPE ORDER BY ID DESC "; 
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
    public bool CheckInfor(CPE obj ) 
    { 
        bool ok = true; 
        if (obj.ID == null) 
        { 
            MessageBox.Show("ID is not null", " Check Infor CPE", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
        if (obj.Status == null) 
        { 
            MessageBox.Show("Status is not null", " Check Infor CPE", MessageBoxButtons.OK, MessageBoxIcon.Error); 
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
        string sql = "Select Count(ID) From CPE Where ID=N'" + ID + "' "; 
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
    public bool CheckExistBarcode(object barcode)
    {
        bool ok = false;
        int result = 0;
        string sql = "Select Count(ID) From CPE Where Barcode=N'" + barcode + "' ";
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
    public bool CheckExistBarcodeRented(object barcode)
    {
        bool ok = false;
        int result = 0;
        string sql = "Select Count(ID) From CPE Where Barcode=N'" + barcode + "' and Status=5";
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
    // Thêm mới thông tin CPE 
    public int Insert(CPE obj ) 
    {
        base.Insert(obj);
        int result = 0;
        string sql = string.Format(" Insert Into CPE(Barcode,Site_ID ,Status , Modified_By,Created ,Created_By , Modified,CPECategory_ID ,SIMNo ) Values( N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}',N'{9}'); SELECT SCOPE_IDENTITY () As NewID" 
            , obj.ID, obj.Barcode , obj.Site_ID, obj.Status, obj.Modified_By,obj.Created, obj.Created_By, obj.Modified,obj.CPECategory_ID,obj.SIMNo); 
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
    // Cập nhật thông tin CPE 
    public int Update(CPE obj ) 
    {
        base.Update(obj);
        int result = 0;
        obj.Modified = common.toFormatTime(DateTime.Now);
        string sql = string.Format(" Update CPE Set  Barcode= N'{1}', Site_ID= N'{2}',  Status= N'{3}', Modified_By= N'{4}', Modified= N'{5}' , SIMNo=N'{6}' where ID={0}"
            , obj.ID, obj.Barcode, obj.Site_ID,obj.Status, obj.Modified_By, obj.Modified,obj.SIMNo);
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
    // Xóa thông tin CPE 
    public int Delete(CPE obj ) 
    { 
        int result = 0; 
        string sql =string.Format(" Delete From CPE Where ID = N'{0}'" 
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
