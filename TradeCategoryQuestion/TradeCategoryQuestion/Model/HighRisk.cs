using System;
using TradeCategoryQuestion.Interface;

namespace TradeCategoryQuestion.Model
{
    public class HighRisk : ICategorie
    {
        private const string _setor = "Private";

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