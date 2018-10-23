using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaces
{
    class Terrestre : Vehiculo,  IVehiculoTerrestre
    {
        int caballos;

        public Terrestre(double velocidad, string marca, string modelo, int caballos) : base(velocidad, marca, modelo)
        {
            this.caballos = caballos;
        }

        public double Acelerar(double vel)
        {
            return GetVelocidad() + vel;
        }

        public void Arrancar()
        {
            Console.WriteLine("El Vehiculo Terrestre ha arrancado.");
        }

        public void Frenar()
        {
            Console.WriteLine("El Vehiculo Terrestre ha frenado.");
        }

    }
    }
