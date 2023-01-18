using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public class Remolque
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public virtual string Imprimir()
        {
            return "Remolque " + Id + " es de tipo " + Tipo;
        }
    }
}
