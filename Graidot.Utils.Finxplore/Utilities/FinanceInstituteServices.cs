using Graidot.Utils.Finxplore.Enums;
using Graidot.Utils.Finxplore.Extensions;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Graidot.Utils.Finxplore.Utilities
{
    public class FinanceInstituteServices
    {
        private readonly HttpClient _httpClient;

        public async Task<object> GetInstitute(InstituteType type)
        {
            return await GetObject(type.ToStringValue());
        }

        private async Task<object> GetObject(string fileName)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(fileName);
                    if (!response.IsSuccessStatusCode)
                    {
                        return Enumerable.Empty<object>();
                    }

                    return await response.Content.ReadAsStringAsync();
                }
                catch (HttpRequestException e)
                {
                    return Enumerable.Empty<object>();
                }
            }
        }
    }
}
