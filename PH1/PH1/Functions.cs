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

        private static string host_name = @"DESKTOP-PU7OUUT"; // Duc
       // private static string host_name = @"DESKTOP-9C6VMF0"; // Minh Host

       //private static string host_name = @"DESKTOP-2J1CNMG";
        //private static string host_name = @"DESKTOP-30F3CUE";

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

        public static string GetFieldValues(string sql) // lấy dữ liệu từ câu lệnh sql
        {
            string ma = "";
            OracleCommand cmd = new OracleCommand(sql, Con);
            OracleDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
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

        public static int isUserValid(string username) // Hàm kiểm tra User có tồn tại hay không
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

        public static int isRoleValid(string username)  // Hàm kiểm tra Role có tồn tại hay không
        {
            OracleCommand cmd = new OracleCommand();

            //Gán kết nối
            cmd.Connection = Con;

            //Gán lệnh SQL
            string sql = "SELECT * FROM DBA_ROLES WHERE ROLE = " + "'" + username.ToUpper() + "'";
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

        public static DataTable GetAllUsers_wasCreateByUser()
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

        public static void RevokeRoleFromUser_OR_Role(String role, String user_OR_role) // thu hồi quyền
        {
            role = role.ToUpper();
            user_OR_role = user_OR_role.ToUpper();


            OracleCommand command = new OracleCommand();
            command.CommandText = $"REVOKE {role} FROM {user_OR_role}";
            command.Connection = Con;
            command.ExecuteNonQuery();
            MessageBox.Show("Thu hoi quyen thanh cong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // SP cua Tuan
        //Ham kiem tra xem role co ton tai trong he thong hay khong
        public static String CheckIfUserOrRoleExist(String userOrRole_name)
        {
            userOrRole_name = userOrRole_name.ToUpper();
            string result = "";

            /*
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
            */

            //Kiem tra xem user co ton tai hay khong
            OracleCommand command1 = new OracleCommand();
            command1.CommandText = $"SELECT USERNAME FROM DBA_USERS";
            command1.Connection = Con;

            OracleDataAdapter adapter1 = new OracleDataAdapter(command1);
            DataTable dataTable1 = new DataTable(); //create a new table
            adapter1.Fill(dataTable1);

            for (int i = 0; i < dataTable1.Rows.Count; i++)
            {
                if (dataTable1.Rows[i].Field<string>(0) == userOrRole_name)
                {
                    result = "User";
                    return result;
                }

            }

            //Kiem tra xem role co ton tai hay khong
            OracleCommand command2 = new OracleCommand();
            command2.CommandText = $"SELECT ROLE FROM DBA_ROLES";
            command2.Connection = Con;

            OracleDataAdapter adapter2 = new OracleDataAdapter(command2);
            DataTable dataTable2 = new DataTable(); //create a new table
            adapter2.Fill(dataTable2);

            for (int i = 0; i < dataTable2.Rows.Count; i++)
            {
                if (dataTable2.Rows[i].Field<string>(0) == userOrRole_name)
                {
                    result = "Role";
                    return result;
                }

            }

            result = "NoExist";
            return result;
        }

        //Ham Ktra xem quyen nay co thuoc ve user hay khong
        public static string CheckIfPrivilegeBelongToUser(String user_name, String table_name, String priv, String grant_opt)
        {
            user_name = user_name.ToUpper();
            table_name = table_name.ToUpper();
            priv = priv.ToUpper();
            grant_opt = grant_opt.ToUpper();
            string result = "";

            /*
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
            */

            OracleCommand command1 = new OracleCommand();
            command1.CommandText = $"SELECT GRANTEE FROM DBA_TAB_PRIVS WHERE GRANTEE = '{user_name}' AND TABLE_NAME = '{table_name}' AND PRIVILEGE = '{priv}' AND GRANTABLE = '{grant_opt}'";
            command1.Connection = Con;

            OracleDataAdapter adapter1 = new OracleDataAdapter(command1);
            DataTable dataTable1 = new DataTable(); //create a new table
            adapter1.Fill(dataTable1);

            for (int i = 0; i < dataTable1.Rows.Count; i++)
            {
                if (dataTable1.Rows[i].Field<string>(0) == user_name)
                {
                    result = "Yes";
                    return result;
                }
            }
            result = "No";
            return result;
        }

        //Ham ktra xem quyen nay co thuoc ve role dang xet hay khong
        public static string CheckIfPrivilegeBelongToRole(String role_name, String roleTable_name, String priv, String grant_opt)
        {
            role_name = role_name.ToUpper();
            roleTable_name = roleTable_name.ToUpper();
            priv = priv.ToUpper();
            grant_opt = grant_opt.ToUpper();
            string result = "";

            /*
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
            */
            OracleCommand command1 = new OracleCommand();
            command1.CommandText = $"SELECT ROLE FROM ROLE_TAB_PRIVS WHERE ROLE = '{role_name}' AND TABLE_NAME = '{roleTable_name}' AND PRIVILEGE = '{priv}' AND GRANTABLE = '{grant_opt}'";
            command1.Connection = Con;
            //command1.ExecuteNonQuery();

            OracleDataAdapter adapter1 = new OracleDataAdapter(command1);
            DataTable dataTable1 = new DataTable(); //create a new table
            adapter1.Fill(dataTable1);

            for (int i = 0; i < dataTable1.Rows.Count; i++)
            {
                if (dataTable1.Rows[i].Field<string>(0) == role_name)
                {
                    result = "Yes";
                    return result;
                }
            }
            result = "No";

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

        //SP gan role cho user/role
        public static void grantRoleToUser_OR_Role(String role, String user_OR_role)
        {
            role = role.ToUpper();
            user_OR_role = user_OR_role.ToUpper();


            OracleCommand command = new OracleCommand();
            command.CommandText = $"GRANT {role} TO {user_OR_role}";
            command.Connection = Con;
            command.ExecuteNonQuery();

            MessageBox.Show("Cap quyen thanh cong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
