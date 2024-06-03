using BonvinoApp.CapaNegocio;
using System;
using System.Collections.Generic;

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

        public static RegionVitivinicola region1 = new RegionVitivinicola("Mendoza", provincia1, "Región vitivinícola más importante de Argentina.");
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

        public static Vino vino1 = new Vino("ImagenEtiqueta1", 2018, "Catena Zapata Malbec Argentino", "Vista: Color púrpura intenso con reflejos violáceos.\r\nNariz: Aromas complejos de frutos negros maduros, como moras y ciruelas, con notas de violeta, especias y toques de roble francés.\r\nBoca: En boca es estructurado, con taninos firmes pero sedosos, equilibrado, con sabores de frutas negras, chocolate y un toque mineral. Final largo y persistente.\r\n", 1.5f, crearListaVarietales(), crearListaReseña(), bodega1);
        public static Vino vino2 = new Vino("ImagenEtiqueta2", 2019, "Norton Reserva Malbec", "Vista: Rojo rubí profundo.\r\nNariz: Aromas de frutas rojas maduras, ciruelas y moras, con sutiles notas de especias y vainilla.\r\nBoca: En boca es jugoso y bien balanceado, con taninos suaves y redondos. Sabores de frutos rojos, chocolate y un leve toque de roble. Final agradable y persistente.", 2.5f, crearListaVarietales(), crearListaReseña2(), bodega2);
        public static Vino vino3 = new Vino("ImagenEtiqueta3", 2017, "Luigi Bosca De Sangre Cabernet Sauvignon", "Vista: Rojo granate intenso.\r\nNariz: Aromas de frutas negras maduras, como cassis y ciruelas, acompañados de notas de pimienta negra, tabaco y cacao.\r\nBoca: Cuerpo robusto con taninos firmes y bien integrados. Sabores de frutas negras, especias y un toque ahumado. Final largo y elegante.", 3.5f, crearListaVarietales(), crearListaReseña3(), bodega3);
        public static Vino vino4 = new Vino("ImagenEtiqueta4", 2018, "Trapiche Iscay Malbec-Cabernet Franc", "Vista: Color rojo profundo con matices violetas.\r\nNariz: Aromas intensos de frutos rojos y negros, con notas florales de violeta y toques de hierbas y especias.\r\nBoca: En boca es complejo y elegante, con taninos maduros y una acidez equilibrada. Sabores de frutas maduras, especias y un toque mineral. Final largo y persistente.", 4.5f, crearListaVarietales(), crearListaReseña4(), bodega4);
        public static Vino vino5 = new Vino("ImagenEtiqueta5", 2019, "El Enemigo Chardonnay", "Vista: Color dorado brillante.\r\nNariz: Aromas de frutas tropicales, como piña y mango, con notas cítricas, vainilla y un toque de mantequilla.\r\nBoca: En boca es fresco y cremoso, con una buena acidez que equilibra los sabores de frutas tropicales, cítricos y un suave toque de roble. Final largo y refrescante.", 5.5f, crearListaVarietales(), crearListaReseña5(), bodega5);
        public static Vino vino6 = new Vino("ImagenEtiqueta6", 2016, "Achaval Ferrer Finca Altamira Malbec", "Vista: Color púrpura intenso.\r\nNariz: Aromas profundos de frutas negras, como moras y arándanos, con notas florales de violeta, especias y un toque mineral.\r\nBoca: En boca es potente y elegante, con taninos firmes y bien estructurados. Sabores de frutas negras, especias y un toque terroso. Final largo y complejo.", 6.5f, crearListaVarietales(), crearListaReseña6(), bodega6);
        public static Vino vino7 = new Vino("ImagenEtiqueta7", 2020, "Susana Balbo Signature Torrontés", "Vista: Color amarillo pálido con reflejos verdosos.\r\nNariz: Aromas intensos de flores blancas, como jazmín y azahar, con notas cítricas y de frutas tropicales.\r\nBoca: En boca es fresco y vibrante, con una acidez equilibrada. Sabores de frutas cítricas, durazno y un toque de especias. Final largo y aromático.", 7.5f, crearListaVarietales(), crearListaReseña7(), bodega7);
        public static Vino vino8 = new Vino("ImagenEtiqueta8", 2016, "Bodega Colomé Auténtico Malbec", "Vista: Rojo profundo con tonos violetas.\r\nNariz: Aromas intensos de frutas rojas y negras, como ciruelas y moras, con notas florales y de especias.\r\nBoca: En boca es concentrado y potente, con taninos firmes y bien integrados. Sabores de frutas maduras, especias y un toque mineral. Final largo y persistente.", 8.5f, crearListaVarietales(), crearListaReseña8(), bodega8);
        public static Vino vino9 = new Vino("ImagenEtiqueta9", 2019, "Rutini Apartado Gran Malbec", "Vista: Rojo oscuro con reflejos violáceos.\r\nNariz: Aromas complejos de frutas negras, como moras y ciruelas, con notas de chocolate, vainilla y especias.\r\nBoca: En boca es robusto y bien estructurado, con taninos maduros y una acidez equilibrada. Sabores de frutas negras, chocolate y un toque de roble. Final largo y elegante.", 9.5f, crearListaVarietales(), crearListaReseña16(), bodega9);
        public static Vino vino10 = new Vino("ImagenEtiqueta1", 2018, "Catena Zapata Malbec Argentino", "Vista: Color púrpura intenso con reflejos violáceos.\r\nNariz: Aromas complejos de frutos negros maduros, como moras y ciruelas, con notas de violeta, especias y toques de roble francés.\r\nBoca: En boca es estructurado, con taninos firmes pero sedosos, equilibrado, con sabores de frutas negras, chocolate y un toque mineral. Final largo y persistente.\r\n", 1.5f, crearListaVarietales(), crearListaReseña9(), bodega1);
        public static Vino vino11 = new Vino("ImagenEtiqueta2", 2023, "Norton Reserva Malbec", "Vista: Rojo rubí profundo.\r\nNariz: Aromas de frutas rojas maduras, ciruelas y moras, con sutiles notas de especias y vainilla.\r\nBoca: En boca es jugoso y bien balanceado, con taninos suaves y redondos. Sabores de frutos rojos, chocolate y un leve toque de roble. Final agradable y persistente.", 2.5f, crearListaVarietales(), crearListaReseña10(), bodega2);
        public static Vino vino12 = new Vino("ImagenEtiqueta3", 2017, "Luigi Bosca De Sangre Cabernet Sauvignon", "Vista: Rojo granate intenso.\r\nNariz: Aromas de frutas negras maduras, como cassis y ciruelas, acompañados de notas de pimienta negra, tabaco y cacao.\r\nBoca: Cuerpo robusto con taninos firmes y bien integrados. Sabores de frutas negras, especias y un toque ahumado. Final largo y elegante.", 3.5f, crearListaVarietales(), crearListaReseña11(), bodega3);
        public static Vino vino13 = new Vino("ImagenEtiqueta4", 2018, "Trapiche Iscay Malbec-Cabernet Franc", "Vista: Color rojo profundo con matices violetas.\r\nNariz: Aromas intensos de frutos rojos y negros, con notas florales de violeta y toques de hierbas y especias.\r\nBoca: En boca es complejo y elegante, con taninos maduros y una acidez equilibrada. Sabores de frutas maduras, especias y un toque mineral. Final largo y persistente.", 4.5f, crearListaVarietales(), crearListaReseña12(), bodega4);
        public static Vino vino14 = new Vino("ImagenEtiqueta5", 2019, "El Enemigo Chardonnay", "Vista: Color dorado brillante.\r\nNariz: Aromas de frutas tropicales, como piña y mango, con notas cítricas, vainilla y un toque de mantequilla.\r\nBoca: En boca es fresco y cremoso, con una buena acidez que equilibra los sabores de frutas tropicales, cítricos y un suave toque de roble. Final largo y refrescante.", 5.5f, crearListaVarietales(), crearListaReseña13(), bodega5);
        public static Vino vino15 = new Vino("ImagenEtiqueta6", 2016, "Achaval Ferrer Finca Altamira Malbec", "Vista: Color púrpura intenso.\r\nNariz: Aromas profundos de frutas negras, como moras y arándanos, con notas florales de violeta, especias y un toque mineral.\r\nBoca: En boca es potente y elegante, con taninos firmes y bien estructurados. Sabores de frutas negras, especias y un toque terroso. Final largo y complejo.", 6.5f, crearListaVarietales(), crearListaReseña14(), bodega6);
        public static Vino vino16 = new Vino("ImagenEtiqueta7", 2020, "Susana Balbo Signature Torrontés", "Vista: Color amarillo pálido con reflejos verdosos.\r\nNariz: Aromas intensos de flores blancas, como jazmín y azahar, con notas cítricas y de frutas tropicales.\r\nBoca: En boca es fresco y vibrante, con una acidez equilibrada. Sabores de frutas cítricas, durazno y un toque de especias. Final largo y aromático.", 7.5f, crearListaVarietales(), crearListaReseña15(), bodega7);
        public static Vino vino17 = new Vino("ImagenEtiqueta8", 2018, "Bodega Colomé Auténtico Malbec", "Vista: Rojo profundo con tonos violetas.\r\nNariz: Aromas intensos de frutas rojas y negras, como ciruelas y moras, con notas florales y de especias.\r\nBoca: En boca es concentrado y potente, con taninos firmes y bien integrados. Sabores de frutas maduras, especias y un toque mineral. Final largo y persistente.", 8.5f, crearListaVarietales(), crearListaReseña16(), bodega8);
        public static Vino vino18 = new Vino("ImagenEtiqueta9", 2017, "Rutini Apartado Gran Malbec", "Vista: Rojo oscuro con reflejos violáceos.\r\nNariz: Aromas complejos de frutas negras, como moras y ciruelas, con notas de chocolate, vainilla y especias.\r\nBoca: En boca es robusto y bien estructurado, con taninos maduros y una acidez equilibrada. Sabores de frutas negras, chocolate y un toque de roble. Final largo y elegante.", 9.5f, crearListaVarietales(), crearListaReseña16(), bodega9);
        public static Vino vino19 = new Vino("ImagenEtiqueta10", 2023, "Luigi Bosca Malbec", "Vista: Color rojo profundo con reflejos violáceos.\r\nNariz: Aromas intensos de frutas rojas y negras, con notas de vainilla y especias.\r\nBoca: En boca es robusto y equilibrado, con taninos suaves y un final largo y persistente.", 10.5f, crearListaVarietales(), crearListaReseña16(), bodega9);
        public static Vino vino20 = new Vino("ImagenEtiqueta11", 2023, "Trapiche Gran Medalla Malbec", "Vista: Color púrpura profundo.\r\nNariz: Aromas de frutas maduras, como moras y ciruelas, con notas florales y de especias.\r\nBoca: En boca es elegante y estructurado, con taninos firmes y una acidez equilibrada. Sabores de frutas negras y especias. Final largo y persistente.", 11.5f, crearListaVarietales(), crearListaReseña16(), bodega10);
       

        public static List<Vino> listarVinos()
        {
            List<Vino> listaVinos = new List<Vino>();

            listaVinos.Add(vino1);
            listaVinos.Add(vino2);
            listaVinos.Add(vino3);
            listaVinos.Add(vino4);
            listaVinos.Add(vino5);
            listaVinos.Add(vino6);
            listaVinos.Add(vino7);
            listaVinos.Add(vino8);
            listaVinos.Add(vino9);
            listaVinos.Add(vino10);
            listaVinos.Add(vino11);
            listaVinos.Add(vino12);
            listaVinos.Add(vino13);
            listaVinos.Add(vino14);
            listaVinos.Add(vino15);
            listaVinos.Add(vino16);
            listaVinos.Add(vino17);
            listaVinos.Add(vino18);
            listaVinos.Add(vino19);
            listaVinos.Add(vino20);

            return listaVinos;
        }

        private static List<Varietal> crearListaVarietales()
        {
            List<Varietal> listaVarietales = new List<Varietal>();

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
        public static Reseña reseña8 = new Reseña("Buen producto, pero un poco caro", false, DateTime.Now.AddDays(-2), 4, vino20);
        public static Reseña reseña9 = new Reseña("Muy satisfecho con mi compra", true, DateTime.Now.AddDays(-6), 5, vino1);
        public static Reseña reseña10 = new Reseña("Producto excelente, lo recomiendo", false, DateTime.Now.AddDays(-4), 5, vino11);
        public static Reseña reseña11 = new Reseña("Excelente producto", true, DateTime.Now.AddDays(-10), 5, vino1);
        public static Reseña reseña12 = new Reseña("Buena relación calidad-precio", false, DateTime.Now.AddDays(-5), 4, vino2);
        public static Reseña reseña13 = new Reseña("Envío rápido, producto como se describe", true, DateTime.Now.AddDays(-7), 1, vino11);
        public static Reseña reseña14 = new Reseña("No recibí el producto aún", false, DateTime.Now.AddDays(-15), 2, vino2);
        public static Reseña reseña15 = new Reseña("Producto defectuoso, pero excelente servicio al cliente", true, DateTime.Now.AddDays(-3), 3, vino1);
        public static Reseña reseña16 = new Reseña("No lo recomiendo, mala calidad", false, DateTime.Now.AddDays(-8), 1, vino20);
        public static Reseña reseña17 = new Reseña("El producto llegó tarde", true, DateTime.Now.AddDays(-12), 3, vino1);
        public static Reseña reseña18 = new Reseña("Buen producto, pero un poco caro", false, DateTime.Now.AddDays(-2), 4, vino11);
        public static Reseña reseña19 = new Reseña("Muy satisfecho con mi compra", true, DateTime.Now.AddDays(-6), 3, vino1);
        public static Reseña reseña20 = new Reseña("Producto excelente, lo recomiendo", false, DateTime.Now.AddDays(-4), 5, vino11);
        public static Reseña reseña21 = new Reseña("El sabor es increíble, muy recomendado", true, DateTime.Now.AddDays(-11), 5, vino1);
        public static Reseña reseña22 = new Reseña("No es lo que esperaba, decepcionante", false, DateTime.Now.AddDays(-13), 2, vino20);
        public static Reseña reseña23 = new Reseña("Excelente atención al cliente, buen vino", true, DateTime.Now.AddDays(-9), 4, vino1);
        public static Reseña reseña24 = new Reseña("No volveré a comprar este vino", false, DateTime.Now.AddDays(-20), 1, vino2);
        public static Reseña reseña25 = new Reseña("Calidad superior, vale cada centavo", true, DateTime.Now.AddDays(-14), 5, vino14);
        public static Reseña reseña26 = new Reseña("Aceptable, pero hay mejores opciones", false, DateTime.Now.AddDays(-19), 3, vino2);
        public static Reseña reseña27 = new Reseña("Entrega rápida, calidad mediocre", true, DateTime.Now.AddDays(-16), 2, vino1);
        public static Reseña reseña28 = new Reseña("Sabor impresionante, repetiré", false, DateTime.Now.AddDays(-17), 4, vino20);
        public static Reseña reseña29 = new Reseña("Precio alto para la calidad", true, DateTime.Now.AddDays(-18), 3, vino1);
        public static Reseña reseña30 = new Reseña("No me gustó el sabor", false, DateTime.Now.AddDays(-21), 2, vino2);
        public static Reseña reseña31 = new Reseña("Perfecto para ocasiones especiales", true, DateTime.Now.AddDays(-22), 5, vino14);
        public static Reseña reseña32 = new Reseña("Mala experiencia, vino roto", false, DateTime.Now.AddDays(-23), 1, vino2);
        public static Reseña reseña33 = new Reseña("Gran calidad y buen precio", true, DateTime.Now.AddDays(-24), 4, vino14);
        public static Reseña reseña34 = new Reseña("Sabor único, muy recomendable", false, DateTime.Now.AddDays(-25), 5, vino2);
        public static Reseña reseña35 = new Reseña("Esperaba más por el precio", true, DateTime.Now.AddDays(-26), 3, vino1);
        public static Reseña reseña36 = new Reseña("Muy malo, no lo compraré otra vez", false, DateTime.Now.AddDays(-27), 1, vino14);
        public static Reseña reseña37 = new Reseña("Recomendado para cenas especiales", true, DateTime.Now.AddDays(-28), 5, vino1);
        public static Reseña reseña38 = new Reseña("No vale la pena, pésima calidad", false, DateTime.Now.AddDays(-29), 1, vino2);
        public static Reseña reseña39 = new Reseña("Buena compra, buen vino", true, DateTime.Now.AddDays(-30), 4, vino14);
        public static Reseña reseña40 = new Reseña("Demasiado caro para lo que ofrece", false, DateTime.Now.AddDays(-31), 2, vino2);
        public static Reseña reseña41 = new Reseña("Sabor suave y delicado, muy bueno", true, DateTime.Now.AddDays(-2), 5, vino3);
        public static Reseña reseña42 = new Reseña("No cumplió mis expectativas", false, DateTime.Now.AddDays(-5), 2, vino4);
        public static Reseña reseña43 = new Reseña("Gran vino para acompañar carnes", true, DateTime.Now.AddDays(-8), 4, vino5);
        public static Reseña reseña44 = new Reseña("Muy ácido para mi gusto", false, DateTime.Now.AddDays(-12), 2, vino6);
        public static Reseña reseña45 = new Reseña("El aroma es excelente", true, DateTime.Now.AddDays(-14), 5, vino7);
        public static Reseña reseña46 = new Reseña("Buena opción para cenas", false, DateTime.Now.AddDays(-16), 4, vino8);
        public static Reseña reseña47 = new Reseña("No me gustó, esperaba más", true, DateTime.Now.AddDays(-19), 1, vino9);
        public static Reseña reseña48 = new Reseña("Excelente relación calidad/precio", false, DateTime.Now.AddDays(-21), 5, vino10);
        public static Reseña reseña49 = new Reseña("Demasiado fuerte para mi paladar", true, DateTime.Now.AddDays(-25), 3, vino11);
        public static Reseña reseña50 = new Reseña("Perfecto para maridar con pescados", false, DateTime.Now.AddDays(-28), 4, vino12);
        public static Reseña reseña51 = new Reseña("Increíble sabor frutal", true, DateTime.Now.AddDays(-30), 5, vino13);
        public static Reseña reseña52 = new Reseña("No me gustó, muy seco", false, DateTime.Now.AddDays(-32), 2, vino14);
        public static Reseña reseña53 = new Reseña("Sabor equilibrado, muy recomendable", true, DateTime.Now.AddDays(-35), 4, vino15);
        public static Reseña reseña54 = new Reseña("El vino llegó dañado", false, DateTime.Now.AddDays(-38), 1, vino16);
        public static Reseña reseña55 = new Reseña("Buen vino para su precio", true, DateTime.Now.AddDays(-40), 3, vino17);
        public static Reseña reseña56 = new Reseña("Muy bueno, lo recomiendo", false, DateTime.Now.AddDays(-42), 5, vino18);
        public static Reseña reseña57 = new Reseña("Un poco dulce para mi gusto", true, DateTime.Now.AddDays(-45), 3, vino19);
        public static Reseña reseña58 = new Reseña("Perfecto para una noche de verano", false, DateTime.Now.AddDays(-48), 4, vino20);
        public static Reseña reseña59 = new Reseña("El vino es aceptable", true, DateTime.Now.AddDays(-50), 3, vino2);
        public static Reseña reseña60 = new Reseña("No lo volveré a comprar", false, DateTime.Now.AddDays(-53), 1, vino12);
        public static Reseña reseña61 = new Reseña("Excelente calidad", true, DateTime.Now.AddDays(-55), 5, vino12);
        public static Reseña reseña62 = new Reseña("Me decepcionó mucho", false, DateTime.Now.AddDays(-57), 2, vino14);
        public static Reseña reseña63 = new Reseña("Gran vino, lo compraré de nuevo", true, DateTime.Now.AddDays(-60), 4, vino15);
        public static Reseña reseña64 = new Reseña("No vale lo que cuesta", false, DateTime.Now.AddDays(-62), 2, vino16);
        public static Reseña reseña65 = new Reseña("Muy buen sabor y aroma", true, DateTime.Now.AddDays(-65), 5, vino17);
        //para mostrar flujo alternativo de que no hay reseñas de somelier entre el 16/11/2023 - 18/12/2023
        public static Reseña reseña70 = new Reseña("Sabor suave, perfecto", false, DateTime.Now.AddDays(-200), 5, vino12);
        public static Reseña reseña71 = new Reseña("Vino decente, nada especial", false, DateTime.Now.AddDays(-200), 3, vino13);
        public static Reseña reseña72 = new Reseña("No me gustó para nada", false, DateTime.Now.AddDays(-200), 1, vino14);
        public static Reseña reseña73 = new Reseña("Muy bueno para su precio", false, DateTime.Now.AddDays(-200), 4, vino15);
        public static Reseña reseña66 = new Reseña("El sabor es mediocre", false, DateTime.Now.AddDays(-170), 3, vino18);
        public static Reseña reseña67 = new Reseña("Me encantó, lo recomiendo", false, DateTime.Now.AddDays(-170), 5, vino19);
        public static Reseña reseña68 = new Reseña("Llegó rápido, buen vino", false, DateTime.Now.AddDays(-170), 4, vino10);
        public static Reseña reseña69 = new Reseña("Muy ácido, no me gustó", false, DateTime.Now.AddDays(-170), 2, vino11);

        private static List<Reseña> crearListaReseña()
        {
            List<Reseña> listaReseñas = new List<Reseña>();

            listaReseñas.Add(reseña1);
            listaReseñas.Add(reseña2);
            listaReseñas.Add(reseña3);
            listaReseñas.Add(reseña4);
            listaReseñas.Add(reseña5);
            return listaReseñas;
        }


        private static List<Reseña> crearListaReseña2()
        {
            List<Reseña> listaReseñas = new List<Reseña>();
            listaReseñas.Add(reseña15);
            listaReseñas.Add(reseña16);
            listaReseñas.Add(reseña17);
            listaReseñas.Add(reseña18);
            return listaReseñas;

        }


        private static List<Reseña> crearListaReseña3()
        {
            List<Reseña> listaReseñas = new List<Reseña>();
            listaReseñas.Add(reseña28);
            listaReseñas.Add(reseña29);
            listaReseñas.Add(reseña30);
            listaReseñas.Add(reseña31);
            listaReseñas.Add(reseña32);
            listaReseñas.Add(reseña40);
            return listaReseñas;

        }
        private static List<Reseña> crearListaReseña4()
        {
            List<Reseña> listaReseñas = new List<Reseña>();

            listaReseñas.Add(reseña41);
            listaReseñas.Add(reseña42);
            listaReseñas.Add(reseña43);
            listaReseñas.Add(reseña44);
            listaReseñas.Add(reseña45);
            return listaReseñas;

        }

        private static List<Reseña> crearListaReseña5()
        {
            List<Reseña> listaReseñas = new List<Reseña>();
            listaReseñas.Add(reseña54);
            listaReseñas.Add(reseña55);
            listaReseñas.Add(reseña56);
            return listaReseñas;

        }

        private static List<Reseña> crearListaReseña6()
        {
            List<Reseña> listaReseñas = new List<Reseña>();
            listaReseñas.Add(reseña67);
            listaReseñas.Add(reseña68);
            listaReseñas.Add(reseña69);
            return listaReseñas;

        }

        private static List<Reseña> crearListaReseña7() 
        {
            List<Reseña> listaReseñas = new List<Reseña>();
            listaReseñas.Add(reseña19);
            listaReseñas.Add(reseña20);
            listaReseñas.Add(reseña21);
            listaReseñas.Add(reseña22);
            return listaReseñas;
        }



        private static List<Reseña> crearListaReseña8()
        {
            List<Reseña> listaReseñas = new List<Reseña>();
            listaReseñas.Add(reseña6);
            listaReseñas.Add(reseña7);
            listaReseñas.Add(reseña8);
            listaReseñas.Add(reseña9);
            listaReseñas.Add(reseña10);
            return listaReseñas;
        }

        private static List<Reseña> crearListaReseña9()
        {
            List<Reseña> listaReseñas = new List<Reseña>();
            listaReseñas.Add(reseña23);
            listaReseñas.Add(reseña24);
            listaReseñas.Add(reseña25);
            listaReseñas.Add(reseña26);
            listaReseñas.Add(reseña27);
            return listaReseñas;
        }

        private static List<Reseña> crearListaReseña10()
        {
            List<Reseña> listaReseñas = new List<Reseña>();
            listaReseñas.Add(reseña11);
            listaReseñas.Add(reseña12);
            listaReseñas.Add(reseña13);
            listaReseñas.Add(reseña14);
            return listaReseñas;
        }


        private static List<Reseña> crearListaReseña11()
        {
            List<Reseña> listaReseñas = new List<Reseña>();
            listaReseñas.Add(reseña33);
            listaReseñas.Add(reseña34);
            listaReseñas.Add(reseña35);
            listaReseñas.Add(reseña36);
            listaReseñas.Add(reseña37);
            listaReseñas.Add(reseña38);
            listaReseñas.Add(reseña39);
            return listaReseñas;
        }

        private static List<Reseña> crearListaReseña12()
        {
            List<Reseña> listaReseñas = new List<Reseña>();
            listaReseñas.Add(reseña46);
            listaReseñas.Add(reseña47);
            listaReseñas.Add(reseña48);
            listaReseñas.Add(reseña49);
            return listaReseñas;
        }

        private static List<Reseña> crearListaReseña13()
        {
            List<Reseña> listaReseñas = new List<Reseña>();
            listaReseñas.Add(reseña57);
            listaReseñas.Add(reseña58);
            listaReseñas.Add(reseña59);
            listaReseñas.Add(reseña60);
            listaReseñas.Add(reseña61);
            listaReseñas.Add(reseña62);
            return listaReseñas;
        }


        private static List<Reseña> crearListaReseña14()
        {
            List<Reseña> listaReseñas = new List<Reseña>();
            listaReseñas.Add(reseña50);
            listaReseñas.Add(reseña51);
            listaReseñas.Add(reseña52);
            listaReseñas.Add(reseña53);
            return listaReseñas;
        }


        private static List<Reseña> crearListaReseña15()
        {
            List<Reseña> listaReseñas = new List<Reseña>();
            listaReseñas.Add(reseña63);
            listaReseñas.Add(reseña64);
            listaReseñas.Add(reseña65);
            listaReseñas.Add(reseña66);
            return listaReseñas;
        }


        private static List<Reseña> crearListaReseña16()
        {
            List<Reseña> listaReseñas = new List<Reseña>();

            return listaReseñas;

        }
    }
}
