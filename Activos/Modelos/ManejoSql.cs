using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Activos.Modelos
{
    public class ManejoSql
    {
        public bool ok { get; set; }
        public MySqlDataReader reader { get; set; }
        public int numErr { get; set; }
        public string descErr { get; set; }
    }
}
