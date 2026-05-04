namespace Dsw2026Ej8.Problema4
{
    public class PromedioHelper
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            var notas = new[] { nota1, nota2, nota3 }
                .Where(n => n.HasValue && n.Value >= 0 && n.Value <= 10)
                .Select(n => n!.Value)
                .ToList();

            if (notas.Count == 0) return 0;

            return notas.Average();
        }
    }
}