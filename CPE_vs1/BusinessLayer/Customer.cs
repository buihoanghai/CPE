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
public class Customer : Layer
{
    // 
    #region KHAI BÁO CÁC ĐỐI TƯỢNG VÀ BIẾN CẦN DÙNG 
    // Các thuộc tính của lớp 
    public string Name {get;set;} 
    public DateTime DOB {get;set;} 
    public string Passport {get;set;} 
    public string Nationality {get;set;} 
    public string Address {get;set;}
    public DateTime Expiry_date = DateTime.Now;
    public string Phone {get;set;}
    public string DrivingLisence { get; set; }
    public string IDLisence { get; set; }
    public string Email { get; set; }
    // Các đối tượng cần dùng của lớp 
    private DataAccessLayer.DataConfig dtConfig = new DataAccessLayer.DataConfig(); 
    private DataTable dtTable; 
    #endregion 
    // 
    #region CÁC THỦ TỤC LẤY THÔNG TIN 
    public DataTable GetListInfor() 
    { 
        dtTable = new DataTable(); 
        string sql = "SELECT ROW_NUMBER() OVER(ORDER BY ID) AS STT,* From Customer"; 
        try 
        { 
            dtTable = dtConfig.GetDataTable(sql); 
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, "Get List Customer", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return dtTable; 
    } 
    public DataTable GetListInfor(int ID) 
    { 
        Customer obj = new Customer(); 
        dtTable = new DataTable(); 
        string sql = "Select * From Customer Where ID Like N'%" + ID + "%' "; 
        try 
        { 
            dtTable = new DataTable(); 
            dtTable = dtConfig.GetDataTable(sql); 
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, " Get List Customer ", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return dtTable; 
    }
    public Customer GetCustomerByBarcode(string barcode)
    {
        Customer obj = new Customer();
        dtTable = new DataTable();
        string sql = "SELECT dbo.Customer.* FROM dbo.LoanDetail INNER JOIN dbo.CPE ON dbo.LoanDetail.CPE_ID = dbo.CPE.ID INNER JOIN dbo.Loan ON dbo.LoanDetail.Loan_ID = dbo.Loan.ID INNER JOIN dbo.Customer ON dbo.Loan.Customer_ID = dbo.Customer.ID WHERE (dbo.CPE.Barcode = '" + barcode + "'  AND (dbo.CPE.Status = 5 OR dbo.CPE.Status = 6))";
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
                obj.Passport = dtTable.Rows[0]["Passport"].ToString();
                obj.Nationality = dtTable.Rows[0]["Nationality"].ToString();
                obj.Address = dtTable.Rows[0]["Address"].ToString();
                try { obj.Expiry_date = DateTime.Parse(dtTable.Rows[0]["Expiry_date"].ToString()); }
                catch (FormatException) { }
                obj.Phone = dtTable.Rows[0]["Phone"].ToString();
                try { obj.Modified_By = int.Parse(dtTable.Rows[0]["Modified_By"].ToString()); }
                catch (FormatException) { obj.Modified_By = 0; }
                try { obj.Created = dtTable.Rows[0]["Created"].ToString(); }
                catch (FormatException) { }
                try { obj.Created_By = int.Parse(dtTable.Rows[0]["Created_By"].ToString()); }
                catch (FormatException) { obj.Created_By = 0; }
                try { obj.Modified = dtTable.Rows[0]["Modified"].ToString(); }
                catch (FormatException) { }
                obj.IDLisence = dtTable.Rows[0]["IDLisence"].ToString();
                obj.DrivingLisence = dtTable.Rows[0]["DrivingLisence"].ToString();
                obj.Email = dtTable.Rows[0]["Email"].ToString();
            }
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Error: " + ex.Message, " Get Infor Object Customer ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return obj;
    }
    public  Customer GetInfor(string passport)
    {
        Customer obj = new Customer();
        dtTable = new DataTable();
        string sql = "Select * From Customer Where Passport=N'" + passport + "' ";
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
                obj.Passport = dtTable.Rows[0]["Passport"].ToString();
                obj.Nationality = dtTable.Rows[0]["Nationality"].ToString();
                obj.Address = dtTable.Rows[0]["Address"].ToString();
                try { obj.Expiry_date = DateTime.Parse(dtTable.Rows[0]["Expiry_date"].ToString()); }
                catch (FormatException) { }
                obj.Phone = dtTable.Rows[0]["Phone"].ToString();
                try { obj.Modified_By = int.Parse(dtTable.Rows[0]["Modified_By"].ToString()); }
                catch (FormatException) { obj.Modified_By = 0; }
                try { obj.Created = dtTable.Rows[0]["Created"].ToString(); }
                catch (FormatException) { }
                try { obj.Created_By = int.Parse(dtTable.Rows[0]["Created_By"].ToString()); }
                catch (FormatException) { obj.Created_By = 0; }
                try { obj.Modified = dtTable.Rows[0]["Modified"].ToString(); }
                catch (FormatException) { }
                obj.IDLisence = dtTable.Rows[0]["IDLisence"].ToString();
                obj.DrivingLisence = dtTable.Rows[0]["DrivingLisence"].ToString();
                obj.Email = dtTable.Rows[0]["Email"].ToString();
            }
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Error: " + ex.Message, " Get Infor Object Customer ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return obj;
    }
    public Customer GetInforByDrivingLisence(string drivingLisence)
    {
        Customer obj = new Customer();
        dtTable = new DataTable();
        string sql = "Select * From Customer Where DrivingLisence=N'" + drivingLisence + "' ";
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
                obj.Passport = dtTable.Rows[0]["Passport"].ToString();
                obj.Nationality = dtTable.Rows[0]["Nationality"].ToString();
                obj.Address = dtTable.Rows[0]["Address"].ToString();
                try { obj.Expiry_date = DateTime.Parse(dtTable.Rows[0]["Expiry_date"].ToString()); }
                catch (FormatException) { }
                obj.Phone = dtTable.Rows[0]["Phone"].ToString();
                try { obj.Modified_By = int.Parse(dtTable.Rows[0]["Modified_By"].ToString()); }
                catch (FormatException) { obj.Modified_By = 0; }
                try { obj.Created = dtTable.Rows[0]["Created"].ToString(); }
                catch (FormatException) { }
                try { obj.Created_By = int.Parse(dtTable.Rows[0]["Created_By"].ToString()); }
                catch (FormatException) { obj.Created_By = 0; }
                try { obj.Modified = dtTable.Rows[0]["Modified"].ToString(); }
                catch (FormatException) { }
            }
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Error: " + ex.Message, " Get Infor Object Customer ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return obj;
    }
    public Customer GetInforByIDLisence(string IDLisence)
    {
        Customer obj = new Customer();
        dtTable = new DataTable();
        string sql = "Select * From Customer Where IDLisence=N'" + IDLisence + "' ";
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
                obj.Passport = dtTable.Rows[0]["Passport"].ToString();
                obj.Nationality = dtTable.Rows[0]["Nationality"].ToString();
                obj.Address = dtTable.Rows[0]["Address"].ToString();
                try { obj.Expiry_date = DateTime.Parse(dtTable.Rows[0]["Expiry_date"].ToString()); }
                catch (FormatException) { }
                obj.Phone = dtTable.Rows[0]["Phone"].ToString();
                try { obj.Modified_By = int.Parse(dtTable.Rows[0]["Modified_By"].ToString()); }
                catch (FormatException) { obj.Modified_By = 0; }
                try { obj.Created = dtTable.Rows[0]["Created"].ToString(); }
                catch (FormatException) { }
                try { obj.Created_By = int.Parse(dtTable.Rows[0]["Created_By"].ToString()); }
                catch (FormatException) { obj.Created_By = 0; }
                try { obj.Modified = dtTable.Rows[0]["Modified"].ToString(); }
                catch (FormatException) { }
            }
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Error: " + ex.Message, " Get Infor Object Customer ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return obj;
    }
    public Customer GetCustomerByCustomerBarcode(string barcode)
    {
        Customer obj = new Customer();
        dtTable = new DataTable();
        string sql = "SELECT        dbo.Customer.* FROM            dbo.Customer INNER JOIN dbo.Loan ON dbo.Customer.ID = dbo.Loan.Customer_ID WHERE (dbo.Loan.CustomerBarcode = '" + barcode + "')";
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
                obj.Passport = dtTable.Rows[0]["Passport"].ToString();
                obj.Nationality = dtTable.Rows[0]["Nationality"].ToString();
                obj.Address = dtTable.Rows[0]["Address"].ToString();
                try { obj.Expiry_date = DateTime.Parse(dtTable.Rows[0]["Expiry_date"].ToString()); }
                catch (FormatException) { }
                obj.Phone = dtTable.Rows[0]["Phone"].ToString();
                try { obj.Modified_By = int.Parse(dtTable.Rows[0]["Modified_By"].ToString()); }
                catch (FormatException) { obj.Modified_By = 0; }
                try { obj.Created = dtTable.Rows[0]["Created"].ToString(); }
                catch (FormatException) { }
                try { obj.Created_By = int.Parse(dtTable.Rows[0]["Created_By"].ToString()); }
                catch (FormatException) { obj.Created_By = 0; }
                try { obj.Modified = dtTable.Rows[0]["Modified"].ToString(); }
                catch (FormatException) { }
                obj.IDLisence = dtTable.Rows[0]["IDLisence"].ToString();
                obj.DrivingLisence = dtTable.Rows[0]["DrivingLisence"].ToString();
                obj.Email = dtTable.Rows[0]["Email"].ToString();
            }
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Error: " + ex.Message, " Get Infor Object Customer ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return obj;
    }
    public Customer GetCustomerByCustomerCode(string barcode)
    {
        Customer obj = new Customer();
        dtTable = new DataTable();
        string sql = "SELECT        dbo.Customer.* FROM            dbo.Customer INNER JOIN dbo.Loan ON dbo.Customer.ID = dbo.Loan.Customer_ID WHERE (dbo.Loan.CustomerCode = '" + barcode + "')";
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
                obj.Passport = dtTable.Rows[0]["Passport"].ToString();
                obj.Nationality = dtTable.Rows[0]["Nationality"].ToString();
                obj.Address = dtTable.Rows[0]["Address"].ToString();
                try { obj.Expiry_date = DateTime.Parse(dtTable.Rows[0]["Expiry_date"].ToString()); }
                catch (FormatException) { }
                obj.Phone = dtTable.Rows[0]["Phone"].ToString();
                try { obj.Modified_By = int.Parse(dtTable.Rows[0]["Modified_By"].ToString()); }
                catch (FormatException) { obj.Modified_By = 0; }
                try { obj.Created = dtTable.Rows[0]["Created"].ToString(); }
                catch (FormatException) { }
                try { obj.Created_By = int.Parse(dtTable.Rows[0]["Created_By"].ToString()); }
                catch (FormatException) { obj.Created_By = 0; }
                try { obj.Modified = dtTable.Rows[0]["Modified"].ToString(); }
                catch (FormatException) { }
                obj.IDLisence = dtTable.Rows[0]["IDLisence"].ToString();
                obj.DrivingLisence = dtTable.Rows[0]["DrivingLisence"].ToString();
                obj.Email = dtTable.Rows[0]["Email"].ToString();
            }
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Error: " + ex.Message, " Get Infor Object Customer ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return obj;
    }
    // Lấy thông tin đối tượng 
    public override Layer GetInfor(int ID) 
    { 
        Customer obj = new Customer(); 
        dtTable = new DataTable(); 
        string sql = "Select * From Customer Where ID=N'" + ID + "' "; 
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
                obj.Passport = dtTable.Rows[0]["Passport"].ToString(); 
                obj.Nationality = dtTable.Rows[0]["Nationality"].ToString(); 
                obj.Address = dtTable.Rows[0]["Address"].ToString(); 
                try{ obj.Expiry_date = DateTime.Parse(dtTable.Rows[0]["Expiry_date"].ToString());} 
                catch (FormatException) { } 
                obj.Phone = dtTable.Rows[0]["Phone"].ToString(); 
                try{ obj.Modified_By = int.Parse(dtTable.Rows[0]["Modified_By"].ToString());} 
                catch (FormatException) { obj.Modified_By = 0; } 
                try{ obj.Created = dtTable.Rows[0]["Created"].ToString();} 
                catch (FormatException) { } 
                try{ obj.Created_By = int.Parse(dtTable.Rows[0]["Created_By"].ToString());} 
                catch (FormatException) { obj.Created_By = 0; } 
                try{ obj.Modified = dtTable.Rows[0]["Modified"].ToString();} 
                catch (FormatException) { }
                try { obj.DrivingLisence = dtTable.Rows[0]["DrivingLisence"].ToString(); }
                catch (FormatException) { }
                try { obj.IDLisence = dtTable.Rows[0]["IDLisence"].ToString(); }
                catch (FormatException) { }
                obj.Email = dtTable.Rows[0]["Email"].ToString();
            } 
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, " Get Infor Object Customer ", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return obj; 
    } 
    // Lấy mã ID tiếp theo 
    public string GetNextID() 
    { 
        string result = "", captionID = ""; 
        // Set your caption ID 
        captionID = "Customer_"; 
        int lastID = 0; 
        string sql = "Select TOP 1 ID From Customer ORDER BY ID DESC "; 
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
    public bool CheckInfor(Customer obj ) 
    { 
        bool ok = true; 
        if (obj.ID == null) 
        { 
            MessageBox.Show("ID is not null", " Check Infor Customer", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
        if (obj.Name == null) 
        { 
            MessageBox.Show("Name is not null", " Check Infor Customer", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
        if (obj.Passport == null) 
        { 
            MessageBox.Show("Passport is not null", " Check Infor Customer", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
        if (obj.Nationality == null) 
        { 
            MessageBox.Show("Nationality is not null", " Check Infor Customer", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
        if (obj.Expiry_date == null) 
        { 
            MessageBox.Show("Expiry_date is not null", " Check Infor Customer", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
        if (obj.Modified_By == null) 
        { 
            MessageBox.Show("Modified_By is not null", " Check Infor Customer", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
        if (obj.Created == null) 
        { 
            MessageBox.Show("Created is not null", " Check Infor Customer", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
        if (obj.Created_By == null) 
        { 
            MessageBox.Show("Created_By is not null", " Check Infor Customer", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 
        if (obj.Modified == null) 
        { 
            MessageBox.Show("Modified is not null", " Check Infor Customer", MessageBoxButtons.OK, MessageBoxIcon.Error); 
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
        string sql = "Select Count(ID) From Customer Where ID=N'" + ID + "' "; 
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
    // Thêm mới thông tin Customer 
    public int Insert(Customer obj ) 
    {
        base.Insert(obj);
        int result = 0;
        string sql = string.Format(" Insert Into Customer Values( N'{1}', N'{2}', {3}, N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', N'{9}', N'{10}', N'{11}',{12},{13},'{14}'); SELECT SCOPE_IDENTITY () AS NewID"
            , obj.ID, obj.Name, common.toFormatTime(obj.DOB), obj.Passport == null ? "null" : "'" + obj.Passport + "'", obj.Nationality, obj.Address, common.toFormatTime(obj.Expiry_date), obj.Phone, obj.Modified_By, obj.Created, obj.Created_By, obj.Modified, obj.DrivingLisence == null ? "null" : "'" + obj.DrivingLisence + "'", obj.IDLisence == null ? "null" : "'" + obj.IDLisence + "'", obj.Email); 
        try 
        { 
            if(CheckExistPrimaryKey(obj.ID)) 
                MessageBox.Show("Error: Primary key have been exist", " Check Exist Primary Key", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            else 
                result = dtConfig.ExecuteScalarQuery1(sql); 
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, " Insert Infor Customer", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return result; 
    } 
    // Cập nhật thông tin Customer 
    public int Update(Customer obj ) 
    {
        base.Update(obj);
        int result = 0;
        string sql = string.Format(" Update Customer Set  Name= N'{1}', DOB= N'{2}', Passport= N'{3}', Nationality= N'{4}', Address= N'{5}', Expiry_date= N'{6}', Phone= N'{7}', Modified_By= N'{8}',Modified= N'{9}', DrivingLisence=N'{10}', IDLisence=N'{11}', Email=N'{12}' where ID={0}"
            , obj.ID, obj.Name,common.toFormatTime( obj.DOB), obj.Passport, obj.Nationality, obj.Address, common.toFormatTime(obj.Expiry_date), obj.Phone, obj.Modified_By, obj.Modified,obj.DrivingLisence,obj.IDLisence,obj.Email);
        try 
        { 
            if(!CheckExistPrimaryKey(obj.ID)) 
                MessageBox.Show("Error: Primary key isn't exist", " Check Exist Primary Key", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            else 
                result = dtConfig.ExecuteNoneQuery(sql); 
        } 
        catch (SqlException ex) 
        { 
            MessageBox.Show("Error: " + ex.Message, " Update Infor Customer", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return result; 
    } 
    // Xóa thông tin Customer 
    public int Delete(Customer obj ) 
    { 
        int result = 0; 
        string sql =string.Format(" Delete From Customer Where ID = N'{0}'" 
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
            MessageBox.Show("Error: " + ex.Message, " Delete Infor Customer", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        } 
        return result; 
    } 
    #endregion 
    // 
}
 } 
