﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GymSystemComun;

namespace GymSystemEntity
{
    public class DatosObligatoriosExcepcion : ValidacionExcepcionAbstract 
    {
        public DatosObligatoriosExcepcion() : base("Todos los datos son obligatorios.")
        {
        }
    }
}
