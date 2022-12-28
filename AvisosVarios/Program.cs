using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvisosVarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico av1 = new AvisosTrafico();
            AvisosTrafico av2 = new AvisosTrafico("Jefatura Provincial de Marcala", "Sanción de velocidad: 300$", "26-12-22");

            av1.MostrarAviso();
            Console.WriteLine(av2.GetFecha());
            av2.MostrarAviso();
        }
    }
}
