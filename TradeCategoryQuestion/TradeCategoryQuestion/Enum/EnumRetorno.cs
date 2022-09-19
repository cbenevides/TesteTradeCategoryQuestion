using System.ComponentModel;

namespace TradeCategoryQuestion.Enum
{
    public enum EnumRetorno
    {
        [Description("Expirado")]
        EXPIRED = 1,

        [Description("Alto Risco")]
        HIGHRISK = 2,

        [Description("Risco Médio")]
        MEDIUMRISK = 3, 
    }
}
