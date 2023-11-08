using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Factory_Method
{
    public class Creador
    {
        public const int POWERADE = 1;
        public const int GATORADE = 2;
        
        public static BebidaEnergizante ? CreadorBebida(int Tipo)
        {
            switch (Tipo)
            {
                case POWERADE:
                    return new Gatorade();
                case GATORADE:
                    return new Powerade();
                default:return null;
            }
        }

    }
}
