// Khai báo các namespace cần sử dụng! 
using System; 
using System.Text; 
using System.Data; 
using System.Data.SqlClient; 

namespace CPE_vs1.DataAccessLayer 
{ 
// Class DataAccessLayer 
public class DataConfig 
{
    // 
    #region Khai báo các đối tượng và các biến cần dùng. 
    // Đối tượng dùng để kết nối. 
    private SqlConnection sqlConnection; 
    // Đối tượng thực hiện các câu lệnh thêm, sửa, xóa. 
    private SqlCommand sqlCommand; 
    // Đối tượng dùng để lấy dữ liệu table từ các câu lệnh truy vấn. 
    private SqlDataAdapter sqlAdapter; 
    // Đối tượng table dùng để chứa dữ liệu. 
    private DataTable dtTable; 
    // Chuỗi kết nối. 
    public string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=CPE;Integrated Security=True";
    //public string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=CPE;Integrated Security=True"; 
    #endregion 
    // 
    #region CÁC THỦ TỤC VÀ HÀM XỬ LÝ 
    public DataConfig() 
    { 
        CheckConnect(); 
    } 
    // Thủ tục kết nối SQL 
    public void CheckConnect() 
    { 
        // Thủ tục này thực hiện khởi tạo đối tượng sqlconnection để các phương thức sau sử dụng đối tượng này!. 
        // Thực hiện kiểm tra kết nối đến SQL. 
        string strConnect = connectionString; 
        // Khởi tạo mới đối tượng sqlConnection. 
        sqlConnection = new SqlConnection(strConnect); 
        // Mở kết nối 
        sqlConnection.Open(); 
        // Kiểm tra trạng thái kết nối, nếu đang mở thì đóng kết nối. 
        if (sqlConnection.State == ConnectionState.Open) 
            sqlConnection.Close(); 
    } 
    // Thủ tục lấy dữ liệu dạng bảng (data table) từ câu lệnh truy vấn. 
    public DataTable GetDataTable(string strCode) 
    { 
        dtTable = new DataTable(); 
        // Khởi tạo đối tượng data adapter 
        sqlAdapter = new SqlDataAdapter(strCode, sqlConnection); 
        // Đổ dữ liệu vào đối tượng dtTable. 
        sqlAdapter.Fill(dtTable); 
        return dtTable; 
    } 
    // Hàm thực thi các câu lệnh: thêm, sữa, xóa. 
    public int ExecuteNoneQuery(string strCode) 
    { 
        // Trả vể số lượng bản ghi thực hiện được khi thực thi câu lệnh. 
        int ressult = 0; 
        // Mở kết nối trước khi sử dụng đối tượng sqlCommand. 
        if (sqlConnection.State == ConnectionState.Closed) 
            sqlConnection.Open(); 
        // Khởi tạo đối tượng sqlCommand. 
        sqlCommand = new SqlCommand(strCode, sqlConnection); 
        sqlCommand.CommandType = CommandType.Text; 
        // Sổ bản ghi thực hiện được. 
        ressult= sqlCommand.ExecuteNonQuery(); 
        // 
        // Đống kết nối. 
        if (sqlConnection.State == ConnectionState.Open) 
            sqlConnection.Close(); 
        return ressult; 
    }
    // Hàm thực thi các câu lệnh trả về 1 giá trị. 
    public int ExecuteScalarQuery1(string strCode)
    {
        int result;
        // Mở kết nối. 
        if (sqlConnection.State == ConnectionState.Closed)
            sqlConnection.Open();
        // Khởi tạo đối tượng sqlCommand. 
        sqlCommand = new SqlCommand(strCode, sqlConnection);
        sqlCommand.CommandType = CommandType.Text;
        result = common.parseInt(sqlCommand.ExecuteScalar());
        if (sqlConnection.State == ConnectionState.Open)
            sqlConnection.Close();
        return result;
    } 
    // Hàm thực thi các câu lệnh trả về 1 giá trị. 
    public string ExecuteScalarQuery(string strCode) 
    { 
        string result = ""; 
         // Mở kết nối. 
        if (sqlConnection.State == ConnectionState.Closed) 
            sqlConnection.Open(); 
        // Khởi tạo đối tượng sqlCommand. 
        sqlCommand = new SqlCommand(strCode, sqlConnection); 
        sqlCommand.CommandType = CommandType.Text; 
        result = sqlCommand.ExecuteScalar().ToString(); 
        if (sqlConnection.State == ConnectionState.Open) 
            sqlConnection.Close(); 
        return result; 
    }
    public void InsertTrackLog(string Action, string Type)
    {
        ExecuteNoneQuery("insert into tracklog values(N'" + Action + "',N'" + Type + "',N'" + DateTime.Now + "',N'" + SessionCur.staff.ID + "')");
    }
    #endregion 
}
 } 
