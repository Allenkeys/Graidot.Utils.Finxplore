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
                    return "https://raw.githubusercontent.com/Chidiebube-Onah/BanksInNigeria/main/BanksInNigeria.min.json";
                case InstituteType.MicroFinanceBank:
                    return "Microfinance-Bank";
                case InstituteType.TrustFund:
                    return "https://raw.githubusercontent.com/Allenkeys/NigeriaFinancialInstitutes/main/Institutes/Trustfunds.min.json";
                default:
                    return "";
            }
        }
    }
}
