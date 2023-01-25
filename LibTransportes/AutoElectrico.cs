using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibTransportes.BASE;

namespace LibTransportes
{
    public class AutoElectrico:Vehiculo
    {
        public AutoElectrico() { }
        public AutoElectrico(string Nombre, string Modelo, string Placa, string Dueño, int CantPasajeros):base(Nombre, Modelo, Placa)
        {
            this.Dueño = Dueño;
            this.CantPasajeros = CantPasajeros;
        }

        public string Dueño { get; set; }
        public int CantPasajeros { get; set;}

        public override string Acelera()
        {
            return "Auto eléctrico acelerado.";
        }
        public override string Frena()
        {
            return "Auto eléctrico detenido.";
        }
        public override string Imprimir()
        {
            return base.Imprimir() + ".\nDueño: " + Dueño + ".\nCantidad de Pasajeros: " + CantPasajeros.ToString() + ".\n" + Acelera() + "\n" + Frena();
        }

    }
}
