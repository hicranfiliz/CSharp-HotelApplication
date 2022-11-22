using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HOTEL
{
    public class Database
    {
        public SqlConnection baglanti = new SqlConnection(@"Data Source=MSI;Initial Catalog=HotelRezervation;Integrated Security=True");
    }
}
