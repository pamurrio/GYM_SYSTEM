﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GymSystemBusiness
{
    public class EmailExisteExcepcionBO : ExcepcionBO
    {
        public EmailExisteExcepcionBO() : base("El email ingresado ya se encuentra registrado.")
        {
        }
    }
}
