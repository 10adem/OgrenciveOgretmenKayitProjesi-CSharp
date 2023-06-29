using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulSistemi
{
    class baglanti_sql
    {
        public SqlConnection connect()
        {
            SqlConnection connect = new SqlConnection("Data Source = localhost; Initial Catalog = OkulSistemi; Integrated Security = True");
            connect.Open();
            return connect;
        }
    }
}
