using System;
using System.Collections.Generic;
using System.Text;

namespace Aporte
{
    class IProfesor_con_Contrato: Profesor
    {
        public int HorasExtras { get; set; }
        public double PrecioHoras { get; set; }
        public double sueldoBase { get; set; }
        public double sueldoTotal;


        public override void infoDetallado()
        {
            Console.WriteLine("Año de incorporacion: " + AAincorporacion);
            sueldoTotal = sueldoBase + (PrecioHoras * HorasExtras);
            Console.WriteLine("Sueldo: $ " + sueldoTotal );
        }
    }
}