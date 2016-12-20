﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activos.Modelos
{
    public class Usuarios
    {
        public int idUsuario { get; set; }
        public string nombre { get; set; }
        public int? idPuesto { get; set; }
        public string fechaIngreso { get; set; }
        public string correo { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public string status { get; set; }
    }
}
