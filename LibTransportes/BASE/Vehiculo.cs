using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.BASE
{
    public abstract class Vehiculo
    {
        public Vehiculo () { }
        public Vehiculo(string Nombre, string Modelo, string Placa) 
        {
            this.Nombre = Nombre;
            this.Modelo = Modelo;
            this.Placa = Placa;
        }
        
        public string Nombre { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }

        public abstract string Acelera();

        public abstract string Frena();
       
        public virtual string Imprimir()
        {
            return "Camión.\nNombre: " + Nombre + ".\nModelo: " + Modelo + ".\nPlaca: " + Placa;

        }
    }
}
