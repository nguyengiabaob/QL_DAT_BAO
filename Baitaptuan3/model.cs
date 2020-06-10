using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Baitaptuan3
{
    class model
    {
        public static string cnnsttring = "Data Source=desktop-t11fg2c\\sqlexpress;Initial Catalog=QL_DATBAO;Integrated Security=True";
        public static SqlConnection cnn = new SqlConnection(cnnsttring);
    }
}
