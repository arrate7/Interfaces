using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaces
{
    interface IVehiculoAcuatico
    {
        double Acelerar(double vel);
        void Arrancar();
        void HecharAncla();
    }
}
