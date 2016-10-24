using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace MPLSMS
{
    class Connection
    {
        public int MyProperty { get; set; }

        public SqlConnection con()
        {
            // Create connection and add connection string
            string strcon;
            strcon = Properties.Settings.Default.MARKSPENConnectionString; // "server=.;database=MARKSPEN; integrated security= true";
            SqlConnection con = new SqlConnection(strcon);
            return con;
        }

    }
}
