using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace PH1
{
    public class Functions
    {
        public static OracleConnection Con;
        //private static string host_name = @"DESKTOP-JBH7I57";
        private static string host_name = @"DESKTOP-254FJBP"; // Minh Host

        //private static string host_name = @"DESKTOP-2J1CNMG";
        //private static string host_name = @"DESKTOP-30F3CUE"; //Tuan host

        public static void InitConnection(String username, String password)
        {           
            String connectionString = @"Data Source=" + host_name + ";User ID=" + username + ";Password=" + password + "";

            Con = new OracleConnection();
            Con.ConnectionString = connectionString;         

            try
            {
                //Mở kết nối
                Con.Open();

                ////Kiểm tra kết nối
                //if (Con.State == ConnectionState.Open)
                //{
                //    MessageBox.Show("Kết nối DB thành công");
                //}

            }
            catch (OracleException ex)
            {
                Con = null;
                throw new Exception(ex.Message);
                MessageBox.Show("Không thể kết nối với DB");
            }         
        }

        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                //Đóng kết nối
                Con.Close();

                //Giải phóng tài nguyên
                Con.Dispose();
                Con = null;

                //MessageBox.Show("Đóng kết nối với DB");
            }
        }

        public static void RunSQL(string sql) // chạy câu lệnh sql
        {
            OracleCommand cmd = new OracleCommand();

            //Gán kết nối
            cmd.Connection = Con;

            //Gán lệnh SQL
            cmd.CommandText = sql;

            //Thực hiện câu lệnh SQL
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //Giải phóng bộ nhớ
            cmd.Dispose();
            cmd = null;
        }

        public static int RunSQLwithResult(string sql) // chạy câu lệnh sql
        {
            OracleCommand cmd = new OracleCommand();

            //Gán kết nối
            cmd.Connection = Con;

            //Gán lệnh SQL
            cmd.CommandText = sql;

            //Thực hiện câu lệnh SQL
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }

            //Giải phóng bộ nhớ
            cmd.Dispose();
            cmd = null;
            return 1;
        }

        public static int isUserValid(string username) // chạy câu lệnh sql
        {
            OracleCommand cmd = new OracleCommand();

            //Gán kết nối
            cmd.Connection = Con;

            //Gán lệnh SQL
            string sql = "SELECT * FROM all_users WHERE USERNAME = " + "'" + username + "'";
            cmd.CommandText = sql;

            //Kiểm tra
            OracleDataReader reader = cmd.ExecuteReader();
            //bool exists = Convert.ToBoolean(cmd.ExecuteScalar());

            if (reader.Read())
            {
                //Giải phóng bộ nhớ
                cmd.Dispose();
                cmd = null;
                return 1;
            }
            else
            {
                //Giải phóng bộ nhớ
                cmd.Dispose();
                cmd = null;
                return 0;
            }
        }

        public static DataTable GetDataToTable(string sql) //Lấy dữ liệu đổ vào bảng
        {          
            OracleCommand command = new OracleCommand();
            command.CommandText = sql;
            command.Connection = Con;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable(); //create a new table
            adapter.Fill(dataTable);

            return dataTable;
        }
    }
}
