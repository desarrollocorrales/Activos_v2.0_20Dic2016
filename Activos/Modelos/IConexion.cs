﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Activos.Modelos
{
    public interface IConexion
    {
        MySqlConnection getConexion();
    }
}
