using Dsw2026Ej8.Problema1;

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
        }
    }
}