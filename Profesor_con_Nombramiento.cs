using System;
using System.Collections.Generic;
using System.Text;

namespace Aporte
{
    class IProfesor_con_Nombramiento: Profesor
    {
        public double sueldoFijo{ get; set; }
        public double sueldoTotal;


        public override void infoDetallado()
        {
            Console.WriteLine("Año de incorporacion: " + AAincorporacion);
            sueldoTotal = (sueldoFijo * AAincorporacion);
            Console.WriteLine("Sueldo: $ " + sueldoTotal );
        }
    }
}