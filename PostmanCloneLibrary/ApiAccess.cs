using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PostmanCloneLibrary
{
    public class ApiAccess
    {
        private readonly HttpClient _httpClient = new();

        public async Task<string> CallApiAsync(string url, bool normalizeOutput = true)
        {
          var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();

                if (normalizeOutput)
                {
                    var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);

                    string normalizedJson = JsonSerializer.Serialize(jsonElement, 
                        new JsonSerializerOptions { WriteIndented=true });

                    return normalizedJson;
                }    
                else
                {
                    return json;
                }
            }
            else
            {
                return $"Error: {response.StatusCode}";
            }
        }
    }
}
