using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonvinoApp.CapaNegocio
{
    public class TipoUva
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        // Constructor
        public TipoUva(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }


}