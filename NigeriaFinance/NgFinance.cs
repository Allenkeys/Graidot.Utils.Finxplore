using NigeriaFinance.Enums;
using NigeriaFinance.Models;
using NigeriaFinance.Utilities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NigeriaFinance
{
    public static class NgFinance
    {
        private static readonly FinanceInstituteServices _service;
        static NgFinance()
        {
            _service = new FinanceInstituteServices();
        }
        public static async Task<InstituteResponse> GetInstituteAsync(InstituteType typeId, int instituteId)
        {
            return await _service.GetInstituteAsync(typeId, instituteId);
        }

        public static async Task<IEnumerable<InstituteResponse>> GetInstitutesAsync(InstituteType typeId)
        {
            return await _service.GetInstitutesAsync(typeId);
        }

    }
}
