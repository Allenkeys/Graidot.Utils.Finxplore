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
                    return "Commercial-Bank";
                case InstituteType.MicroFinanceBank:
                    return "Microfinance-Bank";
                case InstituteType.TrustFund:
                    return "Trust-Fund";
                default:
                    return "";
            }
        }
    }
}
