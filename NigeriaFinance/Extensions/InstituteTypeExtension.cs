using NigeriaFinance.Enums;

namespace NigeriaFinance.Extensions
{
    public static class InstituteTypeExtension
    {
        public static string ToStringValue(this InstituteType type)
        {
            switch (type)
            {
                case InstituteType.Bank:
                    return "Banks.min.json";
                case InstituteType.PensionFund:
                    return "Pensionfunds.min.json";
                default:
                    return "";
            }
        }
    }
}
