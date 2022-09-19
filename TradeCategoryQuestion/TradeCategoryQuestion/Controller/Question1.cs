using System;
using System.Collections.Generic;
using TradeCategoryQuestion.Enum;
using TradeCategoryQuestion.Model;

namespace TradeCategoryQuestion.Controller
{
    class Question1
    {
        public List<string> Calcular(List<Trade> lista, DateTime dataReferencia)
        {
            try
            {
                List<string> retorno = new List<string>();

                foreach (var a in lista)
                {
                    if (new Expired().Calcular(a, dataReferencia))
                        retorno.Add(EnumRetorno.EXPIRED.ToString());

                    if (new HighRisk().Calcular(a))
                        retorno.Add(EnumRetorno.HIGHRISK.ToString());
                    
                    if (new MediumRisk().Calcular(a))
                        retorno.Add(EnumRetorno.MEDIUMRISK.ToString());
                }

                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}