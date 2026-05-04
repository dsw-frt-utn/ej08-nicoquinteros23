namespace Dsw2026Ej8.Problema6
{
    public class CodigoHelper
    {
        public string NormalizarCodigoProducto(string? code)
        {
            return code.ToProductCode();
        }
    }
}