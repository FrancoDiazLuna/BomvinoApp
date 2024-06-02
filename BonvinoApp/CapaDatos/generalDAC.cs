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
        public static Pais pais = new Pais("Argentina");

        public static Provincia provincia1 = new Provincia("Mendoza", pais);
        public static Provincia provincia2 = new Provincia("San Juan", pais);
        public static Provincia provincia3 = new Provincia("La Rioja", pais);
        public static Provincia provincia4 = new Provincia("Salta", pais);
        public static Provincia provincia5 = new Provincia("Neuquén", pais);
        public static Provincia provincia6 = new Provincia("Rio Negro", pais);
        public static Provincia provincia7 = new Provincia("Catamarca", pais);
        public static Provincia provincia8 = new Provincia("Tucumán", pais);
        public static Provincia provincia9 = new Provincia("Córdoba", pais);
        public static Provincia provincia10 = new Provincia("Jujuy", pais);


        public static RegionVitivinicola region1 = new RegionVitivinicola("Mendoza", provincia1 , "Región vitivinícola más importante de Argentina.");
        public static RegionVitivinicola region2 = new RegionVitivinicola("San Juan", provincia2, "Segunda región vitivinícola más importante.");
        public static RegionVitivinicola region3 = new RegionVitivinicola("La Rioja", provincia3, "Región con gran tradición vitivinícola.");
        public static RegionVitivinicola region4 = new RegionVitivinicola("Salta", provincia4, "Conocida por sus viñedos de altura.");
        public static RegionVitivinicola region5 = new RegionVitivinicola("Neuquén", provincia5, "Emergente en la producción de vinos de calidad.");
        
        public static RegionVitivinicola region6 = new RegionVitivinicola("Río Negro", provincia6, "Importante en la Patagonia.");
        public static RegionVitivinicola region7 = new RegionVitivinicola("Catamarca", provincia7, "Conocida por su producción de vinos artesanales.");
        public static RegionVitivinicola region8 = new RegionVitivinicola("Tucumán", provincia8, "Pequeña pero de gran calidad.");
        public static RegionVitivinicola region9 = new RegionVitivinicola("Córdoba", provincia9, "Creciente en la producción de vinos.");
        public static RegionVitivinicola region10 = new RegionVitivinicola("Jujuy", provincia10, "Región emergente en la vitivinicultura.");

        public static Bodega bodega1 = new Bodega("-32.889, -68.845", "Bodega centenaria", "Fundada en 1900", "Bodega Norton", 12, region1);
        public static Bodega bodega2 = new Bodega("-32.831, -68.929", "Bodega familiar", "Tradición desde 1925", "Bodega Catena Zapata", 6, region8);
        public static Bodega bodega3 = new Bodega("-31.533, -68.522", "Innovadora en vinos tintos", "Establecida en 1980", "Bodega Graffigna", 3, region2);
        public static Bodega bodega4 = new Bodega("-31.537, -68.526", "Famosa por su Torrontés", "Desde 1975", "Bodega Callia", 12, region2);
        public static Bodega bodega5 = new Bodega("-29.413, -66.856", "Reconocida por sus Malbecs", "Desde 1950", "Bodega La Riojana", 6, region6);
        public static Bodega bodega6 = new Bodega("-29.420, -66.870", "Pequeña bodega artesanal", "Desde 1985", "Bodega San Huberto", 12, region3);
        public static Bodega bodega7 = new Bodega("-24.787, -65.410", "Viñedos a gran altitud", "Fundada en 1892", "Bodega El Porvenir", 6, region9);
        public static Bodega bodega8 = new Bodega("-24.789, -65.405", "Conocida por sus vinos blancos", "Desde 1940", "Bodega Colomé", 3, region4);
        public static Bodega bodega9 = new Bodega("-38.948, -68.058", "Joven y moderna", "Desde 2000", "Bodega del Fin del Mundo", 12, region5);
        public static Bodega bodega10 = new Bodega("-39.024, -68.245", "Innovadora en la Patagonia", "Desde 1999", "Bodega Patritti", 6, region7);



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
        */

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

        public static Varietal varietal1 = new Varietal("Cabernet Sauvignon", 40.5f, tipoUva1);
        public static Varietal varietal2 = new Varietal("Merlot", 30.0f, tipoUva2);
        public static Varietal varietal3 = new Varietal("Pinot Noir", 10.0f, tipoUva3);
        public static Varietal varietal4 = new Varietal("Syrah", 5.5f, tipoUva4);
        public static Varietal varietal5 = new Varietal("Zinfandel", 3.0f, tipoUva5);
        public static Varietal varietal6 = new Varietal("Malbec", 2.5f, tipoUva6);
        public static Varietal varietal7 = new Varietal("Sauvignon Blanc", 4.0f, tipoUva7);
        public static Varietal varietal8 = new Varietal("Chardonnay", 2.5f, tipoUva8);
        public static Varietal varietal9 = new Varietal("Riesling", 1.0f, tipoUva9);
        public static Varietal varietal10 = new Varietal("Grenache", 1.0f, tipoUva10);

        /*
        public static Pais pais1 = new Pais("Argentina");
        public static Pais pais2 = new Pais("Brasil");
        public static Pais pais3 = new Pais("Chile");
        public static Pais pais4 = new Pais("Uruguay");
        public static Pais pais5 = new Pais("Paraguay");
        public static Pais pais6 = new Pais("Bolivia");
        public static Pais pais7 = new Pais("Perú");
        public static Pais pais8 = new Pais("Colombia");
        public static Pais pais9 = new Pais("Venezuela");
        public static Pais pais10 = new Pais("Ecuador");*/

        
        /*public static Vino vino1 = new Vino("ImagenEtiqueta1", 2018, "Catena Zapata Malbec Argentino", "Vista: Color púrpura intenso con reflejos violáceos.\r\nNariz: Aromas complejos de frutos negros maduros, como moras y ciruelas, con notas de violeta, especias y toques de roble francés.\r\nBoca: En boca es estructurado, con taninos firmes pero sedosos, equilibrado, con sabores de frutas negras, chocolate y un toque mineral. Final largo y persistente.\r\n", 1.5f, crearListaVarietales(), crearListaReseña(), bodega1));
        public static Vino vino2 = new Vino("ImagenEtiqueta1", 2018, "Catena Zapata Malbec Argentino", "Vista: Color púrpura intenso con reflejos violáceos.\r\nNariz: Aromas complejos de frutos negros maduros, como moras y ciruelas, con notas de violeta, especias y toques de roble francés.\r\nBoca: En boca es estructurado, con taninos firmes pero sedosos, equilibrado, con sabores de frutas negras, chocolate y un toque mineral. Final largo y persistente.\r\n", 1.5f, crearListaVarietales(), crearListaReseña(), bodega1));
        public static Vino vino3 = new Vino("ImagenEtiqueta2", 2019, "Norton Reserva Malbec", "Vista: Rojo rubí profundo.\r\nNariz: Aromas de frutas rojas maduras, ciruelas y moras, con sutiles notas de especias y vainilla.\r\nBoca: En boca es jugoso y bien balanceado, con taninos suaves y redondos. Sabores de frutos rojos, chocolate y un leve toque de roble. Final agradable y persistente.", 2.5f, crearListaVarietales(), crearListaReseña(), bodega2));
        public static Vino vino4 = new Vino("ImagenEtiqueta3", 2017, "Luigi Bosca De Sangre Cabernet Sauvignon", "Vista: Rojo granate intenso.\r\nNariz: Aromas de frutas negras maduras, como cassis y ciruelas, acompañados de notas de pimienta negra, tabaco y cacao.\r\nBoca: Cuerpo robusto con taninos firmes y bien integrados. Sabores de frutas negras, especias y un toque ahumado. Final largo y elegante.", 3.5f, crearListaVarietales(), crearListaReseña(), bodega3));
        public static Vino vino5 = new Vino("ImagenEtiqueta4", 2018, "Trapiche Iscay Malbec-Cabernet Franc", "Vista: Color rojo profundo con matices violetas.\r\nNariz: Aromas intensos de frutos rojos y negros, con notas florales de violeta y toques de hierbas y especias.\r\nBoca: En boca es complejo y elegante, con taninos maduros y una acidez equilibrada. Sabores de frutas maduras, especias y un toque mineral. Final largo y persistente.", 4.5f, crearListaVarietales(), crearListaReseña(), bodega4));
        public static Vino vino6 = new Vino("ImagenEtiqueta5", 2019, "El Enemigo Chardonnay", "Vista: Color dorado brillante.\r\nNariz: Aromas de frutas tropicales, como piña y mango, con notas cítricas, vainilla y un toque de mantequilla.\r\nBoca: En boca es fresco y cremoso, con una buena acidez que equilibra los sabores de frutas tropicales, cítricos y un suave toque de roble. Final largo y refrescante.", 5.5f, crearListaVarietales(), crearListaReseña(), bodega5));
        public static Vino vino7 = new Vino("ImagenEtiqueta6", 2016, "Achaval Ferrer Finca Altamira Malbec", "Vista: Color púrpura intenso.\r\nNariz: Aromas profundos de frutas negras, como moras y arándanos, con notas florales de violeta, especias y un toque mineral.\r\nBoca: En boca es potente y elegante, con taninos firmes y bien estructurados. Sabores de frutas negras, especias y un toque terroso. Final largo y complejo.", 6.5f, crearListaVarietales(), crearListaReseña(), bodega6));
        public static Vino vino8 = new Vino("ImagenEtiqueta7", 2020, "Susana Balbo Signature Torrontés", "Vista: Color amarillo pálido con reflejos verdosos.\r\nNariz: Aromas intensos de flores blancas, como jazmín y azahar, con notas cítricas y de frutas tropicales.\r\nBoca: En boca es fresco y vibrante, con una acidez equilibrada. Sabores de frutas cítricas, durazno y un toque de especias. Final largo y aromático.", 7.5f, crearListaVarietales(), crearListaReseña(), bodega7));
        public static Vino vino9 = new Vino("ImagenEtiqueta8", 2018, "Bodega Colomé Auténtico Malbec", "Vista: Rojo profundo con tonos violetas.\r\nNariz: Aromas intensos de frutas rojas y negras, como ciruelas y moras, con notas florales y de especias.\r\nBoca: En boca es concentrado y potente, con taninos firmes y bien integrados. Sabores de frutas maduras, especias y un toque mineral. Final largo y persistente.", 8.5f, crearListaVarietales(), crearListaReseña(), bodega8));*/
        
        public List<Vino> returnVinos()
        {
            List<Vino> listaVinos = new List<Vino>();

            listaVinos.Add(new Vino("ImagenEtiqueta1", 2018, "Catena Zapata Malbec Argentino", "Vista: Color púrpura intenso con reflejos violáceos.\r\nNariz: Aromas complejos de frutos negros maduros, como moras y ciruelas, con notas de violeta, especias y toques de roble francés.\r\nBoca: En boca es estructurado, con taninos firmes pero sedosos, equilibrado, con sabores de frutas negras, chocolate y un toque mineral. Final largo y persistente.\r\n", 1.5f, crearListaVarietales(), crearListaReseña(), bodega1));
            listaVinos.Add(new Vino("ImagenEtiqueta2", 2019, "Norton Reserva Malbec", "Vista: Rojo rubí profundo.\r\nNariz: Aromas de frutas rojas maduras, ciruelas y moras, con sutiles notas de especias y vainilla.\r\nBoca: En boca es jugoso y bien balanceado, con taninos suaves y redondos. Sabores de frutos rojos, chocolate y un leve toque de roble. Final agradable y persistente.", 2.5f, crearListaVarietales(), crearListaReseña(), bodega2));
            listaVinos.Add(new Vino("ImagenEtiqueta3", 2017, "Luigi Bosca De Sangre Cabernet Sauvignon", "Vista: Rojo granate intenso.\r\nNariz: Aromas de frutas negras maduras, como cassis y ciruelas, acompañados de notas de pimienta negra, tabaco y cacao.\r\nBoca: Cuerpo robusto con taninos firmes y bien integrados. Sabores de frutas negras, especias y un toque ahumado. Final largo y elegante.", 3.5f, crearListaVarietales(), crearListaReseña(), bodega3));
            listaVinos.Add(new Vino("ImagenEtiqueta4", 2018, "Trapiche Iscay Malbec-Cabernet Franc", "Vista: Color rojo profundo con matices violetas.\r\nNariz: Aromas intensos de frutos rojos y negros, con notas florales de violeta y toques de hierbas y especias.\r\nBoca: En boca es complejo y elegante, con taninos maduros y una acidez equilibrada. Sabores de frutas maduras, especias y un toque mineral. Final largo y persistente.", 4.5f, crearListaVarietales(), crearListaReseña(), bodega4));
            listaVinos.Add(new Vino("ImagenEtiqueta5", 2019, "El Enemigo Chardonnay", "Vista: Color dorado brillante.\r\nNariz: Aromas de frutas tropicales, como piña y mango, con notas cítricas, vainilla y un toque de mantequilla.\r\nBoca: En boca es fresco y cremoso, con una buena acidez que equilibra los sabores de frutas tropicales, cítricos y un suave toque de roble. Final largo y refrescante.", 5.5f, crearListaVarietales(), crearListaReseña(), bodega5));
            listaVinos.Add(new Vino("ImagenEtiqueta6", 2016, "Achaval Ferrer Finca Altamira Malbec", "Vista: Color púrpura intenso.\r\nNariz: Aromas profundos de frutas negras, como moras y arándanos, con notas florales de violeta, especias y un toque mineral.\r\nBoca: En boca es potente y elegante, con taninos firmes y bien estructurados. Sabores de frutas negras, especias y un toque terroso. Final largo y complejo.", 6.5f, crearListaVarietales(), crearListaReseña(), bodega6));
            listaVinos.Add(new Vino("ImagenEtiqueta7", 2020, "Susana Balbo Signature Torrontés", "Vista: Color amarillo pálido con reflejos verdosos.\r\nNariz: Aromas intensos de flores blancas, como jazmín y azahar, con notas cítricas y de frutas tropicales.\r\nBoca: En boca es fresco y vibrante, con una acidez equilibrada. Sabores de frutas cítricas, durazno y un toque de especias. Final largo y aromático.", 7.5f, crearListaVarietales(), crearListaReseña(), bodega7));
            listaVinos.Add(new Vino("ImagenEtiqueta8", 20, "Bodega Colomé Auténtico Malbec", "Vista: Rojo profundo con tonos violetas.\r\nNariz: Aromas intensos de frutas rojas y negras, como ciruelas y moras, con notas florales y de especias.\r\nBoca: En boca es concentrado y potente, con taninos firmes y bien integrados. Sabores de frutas maduras, especias y un toque mineral. Final largo y persistente.", 8.5f, crearListaVarietales(), crearListaReseña(), bodega8));
            listaVinos.Add(new Vino("ImagenEtiqueta9", 20, "Rutini Apartado Gran Malbec", "Vista: Rojo oscuro con reflejos violáceos.\r\nNariz: Aromas complejos de frutas negras, como moras y ciruelas, con notas de chocolate, vainilla y especias.\r\nBoca: En boca es robusto y bien estructurado, con taninos maduros y una acidez equilibrada. Sabores de frutas negras, chocolate y un toque de roble. Final largo y elegante.", 9.5f, crearListaVarietales(), crearListaReseña(), bodega9));
            listaVinos.Add(new Vino("ImagenEtiqueta1", 20, "Catena Zapata Malbec Argentino", "Vista: Color púrpura intenso con reflejos violáceos.\r\nNariz: Aromas complejos de frutos negros maduros, como moras y ciruelas, con notas de violeta, especias y toques de roble francés.\r\nBoca: En boca es estructurado, con taninos firmes pero sedosos, equilibrado, con sabores de frutas negras, chocolate y un toque mineral. Final largo y persistente.\r\n", 1.5f, crearListaVarietales(), crearListaReseña(), bodega1));
            listaVinos.Add(new Vino("ImagenEtiqueta2", 20, "Norton Reserva Malbec", "Vista: Rojo rubí profundo.\r\nNariz: Aromas de frutas rojas maduras, ciruelas y moras, con sutiles notas de especias y vainilla.\r\nBoca: En boca es jugoso y bien balanceado, con taninos suaves y redondos. Sabores de frutos rojos, chocolate y un leve toque de roble. Final agradable y persistente.", 2.5f, crearListaVarietales(), crearListaReseña(), bodega2));
            listaVinos.Add(new Vino("ImagenEtiqueta3", 2017, "Luigi Bosca De Sangre Cabernet Sauvignon", "Vista: Rojo granate intenso.\r\nNariz: Aromas de frutas negras maduras, como cassis y ciruelas, acompañados de notas de pimienta negra, tabaco y cacao.\r\nBoca: Cuerpo robusto con taninos firmes y bien integrados. Sabores de frutas negras, especias y un toque ahumado. Final largo y elegante.", 3.5f, crearListaVarietales(), crearListaReseña(), bodega3));
            listaVinos.Add(new Vino("ImagenEtiqueta4", 2018, "Trapiche Iscay Malbec-Cabernet Franc", "Vista: Color rojo profundo con matices violetas.\r\nNariz: Aromas intensos de frutos rojos y negros, con notas florales de violeta y toques de hierbas y especias.\r\nBoca: En boca es complejo y elegante, con taninos maduros y una acidez equilibrada. Sabores de frutas maduras, especias y un toque mineral. Final largo y persistente.", 4.5f, crearListaVarietales(), crearListaReseña(), bodega4));
            listaVinos.Add(new Vino("ImagenEtiqueta5", 2019, "El Enemigo Chardonnay", "Vista: Color dorado brillante.\r\nNariz: Aromas de frutas tropicales, como piña y mango, con notas cítricas, vainilla y un toque de mantequilla.\r\nBoca: En boca es fresco y cremoso, con una buena acidez que equilibra los sabores de frutas tropicales, cítricos y un suave toque de roble. Final largo y refrescante.", 5.5f, crearListaVarietales(), crearListaReseña(), bodega5));
            listaVinos.Add(new Vino("ImagenEtiqueta6", 2016, "Achaval Ferrer Finca Altamira Malbec", "Vista: Color púrpura intenso.\r\nNariz: Aromas profundos de frutas negras, como moras y arándanos, con notas florales de violeta, especias y un toque mineral.\r\nBoca: En boca es potente y elegante, con taninos firmes y bien estructurados. Sabores de frutas negras, especias y un toque terroso. Final largo y complejo.", 6.5f, crearListaVarietales(), crearListaReseña(), bodega6));
            listaVinos.Add(new Vino("ImagenEtiqueta7", 2020, "Susana Balbo Signature Torrontés", "Vista: Color amarillo pálido con reflejos verdosos.\r\nNariz: Aromas intensos de flores blancas, como jazmín y azahar, con notas cítricas y de frutas tropicales.\r\nBoca: En boca es fresco y vibrante, con una acidez equilibrada. Sabores de frutas cítricas, durazno y un toque de especias. Final largo y aromático.", 7.5f, crearListaVarietales(), crearListaReseña(), bodega7));
            listaVinos.Add(new Vino("ImagenEtiqueta8", 2018, "Bodega Colomé Auténtico Malbec", "Vista: Rojo profundo con tonos violetas.\r\nNariz: Aromas intensos de frutas rojas y negras, como ciruelas y moras, con notas florales y de especias.\r\nBoca: En boca es concentrado y potente, con taninos firmes y bien integrados. Sabores de frutas maduras, especias y un toque mineral. Final largo y persistente.", 8.5f, crearListaVarietales(), crearListaReseña(), bodega8));
            listaVinos.Add(new Vino("ImagenEtiqueta9", 2017, "Rutini Apartado Gran Malbec", "Vista: Rojo oscuro con reflejos violáceos.\r\nNariz: Aromas complejos de frutas negras, como moras y ciruelas, con notas de chocolate, vainilla y especias.\r\nBoca: En boca es robusto y bien estructurado, con taninos maduros y una acidez equilibrada. Sabores de frutas negras, chocolate y un toque de roble. Final largo y elegante.", 9.5f, crearListaVarietales(), crearListaReseña(), bodega9));
            listaVinos.Add(new Vino("ImagenEtiqueta10", 2023, "Luigi Bosca Malbec", "Vista: Color rojo profundo con reflejos violáceos.\r\nNariz: Aromas intensos de frutas rojas y negras, con notas de vainilla y especias.\r\nBoca: En boca es robusto y equilibrado, con taninos suaves y un final largo y persistente.", 10.5f, crearListaVarietales(), crearListaReseña(), bodega9));
            listaVinos.Add(new Vino("ImagenEtiqueta11", 2023, "Trapiche Gran Medalla Malbec", "Vista: Color púrpura profundo.\r\nNariz: Aromas de frutas maduras, como moras y ciruelas, con notas florales y de especias.\r\nBoca: En boca es elegante y estructurado, con taninos firmes y una acidez equilibrada. Sabores de frutas negras y especias. Final largo y persistente.", 11.5f, crearListaVarietales(), crearListaReseña(), bodega10));
            listaVinos.Add(new Vino("ImagenEtiqueta12", 2023, "Finca Decero Petit Verdot", "Vista: Color rojo rubí intenso.\r\nNariz: Aromas de frutas rojas y negras, con notas de especias y toques florales.\r\nBoca: En boca es suave y sedoso, con taninos redondos y una acidez equilibrada. Sabores de frutas maduras y especias. Final largo y aromático.", 12.5f, crearListaVarietales(), crearListaReseña(), bodega2));
            listaVinos.Add(new Vino("ImagenEtiqueta13", 2023, "Clos de los Siete Red Blend", "Vista: Color rojo profundo con matices violetas.\r\nNariz: Aromas complejos de frutas negras, especias y tostado.\r\nBoca: En boca es potente y estructurado, con taninos firmes y una acidez equilibrada. Sabores de frutas maduras y especias. Final largo y persistente.", 13.5f, crearListaVarietales(), crearListaReseña(), bodega3));
            listaVinos.Add(new Vino("ImagenEtiqueta14", 2023, "Finca Sophenia Synthesis Malbec", "Vista: Color rojo intenso con matices violáceos.\r\nNariz: Aromas de frutas negras maduras, especias y toques minerales.\r\nBoca: En boca es potente y estructurado, con taninos firmes y una acidez equilibrada. Sabores de frutas negras y especias. Final largo y persistente.", 14.5f, crearListaVarietales(), crearListaReseña(), bodega8));
            listaVinos.Add(new Vino("ImagenEtiqueta15", 2023, "Casa Roja Cabernet Sauvignon", "Vista: Color rojo rubí brillante.\r\nNariz: Aromas de frutas rojas maduras, con notas de especias y toques herbáceos.\r\nBoca: En boca es fresco y equilibrado, con taninos suaves y una acidez moderada. Sabores de frutas rojas y especias. Final persistente.", 15.5f, crearListaVarietales(), crearListaReseña(), bodega4));
            listaVinos.Add(new Vino("ImagenEtiqueta16", 2023, "Bodegas Bianchi Malbec", "Vista: Color rojo violáceo profundo.\r\nNariz: Aromas intensos de frutas negras maduras, con notas de especias y tostado.\r\nBoca: En boca es estructurado y potente, con taninos firmes y una acidez equilibrada. Sabores de frutas negras y especias. Final largo y persistente.", 16.5f, crearListaVarietales(), crearListaReseña(), bodega5));
            listaVinos.Add(new Vino("ImagenEtiqueta18", 2020, "Terrazas de los Andes Malbec", "Vista: Color rojo intenso con reflejos violáceos.\r\nNariz: Aromas de frutas negras maduras, como moras y ciruelas, con notas de especias y toques minerales.\r\nBoca: En boca es potente y estructurado, con taninos firmes y una acidez equilibrada. Sabores de frutas negras y especias. Final largo y persistente.", 18.5f, crearListaVarietales(), crearListaReseña(), bodega6));
            listaVinos.Add(new Vino("ImagenEtiqueta19", 2018, "Cafayate Gran Linaje Malbec", "Vista: Rojo rubí profundo con matices violáceos.\r\nNariz: Aromas de frutas negras maduras, especias y tostado.\r\nBoca: En boca es potente y concentrado, con taninos firmes y una acidez equilibrada. Sabores de frutas maduras, especias y un toque ahumado. Final largo y persistente.", 19.5f, crearListaVarietales(), crearListaReseña(), bodega7));
            listaVinos.Add(new Vino("ImagenEtiqueta20", 2019, "Don Melchor Cabernet Sauvignon", "Vista: Color rojo profundo con reflejos violáceos.\r\nNariz: Aromas intensos de frutas negras, como cassis y moras, con notas de tabaco, cuero y especias.\r\nBoca: En boca es elegante y estructurado, con taninos maduros y una acidez equilibrada. Sabores de frutas negras, especias y un toque mineral. Final largo y persistente.", 20.5f, crearListaVarietales(), crearListaReseña(), bodega8));
            listaVinos.Add(new Vino("ImagenEtiqueta21", 2017, "Zuccardi Aluvional Paraje Altamira Malbec", "Vista: Color rojo intenso con matices violáceos.\r\nNariz: Aromas de frutas negras maduras, especias y toques minerales.\r\nBoca: En boca es potente y estructurado, con taninos firmes y una acidez equilibrada. Sabores de frutas maduras, especias y un toque terroso. Final largo y persistente.", 21.5f, crearListaVarietales(), crearListaReseña(), bodega9));
            listaVinos.Add(new Vino("ImagenEtiqueta22", 2022, "Mendel Unus Malbec", "Vista: Color rojo profundo con reflejos violáceos.\r\nNariz: Aromas de frutas negras maduras, como moras y ciruelas, con notas de vainilla y especias.\r\nBoca: En boca es concentrado y estructurado, con taninos firmes y una acidez equilibrada. Sabores de frutas maduras, especias y un toque de roble. Final largo y persistente.", 22.5f, crearListaVarietales(), crearListaReseña(), bodega2));
            listaVinos.Add(new Vino("ImagenEtiqueta23", 2022, "BenMarco Expresivo Malbec", "Vista: Color rojo intenso con matices violáceos.\r\nNariz: Aromas de frutas negras maduras, especias y tostado.\r\nBoca: En boca es potente y estructurado, con taninos firmes y una acidez equilibrada. Sabores de frutas maduras, especias y un toque ahumado. Final largo y persistente.", 23.5f, crearListaVarietales(), crearListaReseña(), bodega1));
            listaVinos.Add(new Vino("ImagenEtiqueta24", 2022, "Bodega Norton Lote Negro Malbec", "Vista: Color rojo intenso con reflejos violáceos.\r\nNariz: Aromas de frutas negras maduras, especias y tostado.\r\nBoca: En boca es potente y estructurado, con taninos firmes y una acidez equilibrada. Sabores de frutas maduras, especias y un toque ahumado. Final largo y persistente.", 24.5f, crearListaVarietales(), crearListaReseña(), bodega4));
            listaVinos.Add(new Vino("ImagenEtiqueta25", 2022, "Luigi Bosca Luján de Cuyo Malbec", "Vista: Color rojo profundo con matices violáceos.\r\nNariz: Aromas intensos de frutas negras maduras, especias y tostado.\r\nBoca: En boca es potente y estructurado, con taninos firmes y una acidez equilibrada. Sabores de frutas maduras, especias y un toque ahumado. Final largo y persistente.", 25.5f, crearListaVarietales(), crearListaReseña(), bodega3));
            listaVinos.Add(new Vino("ImagenEtiqueta26", 2019, "Finca Flichman Reserva Malbec", "Vista: Color rojo profundo con reflejos violáceos.\r\nNariz: Aromas de frutas negras maduras, especias y tostado.\r\nBoca: En boca es potente y estructurado, con taninos firmes y una acidez equilibrada. Sabores de frutas maduras, especias y un toque ahumado. Final largo y persistente.", 26.5f, crearListaVarietales(), crearListaReseña(), bodega4));
            listaVinos.Add(new Vino("ImagenEtiqueta27", 2018, "Salentein Single Vineyard Malbec", "Vista: Color rojo intenso con matices violáceos.\r\nNariz: Aromas de frutas negras maduras, especias y tostado.\r\nBoca: En boca es potente y estructurado, con taninos firmes y una acidez equilibrada. Sabores de frutas maduras, especias y un toque ahumado. Final largo y persistente.", 27.5f, crearListaVarietales(), crearListaReseña(), bodega9));



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

        public static Reseña reseña1 = new Reseña("Excelente producto", true, DateTime.Now.AddDays(-10), 5, vino1);
        public static Reseña reseña2 = new Reseña("Buena relación calidad-precio", false, DateTime.Now.AddDays(-5), 4, vino2);
        public static Reseña reseña3 = new Reseña("Envío rápido, producto como se describe", true, DateTime.Now.AddDays(-7), 5, vino1);
        public static Reseña reseña4 = new Reseña("No recibí el producto aún", false, DateTime.Now.AddDays(-15), 2, vino2);
        public static Reseña reseña5 = new Reseña("Producto defectuoso, pero excelente servicio al cliente", true, DateTime.Now.AddDays(-3), 3, vino1);
        public static Reseña reseña6 = new Reseña("No lo recomiendo, mala calidad", false, DateTime.Now.AddDays(-8), 1, vino2);
        public static Reseña reseña7 = new Reseña("El producto llegó tarde", true, DateTime.Now.AddDays(-12), 3, vino1);
        public static Reseña reseña8 = new Reseña("Buen producto, pero un poco caro", false, DateTime.Now.AddDays(-2), 4, vino2);
        public static Reseña reseña9 = new Reseña("Muy satisfecho con mi compra", true, DateTime.Now.AddDays(-6), 5, vino1);
        public static Reseña reseña10 = new Reseña("Producto excelente, lo recomiendo", false, DateTime.Now.AddDays(-4), 5, vino2);
        
        private List<Reseña> crearListaReseña()
        {
            List<Reseña> listaReseñas = new List<Reseña>();
            listaReseñas.Add(new Reseña("Excelente producto", true, DateTime.Now.AddDays(-10), 5, vino1));
            listaReseñas.Add(new Reseña("Buena relación calidad-precio", false, DateTime.Now.AddDays(-5), 4, vino2));
            listaReseñas.Add(new Reseña("Envío rápido, producto como se describe", true, DateTime.Now.AddDays(-7), 1, vino1));
            listaReseñas.Add(new Reseña("No recibí el producto aún", false, DateTime.Now.AddDays(-15), 2, vino2));
            listaReseñas.Add(new Reseña("Producto defectuoso, pero excelente servicio al cliente", true, DateTime.Now.AddDays(-3), 3, vino1));
            listaReseñas.Add(new Reseña("No lo recomiendo, mala calidad", false, DateTime.Now.AddDays(-8), 1, vino2));
            listaReseñas.Add(new Reseña("El producto llegó tarde", true, DateTime.Now.AddDays(-12), 3, vino1));
            listaReseñas.Add(new Reseña("Buen producto, pero un poco caro", false, DateTime.Now.AddDays(-2), 4, vino2));
            listaReseñas.Add(new Reseña("Muy satisfecho con mi compra", true, DateTime.Now.AddDays(-6), 3, vino1));
            listaReseñas.Add(new Reseña("Producto excelente, lo recomiendo", false, DateTime.Now.AddDays(-4), 5, vino2));
            return listaReseñas;



        }



    }
}
