using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgrammForBD
{
    public struct Temp
    {
       public string Label { get; set; }
       public string Text { get; set; }
            
    }
    public class TestData
    {
        
        SqlConnection conn;
        public string Connect()
        {
            //string connStr = @"Data Source=(local)\SQLEXPRESS;
            //                Initial Catalog=Df;
            //                user=Violentik;password=123;";
            string connStr = @"Data Source=(local)\SQLEXPRESS;
                            Initial Catalog=DF;
                            Integrated Security=True";
            conn = new SqlConnection(connStr);
            try
            {
                //пробуем подключится
                conn.Open();
            }
            catch 
            {
                throw;
                
                // Console.WriteLine("Ошибка подключения:{0}", se.Message);
               
            }
            return "успешно";
                  
        }
        public void Reset(DataTable table,string tableName)
        {
            string sql = string.Format("Select * From {0}", tableName);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
           SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(table);

            
        }
        public DataTable Show(string tableName)
        {
            DataTable table = new DataTable();
            string sql = string.Format("Select * From {0}", tableName);
            using (SqlDataAdapter adaprer = new SqlDataAdapter(sql, conn))
            {
                adaprer.Fill(table);
            }
            return table;
        }
        public DataTable ShowProperties()
        {
            DataTable table = new DataTable();
            string sql = "Select p.Condition, p.LivingSpace,p.JustSpace, p.address,c.Price" +
                " from TheProperty p Inner Join Contract c ON p.TheProperty_ID = c.TheProperty_ID";
            using (SqlDataAdapter adaprer = new SqlDataAdapter(sql, conn))
            {
                adaprer.Fill(table);
            }
            return table;
        }
        public string InsertIntoClient(string Name,string Surname,string Patronymic,string PhoneNumber, string Address)
        {
                        string sql = "Insert into Client" +
                "(Name,Surname,Patronymic,PhoneNumber,Address) Values (@Name,@Surname,@Patr,@Phn,@Addr)";
            SqlCommand cmd = new SqlCommand(sql,conn);
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@Name";
            param.Value = Name;
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);
            param = new SqlParameter();
            param.ParameterName = "@Surname";
            param.Value = Surname;
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);
            param = new SqlParameter();
            param.ParameterName = "@Patr";
            param.Value = Patronymic;
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);
            param = new SqlParameter();
            param.ParameterName = "@Phn";
            param.Value = PhoneNumber;
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);
            param = new SqlParameter();
            param.ParameterName = "@Addr";
            param.Value = Address;
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return "Ошибка, при выполнении запроса на удаление записи";
            }
            return "успешно";
        }
        public string InsertIntoProperty(string Condition, int LivingSpace, int JustSpace,string Address)
        {
            string sql = "Insert into TheProperty" +
    "(Condition,LivingSpace,JustSpace,Address) Values (@Con,@LivSp,@JustSp,@Addr)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@Con";
            param.Value = Condition;
            param.SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.Add(param);
            param = new SqlParameter();
            param.ParameterName = "@LivSp";
            param.Value = LivingSpace;
            param.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(param);
            param = new SqlParameter();
            param.ParameterName = "@JustSp";
            param.Value = JustSpace;
            param.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(param);
            param = new SqlParameter();
            param.ParameterName = "@Addr";
            param.Value = Address;
            param.SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.Add(param);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return "Ошибка, при выполнении запроса на удаление записи";
            }
            return "успешно";
        }
        public string InsertIntoRealtor(string Name, string Surname, string Patronymic, string PhoneNumber, string Address)
        {
            string sql = "Insert into Realtor" +
    "(Name,Surname,Patronymic,PhoneNumber,Address) Values (@Name,@Surname,@Patr,@Phn,@Addr)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@Name";
            param.Value = Name;
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);
            param = new SqlParameter();
            param.ParameterName = "@Surname";
            param.Value = Surname;
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);
            param = new SqlParameter();
            param.ParameterName = "@Patr";
            param.Value = Patronymic;
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);
            param = new SqlParameter();
            param.ParameterName = "@Phn";
            param.Value = PhoneNumber;
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);
            param = new SqlParameter();
            param.ParameterName = "@Addr";
            param.Value = Address;
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return "Ошибка, при выполнении запроса на удаление записи";
            }
            return "успешно";
        }
        public string UpdateIntoRealtor(string Name, string Surname, string Patronymic, string PhoneNumber, string Address,int ID)
        {
            string sql = "UPDATE Realtor Set Name=@Name,Surname=@Surname,Patronymic=@Patr,PhoneNumber=@Phn,address=@Addr where Realtor_Id=@ID";
            
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@Name";
            param.Value = Name;
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);
            param = new SqlParameter();
            param.ParameterName = "@Surname";
            param.Value = Surname;
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);
            param = new SqlParameter();
            param.ParameterName = "@Patr";
            param.Value = Patronymic;
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);
            param = new SqlParameter();
            param.ParameterName = "@Phn";
            param.Value = PhoneNumber;
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);
            param = new SqlParameter();
            param.ParameterName = "@Addr";
            param.Value = Address;
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);
            param = new SqlParameter();
            param.ParameterName = "@ID";
            param.Value = ID;
            param.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(param);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(SqlException e)
            {
                return e.Message;
            }
            return "успешно";
        }
        public string UpdateIntoClient(string Name, string Surname, string Patronymic, string PhoneNumber, string Address, int ID)
        {
            string sql = "UPDATE Client Set Name=@Name,Surname=@Surname,Patronymic=@Patr,PhoneNumber=@Phn,address=@Addr where Client_Id=@ID";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@Name";
            param.Value = Name;
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);
            param = new SqlParameter();
            param.ParameterName = "@Surname";
            param.Value = Surname;
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);
            param = new SqlParameter();
            param.ParameterName = "@Patr";
            param.Value = Patronymic;
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);
            param = new SqlParameter();
            param.ParameterName = "@Phn";
            param.Value = PhoneNumber;
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);
            param = new SqlParameter();
            param.ParameterName = "@Addr";
            param.Value = Address;
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);
            param = new SqlParameter();
            param.ParameterName = "@ID";
            param.Value = ID;
            param.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(param);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return "Ошибка, при выполнении запроса на удаление записи";
            }
            return "успешно";
        }
        
        public string GetSqlName(string temp)
        {
            return "'" + temp + "'";
        }
        public string Delete(int ID)
        {
            using (SqlCommand cmd = new SqlCommand("Delete From Client" +
                " where  Client_ID = @ID", conn))
            {
                
                SqlParameter param = new SqlParameter();
                //задаем имя параметра
                param.ParameterName = "@ID";
                //задаем значение параметра
                param.Value = ID;
                //задаем тип параметра
                param.SqlDbType = SqlDbType.Int;
                //передаем параметр объекту класса SqlCommand
                cmd.Parameters.Add(param);
                //переопределяем объект класса SqlParameter

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {

                    return "Ошибка, при выполнении запроса на удаление записи";
                }
                return "успешно";
            }
        }
    }
}
