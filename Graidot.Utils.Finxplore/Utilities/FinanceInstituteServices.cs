using Graidot.Utils.Finxplore.Enums;
using Graidot.Utils.Finxplore.Extensions;
using Graidot.Utils.Finxplore.Models;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections.Generic;

namespace Graidot.Utils.Finxplore.Utilities
{
    public class FinanceInstituteServices
    {
        private readonly HttpClient _httpClient;

        public async Task<IEnumerable<InstituteResponse>> GetInstitutes(InstituteType type)
        {
            return await GetObject(type.ToStringValue());
           
        }

        public async Task<InstituteResponse> GetInstitute(InstituteType type, int instituteId)
        {
            return (await GetObject(type.ToStringValue())).SingleOrDefault(x => x.Id == instituteId);
        }

        private async Task<IEnumerable<InstituteResponse>> GetObject(string fileName)
        {
            if(string.IsNullOrWhiteSpace(fileName))
                return Enumerable.Empty<InstituteResponse>();

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(fileName);
                    if (!response.IsSuccessStatusCode)
                    {
                        return Enumerable.Empty<InstituteResponse>();
                    }

                    JsonSerializerOptions options = new JsonSerializerOptions
                    {
                        AllowTrailingCommas = true,
                        IncludeFields = true,
                        PropertyNameCaseInsensitive = true,
                        WriteIndented = true,
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    };

                    return JsonSerializer.Deserialize<IEnumerable<InstituteResponse>>(await response.Content.ReadAsStringAsync(), options);

                }
                catch (HttpRequestException e)
                {
                    return Enumerable.Empty<InstituteResponse>();
                }
                catch(JsonException e)
                {
                    return Enumerable.Empty<InstituteResponse>();
                }
                catch 
                {
                    return Enumerable.Empty<InstituteResponse>();
                }
            }
        }
    }
}
