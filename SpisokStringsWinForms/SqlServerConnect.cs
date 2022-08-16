using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpisokStringsWinForms
{
    public class SqlServerDatabaseInterface
    {
            string IPSQLServer;
            string NameDB;
            string loginDB;
            string passwordDB;

        const string select_from = "select * from ";

        private System.Data.SqlClient.SqlConnection connection;
        private string connection_string = "";

        SqlDataAdapter GetAdapter(string table)
        {
            return InitDataAdapter(select_from + " ["+NameDB+"].[dbo].[" + table + "]");
        }

        public void SqlServerDatabaseInterface2()
        {
            connection_string = "Data Source=127.0.0.1;" + "Initial Catalog=DBTest;" + "User id=sa_;" + "Password=000;";
            connection = new SqlConnection(connection_string);
        }

        public SqlServerDatabaseInterface(
            string IPSQLServer,
            string NameDB,
            string loginDB,
            string passwordDB
            )
        {
            this.IPSQLServer = IPSQLServer;
            this.NameDB = NameDB;
            this.loginDB = loginDB;
            this.passwordDB = passwordDB;

            connection_string = 
                "Data Source="+ IPSQLServer+";" + 
                "Initial Catalog="+NameDB+";" + 
                "User id="+loginDB+";" + 
                "Password="+passwordDB+";";
            connection = new SqlConnection(connection_string);
        }

        public string GetConnectionString()
        {
            return connection_string;
        }

        //public SqlServerDatabaseInterface()
        //{

        //}

        public void Open()
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
        }

        public void Close()
        {
            connection.Close();
        }

        public string GetDataBasePath()
        {
            return connection.Database;
        }

        public SqlDataAdapter InitDataAdapter(string SelectCommand)
        {
            SqlTransaction transaction;
            //transaction = connection.BeginTransaction();            
            try
            {
                var tmp = new SqlDataAdapter(SelectCommand, connection);
                SqlCommandBuilder cb = new SqlCommandBuilder(tmp);
                // sda.SelectCommand = cb.GetInsertCommand();
                tmp.InsertCommand = cb.GetInsertCommand();
                tmp.UpdateCommand = cb.GetUpdateCommand();
                tmp.DeleteCommand = cb.GetDeleteCommand();
                //transaction.Commit();
                return tmp;
            }
            catch (Exception err)
            {
                //transaction.Rollback();                
                //MessageBox.Show(ex.Message + "; Ошибка выполнения запроса: " + SelectCommand +
                //    " - возможно отсуствует таблица; пересоздайте discData.db через меню Settings->Базы->создать базу флеш и затем через настройки определите новое положение файла " +
                //    "[ возможно отсуствует таблица; 0002 " + "]");
            }
            return null;
        }

        void GetTimeStamp()
        {

        }

        public void InitDataAdapterUpdate_(string SelectCommand)
        {
            SqlCommand Command = new SqlCommand(SelectCommand, connection);
            Command.ExecuteNonQuery();
        }


        private void FillDataInDataset(out DataSet oldData, SqlDataAdapter sda)
        {
            oldData = new DataSet();
            sda.Fill(oldData);
        }

        private void CreateTable(string cmd, SqlConnection connect)
        {
            SqlCommand command = new SqlCommand(cmd, connect);
            connect.Open(); // открыть соединение
            command.ExecuteNonQuery(); // выполнить запрос
            connect.Close(); // закрыть соединение
        }

        public void CreateTableDB(string tabDB = Datas.TableSpisokStrings)
        {
            //connection = new SqlConnection(connection_string);
            using (SqlConnection Connect = new SqlConnection(connection_string)) // в строке указывается к какой базе подключаемся
            {
                CreateTable("IF OBJECT_ID(N'" + tabDB + "', N'U') IS NULL CREATE TABLE [" + tabDB + "]    ( [ind] INTEGER IDENTITY(1,1) PRIMARY KEY, [Strings] NVARCHAR(500))", Connect);
            }
        }

        public void CreateTableDB2(string tabDB = Datas.TableSpisokStringsGroup)
        {
            //connection = new SqlConnection(connection_string);
            using (SqlConnection Connect = new SqlConnection(connection_string)) // в строке указывается к какой базе подключаемся
            {
                CreateTable("IF OBJECT_ID(N'" + tabDB + "', N'U') IS NULL CREATE TABLE [" + tabDB + "]    ( [ind] INTEGER IDENTITY(1,1) PRIMARY KEY, [GroupName] NVARCHAR(500), [Strings] NVARCHAR(500))", Connect);
            }
        }

       
        bool Ret_not_null(string ret)
        {
            return (ret != "") ? true : false;
            //return (ret != null) ? ret : new byte[] { 0 };          
        }

        byte[] Ret(byte[] ret)
        {
            return (ret != null) ? ret : System.Text.Encoding.ASCII.GetBytes("");
            //return (ret != null) ? ret : new byte[] { 0 };          
        }

        byte[] Ret(object ret)
        {
            string type = ret.GetType().ToString().ToLower();
            return (!type.Contains("dbnull")) ? (byte[])ret : null;
            //return (!type.Contains("dbnull")) ? (byte[])ret : System.Text.Encoding.ASCII.GetBytes("");
        }

        bool Ret_not_null(object ret)
        {
            string type = ret.GetType().ToString().ToLower();
            return (type.Contains("dbnull")) ? true : false;
        }


        bool Ret_not_null(byte[] ret)
        {
            return (ret != null) ? true : false;
            //return (ret != null) ? ret : new byte[] { 0 };          
        }


        StringId FillString(SqlDataReader reader)
        {            
            StringId strId = new StringId();
                try
                {                                        
                    strId = new StringId() 
                    { 
                        Id = int.Parse(reader[reader.GetName(0)].ToString()),
                        ValStr = reader[reader.GetName(1)].ToString()
                    };
                    return strId;
                }
                catch (Exception e)
                {
                    //Util.MessageError_logDebug("SQliteDatabaseInterface: метод FillUsbDisk ", e.Message);
                    //MessageBox.Show(e.Message);
                    //u.GetType().GetField(reader.GetName(i)).SetValue(u, "");
                }            
            return strId;
        }

        StringId FillStringGroup(SqlDataReader reader)
        {
            StringId strId = new StringId();
            try
            {
                strId = new StringId()
                {
                    Id = int.Parse(reader[reader.GetName(0)].ToString()),
                    GroupName = reader[reader.GetName(1)].ToString(),
                    ValStr = reader[reader.GetName(2)].ToString()
                };
                return strId;
            }
            catch (Exception e)
            {
                //Util.MessageError_logDebug("SQliteDatabaseInterface: метод FillUsbDisk ", e.Message);
                //MessageBox.Show(e.Message);
                //u.GetType().GetField(reader.GetName(i)).SetValue(u, "");
            }
            return strId;
        }

        public List<StringId> GetSpisokStrings()
        {
            List<StringId> fil = new List<StringId>();
            StringId strID = new StringId();
            try
            {
                SqlCommand CMD = connection.CreateCommand();
                CMD.CommandText = select_from + " " + Datas.TableSpisokStrings;
                SqlDataReader reader = CMD.ExecuteReader();
                while (reader.Read())
                {
                    //if (reader["Strings"].ToString() == ind.ToString())
                    {
                        strID = FillString(reader);
                        fil.Add(strID);
                        //break;
                    }
                }
                reader.Close();
            }
            catch (Exception e)
            {
                //Util.MessageError_logDebug("SQliteDatabaseInterface: метод GetUsbDisk ", e.Message);
                //MessageBox.Show(e.Message);
            }
            return fil;
        }

        public List<StringId> GetSpisokStringsGroup(string searchGroup = "")
        {
            List<StringId> fil = new List<StringId>();
            StringId strID = new StringId();
            try
            {
                SqlCommand CMD = connection.CreateCommand();
                CMD.CommandText = select_from + " " + Datas.TableSpisokStringsGroup + " order by GroupName ASC";
                SqlDataReader reader = CMD.ExecuteReader();
                while (reader.Read())
                {
                    //if (reader["Strings"].ToString() == ind.ToString())
                    {
                        strID = FillStringGroup(reader);
                        if(searchGroup=="") fil.Add(strID);
                        else
                        {
                            if(strID.GroupName==searchGroup) fil.Add(strID);
                        }
                        //break;
                    }
                }
                reader.Close();
            }
            catch (Exception e)
            {
                //Util.MessageError_logDebug("SQliteDatabaseInterface: метод GetUsbDisk ", e.Message);
                //MessageBox.Show(e.Message);
            }
            return fil;
        }


        public void TableAdd(List<string> strings)
        {
            SqlDataAdapter dda = GetAdapter(Datas.TableSpisokStrings);
            DataSet oldData;
            DataRow dr;
            try
            {
                FillDataInDataset(out oldData, dda);
                foreach (var str in strings)
                {
                    dr = oldData.Tables[0].NewRow();
                    dr["Strings"] = str;
                    oldData.Tables[0].Rows.Add(dr);
                    var b = dda.Update(oldData);
                }                    
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }



        public void TableAdd(List<StringId> strings)
        {
            SqlDataAdapter dda = GetAdapter(Datas.TableSpisokStringsGroup);
            DataSet oldData;
            DataRow dr;
            try
            {
                FillDataInDataset(out oldData, dda);
                foreach (var str in strings)
                {
                    dr = oldData.Tables[0].NewRow();
                    dr["Strings"] = str.ValStr;
                    dr["GroupName"] = str.GroupName;
                    oldData.Tables[0].Rows.Add(dr);
                    var b = dda.Update(oldData);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void TableAdd(string ValStr)
        {
            SqlDataAdapter dda = GetAdapter(Datas.TableSpisokStrings);
            DataSet oldData;
            DataRow dr;
            try
            {
                FillDataInDataset(out oldData, dda);
                dr = oldData.Tables[0].NewRow();
                dr["Strings"] = ValStr;
                oldData.Tables[0].Rows.Add(dr);
                var b = dda.Update(oldData);
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void TableUpdate(int Ind=3, string newValStr = "!!!!!!!!!!!!")
        {
            SqlDataAdapter dda = GetAdapter(Datas.TableSpisokStrings);
            DataSet oldData;
            DataRow dr;
            FillDataInDataset(out oldData, dda);
            //create new row assign value to it.
            DataRow[] tempdata = oldData.Tables[0].AsEnumerable().Where(p => p["Ind"].ToString() == Ind.ToString()).ToArray();
            if (tempdata.Length > 0)
            {
                dr = tempdata[0];
                dr["Strings"] = newValStr;
                
            }
            dda.Update(oldData);
        }

        public void TableDelete(int id)
        {
            SqlDataAdapter dda = GetAdapter(Datas.TableSpisokStrings);

            DataSet oldData;
            DataRow dr;
            FillDataInDataset(out oldData, dda);
            //create new row assign value to it.
            DataRow[] tempdata = oldData.Tables[0].AsEnumerable().Where(p => p["ind"].ToString() == id.ToString()).ToArray();
            if (tempdata.Length > 0)
            {
                dr = tempdata[0];
                dr.Delete();
            }
            dda.Update(oldData);
        }

        public void TableDelete(string groupname)
        {
            SqlDataAdapter dda = GetAdapter(Datas.TableSpisokStringsGroup);

            DataSet oldData;
            DataRow dr;
            FillDataInDataset(out oldData, dda);
            //create new row assign value to it.
            
            DataRow[] tempdata = oldData.Tables[0].AsEnumerable().Where(p => p["GroupName"].ToString() == groupname).ToArray();
            
            for(int i=0;i<tempdata.Length;i++)
            {

                //if (tempdata.Length > 0)
                {
                    dr = tempdata[i];
                    dr.Delete();
                }
                //else break;
            }
            dda.Update(oldData);
        }

        public void TableDeleteAll(string tabname)
        {
            SqlDataAdapter dda = GetAdapter(tabname);

            DataSet oldData;
            DataRow dr;
            FillDataInDataset(out oldData, dda);
            //create new row assign value to it.

            DataRow[] tempdata = oldData.Tables[0].AsEnumerable().Where(p => p["Ind"].ToString() == p["Ind"].ToString()).ToArray();

            for (int i = 0; i < tempdata.Length; i++)
            {

                //if (tempdata.Length > 0)
                {
                    dr = tempdata[i];
                    dr.Delete();
                }
                //else break;
            }
            dda.Update(oldData);
        }

        // ******************* DiskData.db - PhisonDisks ***********************
    }
}
