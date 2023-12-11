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

        /// <summary>
        /// Gets a financial institution. 
        /// Note: The financial institutions depend on the type parameter. 
        /// </summary>
        /// <param name="typeId"> <see cref="InstituteType"/> The type of financial institution</param>
        /// <param name="instituteId"><see cref="int"/> The institution ID</param>
        /// <returns> <see cref="InstituteResponse"/> a financial institution</returns>
        public static async Task<InstituteResponse> GetInstituteAsync(InstituteType typeId, int instituteId)
        {
            return await _service.GetInstituteAsync(typeId, instituteId);
        }

        /// <summary>
        /// Gets a collection of financial institutions. 
        /// Note: These financial institutions depend on the type parameter.
        /// </summary>
        /// <param name="typeId"> <see cref="InstituteType"/> The type of financial institution.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="InstituteResponse"/> of financial institutions</returns>
        public static async Task<IEnumerable<InstituteResponse>> GetInstitutesAsync(InstituteType typeId)
        {
            return await _service.GetInstitutesAsync(typeId);
        }

    }
}
