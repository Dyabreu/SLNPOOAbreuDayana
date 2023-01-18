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

        public virtual string Acelera() 
            {
            return Nombre + " acelera...";
            }
        public virtual string Frena()
            {
            return Nombre + " frenó.";
            }
        public virtual string Imprimir()
        {
            return "Camión.\nNombre: " + Nombre + ".\nModelo: " + Modelo + ".\nPlaca: " + Placa;

        }
    }
}
