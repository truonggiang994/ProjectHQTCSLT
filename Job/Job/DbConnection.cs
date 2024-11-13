using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job
{
    public class DbConnection
    {
        static public SqlConnection GetConnection()
        {
            string connection = "";

            if (Data.role == ERoleLogin.cadidate)
            {
                connection = Properties.Settings.Default.ConnectionCandidate;
            }
            else if (Data.role == ERoleLogin.employ)
            {
                connection = Properties.Settings.Default.ConnectionEmploy;
            }
            else if (Data.role == ERoleLogin.admin)
            {
                connection = Properties.Settings.Default.ConnectionAdmin;
            }

            return new SqlConnection(connection);
        }
    }
}
