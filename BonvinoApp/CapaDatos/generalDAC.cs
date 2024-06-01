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

        public static Pais pais1 = new Pais("Argentina");

        public static Provincia provincia1 = new Provincia("Mendoza");
        public static Provincia provincia2 = new Provincia("Salta");
        public static Provincia provincia3 = new Provincia("San Juan");
        public static Provincia provincia4 = new Provincia("La Rioja");

        public static RegionVitivinicola regionVitivinicola1 = new RegionVitivinicola("Región de La Rioja", "Gracias a esa amplitud térmica los vinos que se elaboran con las vides que allí se cultivan tienen características muy definidas. Son frutados e intensos, los tintos presentan un gran color y los taninos son realmente dulces.");
        public static RegionVitivinicola regionVitivinicola2 = new RegionVitivinicola("Región Centro-Oste", "Las variedades rosadas y blancas predominan de forma notoria sobre las tintas. La variedad predominante es la cereza, uva rosada que se utiliza en diferentes industrias. Otras variedades importantes son la moscatel de Alejandría, la Pedro Giménez y el torrontés riojano entre las blancas. Las variedades tintas ocupan una superficie menor. Las principales variedades tintas son la cabernet sauvignon, la syrah y la merlot.");
        public static RegionVitivinicola regionVitivinicola3 = new RegionVitivinicola("Región de Mendoza", "Mendoza es el centro vitivinícola más importante del país. Llamada “Tierra del buen sol y del buen vino”, es el centro vitivinícola más importante del Argentina.");
        public static RegionVitivinicola regionVitivinicola4 = new RegionVitivinicola("Región del Sur Argentino", "Comprende áreas delimitadas de la provincia de La Pampa, Neuquen y Río Negro, donde la viticultura se asienta en las márgenes de los ríos Negro y Colorado.");


        public static Bodega bodega1 = new Bodega(
            "-32.89084,-68.84594", 
            "Bodega tradicional especializada en Malbec.", 
            "Fundada en 1884, es una de las bodegas más antiguas de Mendoza.", 
            "Bodega Trapiche", 
            5000,
            regionVitivinicola3
        );

        public static Bodega bodega2 = new Bodega(
            "-33.01005,-68.84058",
            "Bodega innovadora con tecnología de punta.",
            "Desde su fundación en 1999, ha sido pionera en la modernización de la viticultura.",
            "Bodega Catena Zapata",
            10000,
            regionVitivinicola3
        );

        public static Bodega bodega3 = new Bodega(
            "-31.53750,-68.52515",
            "Bodega familiar con viñedos de alta altitud.",
            "Con más de 100 años de historia, produce vinos excepcionales en el Valle de Uco.",
            "Bodega Zuccardi",
            7500,
            regionVitivinicola4
        );

        public static Bodega bodega4 = new Bodega(
            "-32.92025,-68.82843",
            "Bodega reconocida por sus vinos orgánicos.",
            "Establecida en 1985, se dedica a la producción sustentable y orgánica.",
            "Bodega Domaine Bousquet",
            5000,
            regionVitivinicola1
        );

        public static Bodega bodega5 = new Bodega(
            "-33.03267,-68.84719",
            "Bodega boutique enfocada en vinos de terroir.",
            "Fundada en 1998, es conocida por su atención al detalle y pequeños lotes.",
            "Bodega Achaval Ferrer",
            8500,
            regionVitivinicola2
        );

        public static Bodega bodega6 = new Bodega(
            "-33.02801,-68.88149",
            "Bodega con enfoque en la viticultura biodinámica.",
            "Desde su creación en 2001, ha sido líder en prácticas biodinámicas en Argentina.",
            "Bodega Chakana",
            6500,
            regionVitivinicola4
        );

        public static Bodega bodega7 = new Bodega(
            "-33.00562,-68.80553",
            "Bodega con una gran tradición en Cabernet Sauvignon.",
            "Fundada en 1932, es una de las bodegas más prestigiosas de la región.",
            "Bodega Norton",
            9000,
            regionVitivinicola3
        );

        public static Bodega bodega8 = new Bodega(
            "-33.03856,-68.88014",
            "Bodega con una amplia gama de varietales.",
            "Establecida en 1976, es famosa por su diversidad y calidad consistente.",
            "Bodega Luigi Bosca",
            5500,
            regionVitivinicola1
        );

        public static Bodega bodega9 = new Bodega(
            "-32.94689,-68.80492",
            "Bodega que combina tradición y modernidad.",
            "Fundada en 1902, ha sabido adaptarse a los tiempos sin perder su esencia.",
            "Bodega La Rural",
            7000,
            regionVitivinicola2
        );

        public static Bodega bodega10 = new Bodega(
            "-33.04042,-68.85382",
            "Bodega destacada por sus vinos espumosos.",
            "Con más de 50 años de experiencia, es líder en la producción de espumantes de alta calidad.",
            "Bodega Navarro Correas",
            8000,
            regionVitivinicola3
        );

        public static TipoUva tipoUva1 = new TipoUva("Malbec", "Es la uva insignia de Argentina. Produce vinos de color oscuro, con aromas de frutas negras como ciruelas y moras, notas de violeta y un toque especiado.");
        public static TipoUva tipoUva2 = new TipoUva("Torrontés", "Es la uva blanca más representativa del país. Produce vinos aromáticos con intensos aromas florales y frutales (rosas, duraznos, cítricos).");
        public static TipoUva tipoUva3 = new TipoUva("Chardonnay", "Produce vinos blancos de gran calidad, con una amplia gama de estilos, desde frescos y frutales hasta ricos y mantecosos.");
        public static TipoUva tipoUva4 = new TipoUva("Bonarda", "Produce vinos con buen color y cuerpo, aromas de frutas negras, y taninos suaves. Es una variedad versátil.");
        public static TipoUva tipoUva5 = new TipoUva("Cabernet Sauvignon", "Produce vinos robustos, con aromas de cassis, pimiento verde, y notas de roble cuando son envejecidos.");
        public static TipoUva tipoUva6 = new TipoUva("Syrah", "Produce vinos con aromas de frutas negras, especias y notas ahumadas. En boca, los vinos pueden ser robustos y estructurados.");
        public static TipoUva tipoUva7 = new TipoUva("Merlot", "Produce vinos suaves, con aromas de frutas rojas, hierbas y a veces toques de chocolate. Los taninos suelen ser más suaves.");
        public static TipoUva tipoUva8 = new TipoUva("Pinot Noir", "Produce vinos elegantes, con aromas de frutas rojas (cereza, frambuesa), flores y especias. Su cuerpo suele ser ligero a medio.");
        public static TipoUva tipoUva9 = new TipoUva("Tempranillo", "Produce vinos con aromas de frutas rojas y negras, cuero y tabaco. Los taninos son generalmente moderados.");
        public static TipoUva tipoUva10 = new TipoUva("Viognier", "Produce vinos blancos con aromas intensos de frutas de hueso como el durazno y el albaricoque, y notas florales.");

        public List<Vino> returnVinos()
        {
            List<Vino> listaVinos = new List<Vino>();

            listaVinos.Add(new Vino(1996, "ImagenEtiqueta1", "VinoMiSuegra", "1.0", 1.5f, crearListaVarietales(), crearListaReseña(), bodega1));
            listaVinos.Add(new Vino(2023, "ImagenEtiqueta2", "VinoMiSuegra2", "2.0", 2.5f, crearListaVarietales(), crearListaReseña(), bodega2));
            listaVinos.Add(new Vino(2002, "ImagenEtiqueta3", "VinoMiSuegra3", "3.0", 3.5f, crearListaVarietales(), crearListaReseña(), bodega3));
            listaVinos.Add(new Vino(2022, "ImagenEtiqueta4", "VinoMiSuegra4", "4.0", 4.5f, crearListaVarietales(), crearListaReseña(), bodega4));
            listaVinos.Add(new Vino(2006, "ImagenEtiqueta5", "VinoMiSuegra5", "5.0", 5.5f, crearListaVarietales(), crearListaReseña(), bodega5));
            listaVinos.Add(new Vino(2018, "ImagenEtiqueta6", "VinoMiSuegra6", "6.0", 6.5f, crearListaVarietales(), crearListaReseña(), bodega6));
            listaVinos.Add(new Vino(2014, "ImagenEtiqueta7", "VinoMiSuegra7", "7.0", 7.5f, crearListaVarietales(), crearListaReseña(), bodega7));
            listaVinos.Add(new Vino(2023, "ImagenEtiqueta8", "VinoMiSuegra8", "8.0", 8.5f, crearListaVarietales(), crearListaReseña(), bodega8));
            listaVinos.Add(new Vino(2015, "ImagenEtiqueta9", "VinoMiSuegra9", "9.0", 9.5f, crearListaVarietales(), crearListaReseña(), bodega9));

            return listaVinos;
        }

        private List<Varietal> crearListaVarietales()
        {
            List<Varietal> listaVarietales = new List<Varietal>();

            // Agregar los varietales a la lista
            listaVarietales.Add(new Varietal("Vino Malbec de alta calidad", 100.0f, tipoUva1));
            listaVarietales.Add(new Varietal("Vino blanco Torrontés aromático", 100.0f, tipoUva2));
            listaVarietales.Add(new Varietal("Blend con mayor proporción de Cabernet Sauvignon", 60.0f, tipoUva3));
            listaVarietales.Add(new Varietal("Blend con mayor proporción de Merlot", 40.0f, tipoUva4));
            listaVarietales.Add(new Varietal("Vino Syrah especiado y robusto", 100.0f, tipoUva5));
            listaVarietales.Add(new Varietal("Vino Chardonnay fresco y afrutado", 100.0f, tipoUva6));
            listaVarietales.Add(new Varietal("Vino Pinot Noir elegante y delicado", 100.0f, tipoUva7));
            listaVarietales.Add(new Varietal("Blend con mayor proporción de Bonarda", 50.0f, tipoUva8));
            listaVarietales.Add(new Varietal("Vino Tempranillo con notas de frutas rojas", 100.0f, tipoUva9));
            listaVarietales.Add(new Varietal("Blend con mayor proporción de Syrah", 70.0f, tipoUva10));
           
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


        /*

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
        */
    }
}
