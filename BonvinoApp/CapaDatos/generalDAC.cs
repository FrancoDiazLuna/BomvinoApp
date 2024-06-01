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
        public static TipoUva tipoUva2= new TipoUva("Chardonnay", "Uva blanca originaria de la región de Borgoña, utilizada en la producción de vinos blancos");
        public static TipoUva tipoUva3 = new TipoUva("Merlot", "Uva tinta con sabor a frutas y menos taninos que el Cabernet Sauvignon");
        public static TipoUva tipoUva4 = new TipoUva("Pinot Noir", "Uva tinta conocida por su dificultad de cultivo pero produce vinos de alta calidad");
        public static TipoUva tipoUva5 = new TipoUva("Sauvignon Blanc", "Uva blanca con sabores herbáceos y cítricos, usada para hacer vinos blancos frescos");
        public static TipoUva tipoUva6 = new TipoUva("Syrah", "Uva tinta que produce vinos intensos y de cuerpo completo con sabores especiados");
        public static TipoUva tipoUva7 = new TipoUva("Malbec", "Uva tinta originaria de Francia, pero muy popular en Argentina");
        public static TipoUva tipoUva8 = new TipoUva("Riesling", "Uva blanca con alto contenido de acidez, utilizada en la producción de vinos secos y dulces");
        public static TipoUva tipoUva9 = new TipoUva("Tempranillo", "Uva tinta originaria de España, utilizada en la producción de vinos tintos de cuerpo medio");
        public static TipoUva tipoUva10 = new TipoUva("Sémillon", "Uva blanca utilizada en la producción de vinos blancos secos y dulces, especialmente en Burdeos");



        public static Varietal varietal1 = new Varietal("Cabernet Sauvignon", 40.5f, tipoUva1);
        public static Varietal varietal2 = new Varietal("Merlot", 30.0f, tipoUva2);
        public static Varietal varietal3 = new Varietal("Pinot Noir", 10.0f, tipoUva3);
        public static Varietal varietal4 = new Varietal("Syrah", 5.5f,tipoUva4);
        public static Varietal varietal5 = new Varietal("Zinfandel", 3.0f,tipoUva5);
        public static Varietal varietal6 = new Varietal("Malbec", 2.5f,tipoUva6);
        public static Varietal varietal7 = new Varietal("Sauvignon Blanc", 4.0f,tipoUva7);
        public static Varietal varietal8 = new Varietal("Chardonnay", 2.5f,tipoUva8);
        public static Varietal varietal9 = new Varietal("Riesling", 1.0f,tipoUva9);
        public static Varietal varietal10 = new Varietal("Grenache", 1.0f, tipoUva10);


        public static Pais pais1 = new Pais("Argentina");
        public static Pais pais2 = new Pais("Brasil");
        public static Pais pais3 = new Pais("Chile");
        public static Pais pais4 = new Pais("Uruguay");
        public static Pais pais5 = new Pais("Paraguay");
        public static Pais pais6 = new Pais("Bolivia");
        public static Pais pais7 = new Pais("Perú");
        public static Pais pais8 = new Pais("Colombia");
        public static Pais pais9 = new Pais("Venezuela");
        public static Pais pais10 = new Pais("Ecuador");






    }
}
