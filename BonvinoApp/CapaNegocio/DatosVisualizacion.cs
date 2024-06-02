using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace BonvinoApp.CapaNegocio
{
    class DatosVisualizacion
    {
        private Vino vino;
        private string nombre;
        private float  calificacionSommelier;
        private float  precioSugerido;
        private string bodega;
        private string variertal;
        private string region;
        private string pais;


        public string Nombre { get => nombre; set => nombre = value; }
        public float CalificacionSommelier { get => calificacionSommelier; set => calificacionSommelier = value; }
        public float PrecioSugerido { get => precioSugerido; set => precioSugerido = value; }
        public string Bodega { get => bodega; set => bodega = value; }
        public string Variertal { get => variertal; set => variertal = value; }
        public string Region { get => region; set => region = value; }
        public string Pais { get => pais; set => pais = value; }
        internal Vino Vino { get => vino; set => vino = value; }

        public DatosVisualizacion(Vino vino, float calificacionSommelier)
        {
            Vino = vino;
            CalificacionSommelier = calificacionSommelier;
        }
    }
}
