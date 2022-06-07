using System;
namespace aporte
{
    class Program
    {
        public static void Main(string [] args)
        {
            Profesor Profesor = new Profesor();
            Hora.Datos("Eddie Javier"," Velasquez Vasquez ","Manta",131416654);
            Hora.ImprimirDatos();

            Profesor_por_Horas Hora = new Profesor_por_Horas();
            Hora.Datos("Ricardo Alberto"," Cardenas Mendoza ","Manta",1314748596);
            Hora.AAincorporacion = 2018;
            Hora.PrecioHora = 4.0 ;
            Hora.HorasTrabajadas = 200;
            Hora.ImprimirDatos();

            Profesor_con_Contrato Contrato = new Profesor_con_Contrato();
            contrato.Datos("Robert Moreira","Pincay Cuccitini","Portoviejo",1318546798);
            Contrato.PrecioHoras = 4.5;
            Contrato.HorasExtras = 25 ;
            Contrato.sueldoBase = 425 ;
            contrato.DatosExtra(3);
            contrato.ImprimirDatos();

            Profesor_con_Nombramiento Nombramiento = new EstudianteUniversitario();
            Nombramiento.Datos("Maximiliano Andres","Cedeño Macias","Guayaquil",1316461547);
            Nombramiento.sueldoFijo = 1000 ;
            Nombramiento.AAincorporacion = 2002
            Nombramiento.DatosEx(5);
            Nombramiento.ImprimirDatos();
        }
    }
}