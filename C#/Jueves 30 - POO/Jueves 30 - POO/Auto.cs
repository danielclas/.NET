using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jueves_30___POO
{
    class Auto
    {
        
         protected double _velocidad = 0;
         private string _marca;
         private string _modelo;
         private string _color;

        public Auto(string marca, string modelo, string color)
        {
            //_marca = marca;
            this.Marca = marca;
            _modelo = modelo;
            _color = color;
        }

        //public string Marca { get; set; } //Autoimplementada

        public double Velocidad
        {
            get { return _velocidad; }
        }

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public void Acelerar(double cantidad)
        {
            if(cantidad<1 || cantidad > 120)
            {
                Console.WriteLine("La velocidad ingresada esta fuera de rango");            
            }
            else
            {
                Console.WriteLine("--> Incrementando veloc. en {0} km/h", cantidad);
                _velocidad += cantidad;
                
            }
            
        }

        // Método Girar
        public void Girar(double cantidad)
        {
            if (cantidad < 90)
            {
                Console.WriteLine("--> Girando {0} grados a la izquierda", cantidad);
            }
            else
            {
                Console.WriteLine("--> Girando {0} grados a la derecha", cantidad);
            }
            
        }

        // Método Frenar
        public void Frenar(double cantidad)
        {
            if (cantidad > Velocidad)
            {
                Console.WriteLine("No pudo realizarse el frenado, valor mayor a velocidad actual.");
            }else
            {
                Console.WriteLine("--> Reduciendo veloc. en {0} km/h", cantidad);
                _velocidad -= cantidad;
            }
            
            
        }

        // Método Estacionar
        public void Estacionar()
        {
            if (Velocidad != 0)
            {
                Console.WriteLine("-->Estacionando auto");
                _velocidad = 0;
            }else
            {
                Console.WriteLine("Velocidad es 0, no pudo estacionar el auto");
            }
            
        }
        


    }
}
