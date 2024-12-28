using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class baglanti
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=ELYASA\SQLEXPRESS;Initial Catalog=DbEntityKisi;Integrated Security=True;Encrypt=False");

    }
}
