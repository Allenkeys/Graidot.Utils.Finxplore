using Graidot.Utils.Finxplore.Enums;

namespace Graidot.Utils.Finxplore.Extensions
{
    public static class InstituteTypeExtension
    {
        public static string ToStringValue(this InstituteType type)
        {
            switch (type)
            {
                case InstituteType.CommercialBank:
                    return "https://raw.githubusercontent.com/Allenkeys/NigeriaFinancialInstitutes/main/Institutes/Banks.min.json";
                case InstituteType.MicroFinanceBank:
                    return "https://raw.githubusercontent.com/Allenkeys/NigeriaFinancialInstitutes/main/Institutes/Microfinance.min.json";
                case InstituteType.PensionFund:
                    return "https://raw.githubusercontent.com/Allenkeys/NigeriaFinancialInstitutes/main/Institutes/Pensionfunds.min.json";
                default:
                    return "";
            }
        }
    }
}
