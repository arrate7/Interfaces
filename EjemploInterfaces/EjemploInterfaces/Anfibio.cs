using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaces
{
     class Anfibio : Vehiculo, IVehiculoAcuatico, IVehiculoTerrestre
    {
        double eslora;

        public Anfibio(double velocidad, string marca, string modelo, double eslora): base(velocidad, marca, modelo)
        {
            this.eslora = eslora;
        }

        public double Acelerar(double vel)
        {
            return GetVelocidad() + vel;
        }

        public void Arrancar()
        {
            Console.WriteLine("El Vehiculo Anfibio ha arrancado.");
        }

        public void Frenar()
        {
            Console.WriteLine("El Vehiculo Anfibio ha frenado.");
        }
        public void HecharAncla()
        {
            Console.WriteLine("El vehiculo anfibio ha hechado el ancla.");
        }

    }
}
