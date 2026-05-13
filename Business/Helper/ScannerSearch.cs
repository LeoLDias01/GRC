using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace Business.Helper
{
    public static class ScannerSearch
    {
        // Substitua pelos IDs que o seu leitor apresentar no modo VCP
        private const string TargetVID = "0483";
        private const string TargetPID = "5740";

        public static string LocalizarPortaLeitor()
        {
            try
            {
                // Busca no WMI por dispositivos que o Windows reconhece como Portas COM
                using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption LIKE '%(COM%)'"))
                {
                    foreach (var device in searcher.Get())
                    {
                        string pnpDeviceID = device["PNPDeviceID"]?.ToString() ?? "";
                        string caption = device["Caption"]?.ToString() ?? "";

                        // Verifica se o DNA do hardware (VID/PID) bate com o seu Tomate
                        if (pnpDeviceID.Contains($"VID_{TargetVID}") && pnpDeviceID.Contains($"PID_{TargetPID}"))
                        {
                            // Extrai o nome da porta, ex: "COM3"
                            return ExtrairPortaDaCaption(caption);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log de erro ou tratamento conforme sua necessidade
                System.Diagnostics.Debug.WriteLine("Erro ao escanear portas: " + ex.Message);
            }

            return null;
        }

        private static string ExtrairPortaDaCaption(string caption)
        {
            // A string costuma ser: "USB Serial Port (COM3)"
            int inicio = caption.LastIndexOf("(COM") + 1;
            int fim = caption.LastIndexOf(")");

            if (inicio > 0 && fim > inicio)
            {
                return caption.Substring(inicio, fim - inicio);
            }
            return null;
        }
    }
}
