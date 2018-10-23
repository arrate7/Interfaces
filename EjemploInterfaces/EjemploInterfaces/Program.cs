using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Terrestre t1 = new Terrestre(180, "Porsche", "Carrera", 250);
            Anfibio a1 = new Anfibio(100, "AquaBus", "747", 120);

            Console.WriteLine("Velocidad tras acelerar: " + t1.Acelerar(20));
            t1.Frenar();

            a1.Arrancar();
            a1.HecharAncla();
            Console.ReadLine();

        }
    }
}
