using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace AdminKiosco
{
    class SQLConn
    {
        public SqlConnection conn;

        public void Connection() {
            string connectionString = null;
            connectionString = ConfigurationManager.ConnectionStrings["AdminKiosco.Properties.Settings.db1ConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
            conn.Open();
        }
    }
}
