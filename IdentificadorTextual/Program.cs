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
            DateTime fechaHora = new DateTime(2023, 10, 31, 20, 55, 32);
            DateTime fecha = new DateTime(2023, 10, 31);
            Console.WriteLine(fechaHoraPredeterminados);
            Console.WriteLine(fechaHora);
            Console.WriteLine(fecha);

        }
    }
}
