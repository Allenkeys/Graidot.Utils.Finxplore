using NigeriaFinance.Enums;
using NigeriaFinance.Extensions;
using NigeriaFinance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace NigeriaFinance.Utilities
{
    public class FinanceInstituteServices
    {
        internal async Task<IEnumerable<InstituteResponse>> GetInstitutesAsync(InstituteType type)
        {
            return await GetObject(type.ToStringValue());

        }

        internal async Task<InstituteResponse> GetInstituteAsync(InstituteType type, int instituteId)
        {
            return (await GetObject(type.ToStringValue())).SingleOrDefault(x => x.Id == instituteId);
        }

        private async Task<IEnumerable<InstituteResponse>> GetObject(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                return Enumerable.Empty<InstituteResponse>();

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://raw.githubusercontent.com/Allenkeys/NigeriaFinancialInstitutes/main/Institutes/");
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
                    };

                    return JsonSerializer.Deserialize<IEnumerable<InstituteResponse>>(await response.Content.ReadAsStringAsync(), options);

                }
                catch (HttpRequestException e)
                {
                    return Enumerable.Empty<InstituteResponse>();
                }
                catch (JsonException e)
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
