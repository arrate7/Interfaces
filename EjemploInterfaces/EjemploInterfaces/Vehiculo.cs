using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaces
{
    class Vehiculo
    {
        //Forma abreviada de declarar los atributos + los gets y los sets
        public string Marca { get ; set; }
        public string Modelo{ get; set; }
        public Double Velocidad{ get; set; }

        public Vehiculo(double velocidad, string marca, string modelo)
        {
            Velocidad = velocidad;
            Marca = marca;
            Modelo = modelo;
        }

        //Forma larga de declarar los gets y los sets y los atributos

        //private string marca;
        //private string modelo;
        //private double velocidad;

        //public void SetVelocidad(double velocidad)
        //{
        //    this.velocidad = velocidad;
        //}

        //public double GetVelocidad()
        //{
        //    return velocidad;
        //}

        //public string GetMarca()
        //{
        //    return marca;
        //}

        //public void SetMarca(string marca)
        //{
        //    this.marca = marca;
        //}

        //public string GetModelo()
        //{
        //    return modelo;
        //}

        //public void SetModelo(string modelo)
        //{
        //    this.modelo = modelo;
        //}
    }
}
