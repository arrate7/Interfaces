using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaces
{
    class Vehiculo
    {
        private double velocidad;
        private string marca;
        private string modelo;

        public Vehiculo(double velocidad, string marca, string modelo)
        {
            this.velocidad = velocidad;
            this.marca = marca;
            this.modelo = modelo;
        }

        public void SetVelocidad(double velocidad)
        {
            this.velocidad = velocidad;
        }

        public double GetVelocidad()
        {
            return velocidad;
        }

        public string GetMarca()
        {
            return marca;
        }

        public void SetMarca(string marca)
        {
            this.marca = marca;
        }

        public string GetModelo()
        {
            return modelo;
        }

        public void SetModelo(string modelo)
        {
            this.modelo = modelo;
        }
    }
}
