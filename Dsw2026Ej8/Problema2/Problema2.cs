namespace Dsw2026Ej8.Problema2
{
    public class ResumenVentaHelper
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            decimal total = quantity > 0 ? quantity * unitPrice : 0;

            var venta = new
            {
                Code = productCode,
                Description = productDescription,
                Quantity = quantity,
                Total = total
            };

            return $"{venta.Code}-{venta.Description}-{venta.Total}";
        }
    }
}