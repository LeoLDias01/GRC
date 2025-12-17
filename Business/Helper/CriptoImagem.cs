
using System;
using System.Drawing;
using System.IO;
using static System.Net.Mime.MediaTypeNames;


namespace Business.Helper
{
    public static class CriptoImagem
    {
        public static string ImagemParaBase64(string caminhoArquivo)
        {
            if (string.IsNullOrEmpty(caminhoArquivo) || !File.Exists(caminhoArquivo))
                return string.Empty;

            // Lê o arquivo da imagem como bytes
            byte[] imageBytes = File.ReadAllBytes(caminhoArquivo);

            // Converte para base64
            return Convert.ToBase64String(imageBytes);
        }
        public static System.Drawing.Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);

            ImageConverter converter = new ImageConverter();
            System.Drawing.Image img = (System.Drawing.Image)converter.ConvertFrom(imageBytes);

            return new Bitmap(img); // Garante que a imagem seja independente
        }

    }
}


