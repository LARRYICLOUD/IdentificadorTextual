using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentificadorTextual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YO SOY UN PROGRAMADOR Y EXPERTO EN REDES EXCELENTE Y RECONOCIDO");
            //Declarando un objeto DateTime
            DateTime fechaHoraPredeterminados = new DateTime();
            DateTime fechaHora = new DateTime(2023, 11, 1, 20, 55, 32);
            DateTime fecha = new DateTime(2023, 10, 31);
            Console.WriteLine(fechaHoraPredeterminados);
            Console.WriteLine($"El valor del objeto DateTime es: { fechaHora}");
            Console.WriteLine(fecha);


            //Convirtiendo el objeto DateTime en una cadena
            //Especificadores que requieren modificacion ("d", "f", "F", "g", "h", "H","k", "m", "M", "s", "t", "y", "z", ":", o "/" )
            // colocando espacio antes o despues y el signo de porcentaje nos muestra el dia del 1 al 31 segun tengamos en la fecha designada

            //"ddd" nos muestra un dia abreviado

            //string cadenaFechaHora = fechaHora.ToString("%d");
            //string cadenaFechaHora = fechaHora.ToString("ddd");
            //string cadenaFechaHora = fechaHora.ToString("d ");
            //string cadenaFechaHora = fechaHora.ToString(" d");
            string cadenaFechaHora = fechaHora.ToString("dddd dd MMMM yyyy h:m:s tt");

            //Convirtiendo la representacion encadena del objeto DateTime segun la referencia cultural actual (es-MX)
            Console.WriteLine($"La presentacion en cadena es: {cadenaFechaHora}");




        }
    }
}
