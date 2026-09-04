using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using FeriadosChileNet5.Models;

namespace FeriadosChileNet5.Services
{
    public class FeriadosService : IFeriadosService
    {
        private readonly HttpClient _httpClient;
        private const string Url = "https://api.victorsanmartin.com/feriados/en.json";

        public FeriadosService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Feriado>> ObtenerFeriadosAsync()
        {
            var response = await _httpClient.GetAsync(Url);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var resultado = JsonSerializer.Deserialize<FeriadosResponse>(json, options);
            return resultado?.Data ?? new List<Feriado>();
        }
    }
}
