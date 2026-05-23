using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Helper
{
    public class Identidade
    {
        /// <summary>
        /// Remove pontos, traços e barras de uma string (CPF, CNPJ, Inscrição Estadual).
        /// Mantém letras e espaços para não quebrar buscas por Nome.
        /// </summary>
        public static string RetiraFormatacao(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return string.Empty;

            // Remove as pontuações típicas de máscaras de identidade
            return texto.Replace(".", "").Replace("-", "").Replace("/", "");
        }

        /// <summary>
        /// Aplica a formatação de CPF ou CNPJ com base no tamanho do texto limpo.
        /// </summary>
        public static string FormataIdentidade(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return string.Empty;

            // Garante que o valor está limpo antes de aplicar a máscara
            string textoLimpo = RetiraFormatacao(texto).Trim();

            // Se for CPF (11 dígitos)
            if (textoLimpo.Length == 11)
            {
                return Convert.ToUInt64(textoLimpo).ToString(@"000\.000\.000\-00");
            }
            // Se for CNPJ (14 dígitos)
            else if (textoLimpo.Length == 14)
            {
                return Convert.ToUInt64(textoLimpo).ToString(@"00\.000\.000\/0000\-00");
            }

            // Se não corresponder aos tamanhos padrão (ou for IE), retorna o texto original
            return texto;
        }
    }
}
