using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace Do_an
{
    class Database
    {
        public static SqlDataAdapter adapter;
        public static SqlCommand cmd;
        public string conStr = @"Data Source=DESKTOP-6QRUFE5\MSSQLSERVER01;Initial Catalog = QLMUABAN; Integrated Security = True;";
        public SqlConnection getConnection()
        {
            return new SqlConnection(conStr);
        }
        
        public DataTable getAllData(string query)
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (SqlConnection con = getConnection())
                {
                    con.Open();
                    adapter = new SqlDataAdapter(query, con);
                    adapter.Fill(dataTable);
                    con.Close();
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
    }
}
