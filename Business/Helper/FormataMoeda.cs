using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Helper
{
    public static class FormataMoeda
    {
        private static readonly CultureInfo CulturaBrasileira = CultureInfo.GetCultureInfo("pt-BR");

        /// <summary>
        /// Converte um texto monetário ("R$ 1.234,56", "1234,56", "1234.56") em decimal.
        /// </summary>
        public static decimal ConverterTextoParaDecimal(string textoMonetario)
        {
            if (string.IsNullOrWhiteSpace(textoMonetario))
                return 0m;

            // Remove "R$"
            string textoLimpo = textoMonetario.Replace("R$", "").Trim();

            // Normaliza qualquer cenário de ponto/vírgula
            textoLimpo = textoLimpo.Replace(".", "").Replace(",", ".");

            // Tenta converter no formato invariável
            if (decimal.TryParse(
                    textoLimpo,
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture,
                    out var resultado))
                return resultado;

            // Tenta com cultura brasileira como fallback
            if (decimal.TryParse(
                    textoMonetario.Replace("R$", "").Trim(),
                    NumberStyles.Currency,
                    CulturaBrasileira,
                    out resultado))
                return resultado;

            return 0m;
        }

        /// <summary>
        /// Formata um decimal para "R$ 1.234,56".
        /// </summary>
        public static string ConverterDecimalParaTexto(decimal valor)
        {
            return valor.ToString("C2", CulturaBrasileira);
        }
    }
}
