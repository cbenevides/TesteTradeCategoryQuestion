using System;
using TradeCategoryQuestion.Model;

namespace TradeCategoryQuestion.Interface
{
    public interface ICategorie
    {
        bool Calcular(Trade trade);

        bool Calcular(Trade trade, DateTime dataReferencia);
    }
}
