using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BBMS
{
    internal class Function
    {
        protected static SqlConnection GetConnection() 
        {
         SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source = LENOVOIP\\SQLEXPRESS;database = BBMS;integrated security = True";
            return conn; 
       
        }
        public DataSet getData(String query)
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
        public void setData(String query)
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
