using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace YazOkulu.DataAccessLayer
{
    public class DBHelper
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=HAMDIDAMAR\SQL_2014;Initial Catalog=DboYazOkulu;Integrated Security=True");    
    }
}
