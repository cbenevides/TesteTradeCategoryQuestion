using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TradeCategoryQuestion.Model;

namespace TradeCategoryQuestion.Util
{
    public class Util
    {
        /*
         * Valida Data: Expressão regular para validar a data
         */
        public static bool ValidaData(string data)
        {
            try
            {
                Regex ok = new Regex(@"(\d{2}\/\d{2}\/\d{4})");
                return ok.Match(data).Success;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao validar data! \n" + ex.Message);
            }
        }

        /*
         * Massa para facilitar nos testes
         */
        public static List<Trade> MassaTeste()
        {
            List<Trade> retorno = new List<Trade>();
            Trade r1 = new Trade();
            r1.Value = 2000000;
            r1.ClientSector = "Private";
            r1.NextPaymentDate = new DateTime(2025, 12, 29);
            retorno.Add(r1);

            Trade r2 = new Trade();
            r2.Value = 400000;
            r2.ClientSector = "Public";
            r2.NextPaymentDate = new DateTime(2020, 07, 01);
            retorno.Add(r2);

            Trade r3 = new Trade();
            r3.Value = 5000000;
            r3.ClientSector = "Public";
            r3.NextPaymentDate = new DateTime(2024, 01, 02);
            retorno.Add(r3);

            Trade r4 = new Trade();
            r4.Value = 3000000;
            r4.ClientSector = "Public";
            r4.NextPaymentDate = new DateTime(2023, 10, 26);
            retorno.Add(r4);

            Console.WriteLine("Massa usada");
            foreach (var r in retorno)
            {
                Console.WriteLine($" {r.Value.ToString()} {r.ClientSector.ToString()} {r.NextPaymentDate.ToString()}");
            }

            Console.WriteLine("-----------");
            return retorno;
        }

    }
}