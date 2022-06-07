using System;
using System.Collections.Generic;
using System.Text;

namespace Aporte
{
    class IProfesor_por_Horas: Profesor
    {
        public int HorasTrabajadas { get; set; }
        public double PrecioHora { get; set; }
        public double sueldoTotal;

        public override void infoDetallado()
        {
            Console.WriteLine("Año de incorporacion: " + AAincorporacion);
            sueldoTotal = HorasTrabajadas * PrecioHora;
            Console.WriteLine("Sueldo: $ " + sueldoTotal");
        }

    }
}