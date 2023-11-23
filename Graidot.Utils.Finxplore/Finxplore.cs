using Graidot.Utils.Finxplore.Enums;
using Graidot.Utils.Finxplore.Models;
using Graidot.Utils.Finxplore.Utilities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Graidot.Utils.Finxplore
{
    public static class Finxplore
    {
        private static readonly FinanceInstituteServices _service;
        static Finxplore()
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
