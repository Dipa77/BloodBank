using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace BBMS
{
    internal class Function
    {
        protected static SqlConnection GetConnection() 
        {
            SqlConnection conn = new SqlConnection();
            //Data Source = LENOVOIP\SQLEXPRESS; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = True; Application Intent = ReadWrite; Multi Subnet Failover = False
            conn.ConnectionString = "data source = LENOVOIP\\SQLEXPRESS;database = BBMS;integrated security = True; Trust Server Certificate = True;";
            return conn; 
       
        }
        public DataSet getData(string query)
        {
            SqlConnection conn = GetConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn;
            sqlCommand.CommandText = query;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataSet data = new DataSet();
            adapter.Fill(data);
            return data; 
        }
        public void setData(string query)
        {
            SqlConnection conn = GetConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn;
            conn.Open();
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data has been processed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
