using Dsw2026Ej8.Problema1;

using Dsw2026Ej8.Problema2;

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

            var problema2 = new ResumenVentaHelper();            string resumen = problema2.CrearResumenVenta(2001, "Banana", 5, 100m);
            Console.WriteLine("Problema 2: " + resumen);

            string resumenCero = problema2.CrearResumenVenta(2002, "Pera", 0, 100m);
            Console.WriteLine("Problema 2 (qty 0): " + resumenCero);

        }
    }


 }