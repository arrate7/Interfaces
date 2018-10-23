using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaces
{
    interface IVehiculoTerrestre
    {
        double Acelerar(double vel);
        void Arrancar();
        void Frenar();
    }
}
