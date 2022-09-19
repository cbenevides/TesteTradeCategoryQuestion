using System;
using System.Collections.Generic;
using TradeCategoryQuestion.Controller;
using TradeCategoryQuestion.Model;

namespace TradeCategoryQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------TESTE-------------");

            //Para Testar usar massa. Descomentar linhas 15 e 16; e comentar linhas 17 e 18
            //DateTime dataReferencia = new DateTime(2022, 11, 12);
            //List<Trade> interacao = Util.Util.MassaTeste();
            DateTime dataReferencia = InteracaoUsuarioData();
            List<Trade> interacao = InteracaoUsuario();

            //Realiza o Calculo Question 1
            List<string> lista = new Question1().Calcular(interacao, dataReferencia);

            //Mostra o resultado
            foreach (var a in lista)
            {
                Console.WriteLine(a.ToString());
            }

            Console.ReadLine();
        }

        private static DateTime InteracaoUsuarioData()
        {
            try
            {
                Console.WriteLine("Informe data referência (mm/dd/aaaa)");
                string data = Console.ReadLine();
                if (Util.Util.ValidaData(data) == false)
                {
                    Console.WriteLine("Favor informar data válida!");
                }
                return Convert.ToDateTime(data);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter data! \n" + ex.Message);
            }
        }

        private static List<Trade> InteracaoUsuario()
        {
            Console.WriteLine("Informe quantidade");
            string quantidade = Console.ReadLine();

            List<Trade> lista = new List<Trade>();
            int cont = Convert.ToInt32(quantidade);

            for (int contador = 1; contador <= cont; contador++)
            {
                Console.WriteLine($"[ {contador.ToString()} ] - Favor informar Valor, Setor e Data (mm/dd/aaaa)!");
                var linhaDigitada = Console.ReadLine().Split(' ');

                Trade t = new Trade()
                {
                    Value = Convert.ToInt32(linhaDigitada[0]),
                    ClientSector = linhaDigitada[1].ToString(),
                    NextPaymentDate = Convert.ToDateTime(linhaDigitada[2]),
                };

                lista.Add(t);
            }

            return (lista);
        }
    }
}