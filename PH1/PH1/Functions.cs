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

        private static string host_name = @"DESKTOP-JBH7I57";
        //private static string host_name = @"DESKTOP-254FJBP";

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

        public static DataTable GetAll_TableName(String dbname) // lấy tất cả tên bảng mà thằng AD này sở hữu
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = $"SELECT table_name FROM dba_tables where owner = '{dbname}'";
            command.Connection = Con;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable(); //create a new table
            adapter.Fill(dataTable);

            return dataTable;
        }

        public static DataTable GetPrivilegeOnTable(String username) // lất tất cả các quyền trên bảng của 1 user
        {
            username = username.ToUpper();
            OracleCommand command = new OracleCommand();
            command.CommandText = $"SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE = '{username}' AND TYPE = 'TABLE' ORDER BY TABLE_NAME";
            command.Connection = Con;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable(); //create a new table
            adapter.Fill(dataTable);

            return dataTable;
        }

        public static DataTable GetAllRoles()
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = "SELECT ROLE, ROLE_ID " +
                "FROM USER_ROLE_PRIVS US JOIN DBA_ROLES DR ON DR.ROLE = US.GRANTED_ROLE " +
                "WHERE DR.ROLE <> 'CONNECT' AND DR.ROLE <> 'RESOURCE' AND DR.ROLE <> 'DBA'";
            command.Connection = Con;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable(); //create a new table
            adapter.Fill(dataTable);

            return dataTable;
        }

        public DataTable GetAllUsers()
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = $"SELECT * FROM dba_users WHERE ACCOUNT_STATUS = 'OPEN' ORDER BY CREATED DESC";
            command.Connection = Con;

            OracleDataAdapter adapter;
            DataTable dataTable;
            try
            {
                adapter = new OracleDataAdapter(command);
                dataTable = new DataTable(); //create a new table
                adapter.Fill(dataTable);
            }
            catch (OracleException ex)
            {
                throw new Exception(ex.Message);
            }

            return dataTable;
        }

        // SP cua Tuan
        //SP kiem tra xem role co ton tai trong he thong hay khong
        public static String CheckIfUserOrRoleExist(String userOrRole_name)
        {
            userOrRole_name = userOrRole_name.ToUpper();
            string result = "";
            OracleCommand command = new OracleCommand("sp_checkIfUserOrRoleExist", Con);
            command.CommandType = CommandType.StoredProcedure;

            //Tham so dau vao
            OracleParameter param1 = new OracleParameter("userOrRole_name", OracleDbType.Varchar2);
            param1.Value = userOrRole_name;
            command.Parameters.Add(param1);

            //Tham so dau ra
            command.Parameters.Add("result", OracleDbType.Varchar2, 32767); //32767 la cai size cua output
            command.Parameters["result"].Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            result = command.Parameters["result"].Value.ToString();
            return result;
        }

        //SP Ktra xem quyen nay co thuoc ve user hay khong
        public static string CheckIfPrivilegeBelongToUser(String user_name, String table_name, String priv, String grant_opt)
        {
            user_name = user_name.ToUpper();
            table_name = table_name.ToUpper();
            priv = priv.ToUpper();
            grant_opt = grant_opt.ToUpper();
            string result = "";
            OracleCommand command = new OracleCommand("sp_checkIfPrivilegeBelongToUser", Con);
            command.CommandType = CommandType.StoredProcedure;

            //Tham so dau vao
            OracleParameter param1 = new OracleParameter("user_name", OracleDbType.Varchar2);
            param1.Value = user_name;
            command.Parameters.Add(param1);

            OracleParameter param2 = new OracleParameter("userTable_name", OracleDbType.Varchar2);
            param2.Value = table_name;
            command.Parameters.Add(param2);

            OracleParameter param3 = new OracleParameter("user_priv", OracleDbType.Varchar2);
            param3.Value = priv;
            command.Parameters.Add(param3);

            OracleParameter param4 = new OracleParameter("grant_opt", OracleDbType.Varchar2);
            param4.Value = grant_opt;
            command.Parameters.Add(param4);


            //Tham so dau ra
            command.Parameters.Add("checkResult", OracleDbType.Varchar2, 32767); //32767 la cai size cua output
            command.Parameters["checkResult"].Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            result = command.Parameters["checkResult"].Value.ToString();
            return result;
        }

        // SP ktra xem quyen nay co thuoc ve role dang xet hay khong
        public static string CheckIfPrivilegeBelongToRole(String role_name, String roleTable_name, String priv, String grant_opt)
        {
            role_name = role_name.ToUpper();
            roleTable_name = roleTable_name.ToUpper();
            priv = priv.ToUpper();
            grant_opt = grant_opt.ToUpper();
            string result = "";
            OracleCommand command = new OracleCommand("sp_checkIfPrivilegeBelongToRole", Con);
            command.CommandType = CommandType.StoredProcedure;

            //Tham so dau vao
            OracleParameter param1 = new OracleParameter("role_name", OracleDbType.Varchar2);
            param1.Value = role_name;
            command.Parameters.Add(param1);

            OracleParameter param2 = new OracleParameter("roleTable_name", OracleDbType.Varchar2);
            param2.Value = roleTable_name;
            command.Parameters.Add(param2);

            OracleParameter param3 = new OracleParameter("role_priv", OracleDbType.Varchar2);
            param3.Value = priv;
            command.Parameters.Add(param3);

            OracleParameter param4 = new OracleParameter("grant_opt", OracleDbType.Varchar2);
            param4.Value = grant_opt;
            command.Parameters.Add(param4);

            //Tham so dau ra
            command.Parameters.Add("checkResult", OracleDbType.Varchar2, 32767); //32767 la cai size cua output
            command.Parameters["checkResult"].Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            result = command.Parameters["checkResult"].Value.ToString();
            return result;
        }

        //Ham revoke quyen bat ky ra khoi user/role
        public static void RevokePrivilegeOnTable(String table_name, String userOrRole_name, String priv)
        {
            table_name = table_name.ToUpper();
            userOrRole_name = userOrRole_name.ToUpper();
            priv = priv.ToUpper();

            OracleCommand command = new OracleCommand();
            command.CommandText = $"REVOKE {priv} ON {table_name} FROM {userOrRole_name}";
            command.Connection = Con;
            command.ExecuteNonQuery();

            /*
            OracleCommand command = new OracleCommand("sp_revokePrivilegeOnTable", Con);
            command.CommandType = CommandType.StoredProcedure;

            //Tham so dau vao
            OracleParameter param1 = new OracleParameter("table_name", OracleDbType.Varchar2);
            param1.Value = table_name;
            command.Parameters.Add(param1);

            OracleParameter param2 = new OracleParameter("userOrRole_name", OracleDbType.Varchar2);
            param2.Value = userOrRole_name;
            command.Parameters.Add(param2);

            OracleParameter param3 = new OracleParameter("priv", OracleDbType.Varchar2);
            param3.Value = priv;
            command.Parameters.Add(param3);

            command.ExecuteNonQuery();
            */

        }

        //Ham grant quyen bat ky cho user/role
        public static void GrantPrivilegeOnTable(String table_name, String userOrRole_name, String priv, string grant_opt)
        {
            table_name = table_name.ToUpper();
            userOrRole_name = userOrRole_name.ToUpper();
            priv = priv.ToUpper();
            grant_opt = grant_opt.ToUpper();

            OracleCommand command = new OracleCommand();
            command.CommandText = $"GRANT {priv} ON {table_name} TO {userOrRole_name} {grant_opt}";
            command.Connection = Con;
            command.ExecuteNonQuery();


            /*
            OracleCommand command = new OracleCommand("sp_grantPrivilegeOnTable", Con);
            command.CommandType = CommandType.StoredProcedure;

            //Tham so dau vao
            OracleParameter param1 = new OracleParameter("table_name", OracleDbType.Varchar2);
            param1.Value = table_name;
            command.Parameters.Add(param1);

            OracleParameter param2 = new OracleParameter("userOrRole_name", OracleDbType.Varchar2);
            param2.Value = userOrRole_name;
            command.Parameters.Add(param2);

            OracleParameter param3 = new OracleParameter("priv", OracleDbType.Varchar2);
            param3.Value = priv;
            command.Parameters.Add(param3);

            OracleParameter param4 = new OracleParameter("grant_option", OracleDbType.Varchar2);
            param4.Value = grant_opt;
            command.Parameters.Add(param4);

            command.ExecuteNonQuery();
            */
        }
    }
}
