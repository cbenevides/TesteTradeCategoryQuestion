using System;
using TradeCategoryQuestion.Interface;

namespace TradeCategoryQuestion.Model
{
    public class Expired : ICategorie
    {
        public bool Calcular(Trade trade)
        {
            throw new NotImplementedException();
        }

        public bool Calcular(Trade trade, DateTime dataReferencia)
        {
            return (trade.NextPaymentDate < dataReferencia.AddDays(-30));
        }
    }
}