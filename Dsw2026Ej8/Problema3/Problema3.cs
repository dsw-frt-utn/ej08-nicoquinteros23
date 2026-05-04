namespace Dsw2026Ej8.Problema3
{
    public class CopiaHelper
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int copia = originalValue;
            copia++;

            Product productoCopia = product;
            productoCopia.UpdateDescription("Descripcion modificada");

            return $"{originalValue}-{copia}-{product.Description}";
        }
    }
}