namespace Dsw2026Ej8.Problema1
{
    public partial class ProductHelper
    {
        private const string CurrencyFormat = "C";

        private string FormatPrice(decimal price)
        {
            return price.ToString(CurrencyFormat);
        }
    }
}