namespace Dsw2026Ej8.Problema5
{
    public class ImporteHelper
    {
        public decimal ObtenerImporteFinal(Sale sale)
        {
            return sale.CalculateTotal();
        }
    }
}