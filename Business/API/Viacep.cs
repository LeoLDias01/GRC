using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Data.Models;

namespace Business.API
{
    public class Viacep
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public async Task<ViaCepResponse> BuscarEnderecoAsync(string cep)
        {
            try
            {
                cep = cep?.Trim().Replace("-", "");

                if (string.IsNullOrWhiteSpace(cep))
                    throw new ArgumentException("CEP inválido.");

                string url = $"https://viacep.com.br/ws/{cep}/json/";

                var response = await _httpClient.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                    throw new Exception($"Erro ao consultar o CEP: {response.StatusCode}");

                var json = await response.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<ViaCepResponse>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                if (result == null || result.Cep == null)
                    throw new Exception("CEP não encontrado.");

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro na consulta do ViaCEP: {ex.Message}");
            }
        }
    }
}
