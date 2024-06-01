using BonvinoApp.CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonvinoApp.CapaDatos
{
    class generalDAC
    {

        public static Bodega bodega1 = new Bodega("34.052235, -118.243683", "Almacén central en Los Ángeles", "Fundada en 1920, sirvió como el principal almacén de la ciudad.", "Central LA", 5000);
        public static Bodega bodega2 = new Bodega("40.712776, -74.005974", "Bodega en Nueva York", "Establecida en 1898, es uno de los almacenes más antiguos de la ciudad.", "NY Warehouse", 10000);
        public static Bodega bodega3 = new Bodega("37.774929, -122.419418", "Almacén en San Francisco", "Inaugurada en 1950, ha sido clave en la distribución de productos en la bahía.", "SF Storage", 7500);
        public static Bodega bodega4 = new Bodega("51.507351, -0.127758", "Depósito en Londres", "Utilizada durante la Segunda Guerra Mundial, ahora maneja productos locales.", "London Depot", 6000);
        public static Bodega bodega5 = new Bodega("-33.868820, 151.209290", "Bodega en Sídney", "Construida en 1985, es la principal bodega en la región de Nueva Gales del Sur.", "Sydney Storage", 8000);
        public static Bodega bodega6 = new Bodega("48.856613, 2.352222", "Almacén en París", "Desde 1930, ha sido un punto central en la distribución europea.", "Paris Warehouse", 7000);
        public static Bodega bodega7 = new Bodega("35.689487, 139.691711", "Bodega en Tokio", "Inaugurada en 1960, maneja productos electrónicos y de alta tecnología.", "Tokyo Hub", 9000);
        public static Bodega bodega8 = new Bodega("55.755825, 37.617298", "Depósito en Moscú", "Un almacén histórico que data de la era soviética.", "Moscow Storage", 6500);
        public static Bodega bodega9 = new Bodega("52.520008, 13.404954", "Almacén en Berlín", "Reconstruido después de la guerra, es un símbolo de resiliencia.", "Berlin Depot", 8500);
        public static Bodega bodega10 = new Bodega("-23.550520, -46.633308", "Bodega en São Paulo", "Establecida en 1990, es la más grande en América del Sur.", "São Paulo Warehouse", 9500);

        public static TipoUva tipoUva1 = new TipoUva("Cabernet Sauvignon", "Uva tinta de origen francés, muy popular en la producción de vinos tintos");
        public static TipoUva tipoUva2 = new TipoUva("Chardonnay", "Uva blanca originaria de la región de Borgoña, utilizada en la producción de vinos blancos");
        public static TipoUva tipoUva3 = new TipoUva("Merlot", "Uva tinta con sabor a frutas y menos taninos que el Cabernet Sauvignon");
        public static TipoUva tipoUva4 = new TipoUva("Pinot Noir", "Uva tinta conocida por su dificultad de cultivo pero produce vinos de alta calidad");
        public static TipoUva tipoUva5 = new TipoUva("Sauvignon Blanc", "Uva blanca con sabores herbáceos y cítricos, usada para hacer vinos blancos frescos");
        public static TipoUva tipoUva6 = new TipoUva("Syrah", "Uva tinta que produce vinos intensos y de cuerpo completo con sabores especiados");
        public static TipoUva tipoUva7 = new TipoUva("Malbec", "Uva tinta originaria de Francia, pero muy popular en Argentina");
        public static TipoUva tipoUva8 = new TipoUva("Riesling", "Uva blanca con alto contenido de acidez, utilizada en la producción de vinos secos y dulces");
        public static TipoUva tipoUva9 = new TipoUva("Tempranillo", "Uva tinta originaria de España, utilizada en la producción de vinos tintos de cuerpo medio");
        public static TipoUva tipoUva10 = new TipoUva("Sémillon", "Uva blanca utilizada en la producción de vinos blancos secos y dulces, especialmente en Burdeos");


        public static RegionVitivinicola regionVitivinicola1 = new RegionVitivinicola("NombreRegion2", "Descripción de la región 2");
        public static RegionVitivinicola regionVitivinicola2 = new RegionVitivinicola("NombreRegion1", "Descripción de la región 1");
        public static RegionVitivinicola regionVitivinicola3 = new RegionVitivinicola("NombreRegion3", "Descripción de la región 3");
        public static RegionVitivinicola regionVitivinicola4 = new RegionVitivinicola("NombreRegion4", "Descripción de la región 4");
        public static RegionVitivinicola regionVitivinicola5 = new RegionVitivinicola("NombreRegion5", "Descripción de la región 5");
        public static RegionVitivinicola regionVitivinicola6 = new RegionVitivinicola("NombreRegion6", "Descripción de la región 6");
        public static RegionVitivinicola regionVitivinicola7 = new RegionVitivinicola("NombreRegion7", "Descripción de la región 7");
        public static RegionVitivinicola regionVitivinicola8 = new RegionVitivinicola("NombreRegion8", "Descripción de la región 8");
        public static RegionVitivinicola regionVitivinicola9 = new RegionVitivinicola("NombreRegion9", "Descripción de la región 9");
        public static RegionVitivinicola regionVitivinicola10 = new RegionVitivinicola("NombreRegion10", "Descripción de la región 10");

        public static Provincia provincia = new Provincia("Cordoba", new List<RegionVitivinicola> { regionVitivinicola1, regionVitivinicola2 });
        public static Provincia provincia1 = new Provincia("BsAs", new List<RegionVitivinicola> { regionVitivinicola3, regionVitivinicola4 });
        public static Provincia provincia2 = new Provincia("Corrientes", new List<RegionVitivinicola> { regionVitivinicola5, regionVitivinicola6 });

        public static Pais pais = new Pais("Argentina", new List<Provincia> { provincia, provincia1, provincia2 });

        public Pais returnPais()
        {
            return pais;
        }

        public List<Provincia> returnProvincia()
        {
            return new List<Provincia> { provincia, provincia1, provincia2 };
        }

        public List<RegionVitivinicola> returnRegionVitivinicola()
        {
            return new List<RegionVitivinicola> { regionVitivinicola1, regionVitivinicola2, regionVitivinicola3, regionVitivinicola4, regionVitivinicola5, regionVitivinicola6, regionVitivinicola7, regionVitivinicola8, regionVitivinicola9 };
        }




        public List<Vino> returnVinos()
        {
            List<Vino> listaVinos = new List<Vino>();

            listaVinos.Add(new Vino("ImagenEtiqueta1", "VinoMiSuegra", "1.0", 1.5f, crearListaVarietales(), crearListaReseña(), bodega1));
            listaVinos.Add(new Vino("ImagenEtiqueta2", "VinoMiSuegra2", "2.0", 2.5f, crearListaVarietales(), crearListaReseña(), bodega2));
            listaVinos.Add(new Vino("ImagenEtiqueta3", "VinoMiSuegra3", "3.0", 3.5f, crearListaVarietales(), crearListaReseña(), bodega3));
            listaVinos.Add(new Vino("ImagenEtiqueta4", "VinoMiSuegra4", "4.0", 4.5f, crearListaVarietales(), crearListaReseña(), bodega4));
            listaVinos.Add(new Vino("ImagenEtiqueta5", "VinoMiSuegra5", "5.0", 5.5f, crearListaVarietales(), crearListaReseña(), bodega5));
            listaVinos.Add(new Vino("ImagenEtiqueta6", "VinoMiSuegra6", "6.0", 6.5f, crearListaVarietales(), crearListaReseña(), bodega6));
            listaVinos.Add(new Vino("ImagenEtiqueta7", "VinoMiSuegra7", "7.0", 7.5f, crearListaVarietales(), crearListaReseña(), bodega7));
            listaVinos.Add(new Vino("ImagenEtiqueta8", "VinoMiSuegra8", "8.0", 8.5f, crearListaVarietales(), crearListaReseña(), bodega8));
            listaVinos.Add(new Vino("ImagenEtiqueta9", "VinoMiSuegra9", "9.0", 9.5f, crearListaVarietales(), crearListaReseña(), bodega9));

            return listaVinos;
        }

        private List<Varietal> crearListaVarietales()
        {
            List<Varietal> listaVarietales = new List<Varietal>();

            // Agregar los varietales a la lista
            listaVarietales.Add(new Varietal("Cabernet Sauvignon", 40.5f, tipoUva1));
            listaVarietales.Add(new Varietal("Merlot", 30.0f, tipoUva2));
            listaVarietales.Add(new Varietal("Pinot Noir", 10.0f, tipoUva3));
            listaVarietales.Add(new Varietal("Syrah", 5.5f, tipoUva4));
            listaVarietales.Add(new Varietal("Zinfandel", 3.0f, tipoUva5));
            listaVarietales.Add(new Varietal("Malbec", 2.5f, tipoUva6));
            listaVarietales.Add(new Varietal("Sauvignon Blanc", 4.0f, tipoUva7));
            listaVarietales.Add(new Varietal("Chardonnay", 2.5f, tipoUva8));
            listaVarietales.Add(new Varietal("Riesling", 1.0f, tipoUva9));
            listaVarietales.Add(new Varietal("Grenache", 1.0f, tipoUva10));
            return listaVarietales;
        }

        private List<Reseña> crearListaReseña()
        {
            List<Reseña> listaReseñas = new List<Reseña>();
            listaReseñas.Add(new Reseña("Excelente producto", true, DateTime.Now.AddDays(-10), 4.5f));
            listaReseñas.Add(new Reseña("Buena relación calidad-precio", false, DateTime.Now.AddDays(-5), 4.0f));
            listaReseñas.Add(new Reseña("Envío rápido, producto como se describe", true, DateTime.Now.AddDays(-7), 5.0f));
            listaReseñas.Add(new Reseña("No recibí el producto aún", false, DateTime.Now.AddDays(-15), 2.0f));
            listaReseñas.Add(new Reseña("Producto defectuoso, pero excelente servicio al cliente", true, DateTime.Now.AddDays(-3), 3.5f));
            listaReseñas.Add(new Reseña("No lo recomiendo, mala calidad", false, DateTime.Now.AddDays(-8), 1.0f));
            listaReseñas.Add(new Reseña("El producto llegó tarde", true, DateTime.Now.AddDays(-12), 3.0f));
            listaReseñas.Add(new Reseña("Buen producto, pero un poco caro", false, DateTime.Now.AddDays(-2), 4.0f));
            listaReseñas.Add(new Reseña("Muy satisfecho con mi compra", true, DateTime.Now.AddDays(-6), 4.7f));
            listaReseñas.Add(new Reseña("Producto excelente, lo recomiendo", false, DateTime.Now.AddDays(-4), 5.0f));
            return listaReseñas;
        }
    }
}
