using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Factory_Method
{
    public class Gatorade : BebidaEnergizante
    {
        public override int CuantoMeEnergizaPorHora()
        {
            return 90;
        }
    }
}