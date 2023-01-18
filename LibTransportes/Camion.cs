using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibTransportes.BASE;

namespace LibTransportes
{
    public class Camion:Vehiculo
    {
        public Camion() { }
        public Camion (string Nombre, string Modelo, string Placa, string Empresa, string Mercancia, Remolque Remolque): base(Nombre, Modelo, Placa) 
        { this.Empresa = Empresa;
            this.Mercancia = Mercancia;
            this.Remolque = Remolque;
        }

        public string Empresa { get; set; }
        public string Mercancia { get; set;}
        public Remolque Remolque { get; set; }
        public string QuitarRemolque() 
            { 
                this.Remolque = null;
            return "Remolque retirado";

            }
        public override string Acelera()
        {
            return base.Acelera() + "Camión acelerado.";
        }
        public override string Frena()
        {
            return base.Frena() + " Camión detenido.";
        }

        public override string Imprimir()
        {
            return base.Imprimir() + ".\nEmpresa: " + Empresa + ".\nMercancía: " + Mercancia + ".\n" + Acelera() + "\n" + Frena();
        }

    }
}
