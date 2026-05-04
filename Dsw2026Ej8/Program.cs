using Dsw2026Ej8.Problema1;
using Dsw2026Ej8.Problema2;
using Dsw2026Ej8.Problema3;
using Dsw2026Ej8.Problema4;
using Dsw2026Ej8.Problema5;



namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problema 1
            var helper = new ProductHelper();
            string etiqueta = helper.ObtenerEtiquetaProducto(1001, "Manzana", 150.50m);
            Console.WriteLine("Problema 1: " + etiqueta);


            //problema 2
            var problema2 = new ResumenVentaHelper(); string resumen = problema2.CrearResumenVenta(2001, "Banana", 5, 100m);
            Console.WriteLine("Problema 2: " + resumen);

            string resumenCero = problema2.CrearResumenVenta(2002, "Pera", 0, 100m);
            Console.WriteLine("Problema 2 (qty 0): " + resumenCero);


            //problema 3using Dsw2026Ej8.Problema3;


            var problema3 = new CopiaHelper();
            var product = new Product("Descripcion original");
            string comparacion = problema3.CompararCopias(10, product);
            Console.WriteLine("Problema 3: " + comparacion);



            //problema 4


            // dentro del Main:
            var problema4 = new PromedioHelper();
            Console.WriteLine("Problema 4: " + problema4.CalcularPromedio(8, 6, 10));
            Console.WriteLine("Problema 4 (nulls): " + problema4.CalcularPromedio(null, null, null));
            Console.WriteLine("Problema 4 (invalida): " + problema4.CalcularPromedio(8, -1, 10));
        
        
        
        
        
        
        

// dentro del Main:
var problema5 = new ImporteHelper();
var retail = new RetailSale(1000m);
var wholesale = new WholesaleSale(1000m);
Console.WriteLine("Problema 5 Retail: " + problema5.ObtenerImporteFinal(retail));
Console.WriteLine("Problema 5 Wholesale: " + problema5.ObtenerImporteFinal(wholesale));
        }
    }


}