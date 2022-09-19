using System;
using TradeCategoryQuestion.Interface;

namespace TradeCategoryQuestion.Model
{
    public class MediumRisk : ICategorie
    {
        private const string _setor = "Public";

        public bool Calcular(Trade trade)
        {
            return (trade.Value > 1000000 && trade.ClientSector.Equals(_setor));
        }

        public bool Calcular(Trade trade, DateTime dataReferencia)
        {
            throw new NotImplementedException();
        }
    }
}