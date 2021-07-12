using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            BolsaValores b1 = new BolsaValores();
            b1.nomeCIA = "Petrobras";
            b1.tipo = "BVMF";
            b1.areaAct = "Energia";
            b1.valorAcao = 29.49;
            b1.valorAnterior = 32.10;
            b1.variacaoHoje = 0.023;

            BolsaValores b2 = new BolsaValores();
            b2.nomeCIA = "ExxonMobil";
            b2.tipo = "NYSE";
            b2.areaAct = "Energia";
            b2.valorAcao = 79.12;
            b2.valorAnterior = 79.40;
            b2.variacaoHoje = 0.0073;

            BolsaValores b3 = new BolsaValores();
            b3.nomeCIA = "Facebook";
            b3.tipo = "NASDAQ";
            b3.areaAct = "Tecnologia";
            b3.valorAcao = 65.12;
            b3.valorAnterior = 65.72;
            b3.variacaoHoje = 0.092;




            Console.WriteLine("Companhia: "+ b1.nomeCIA);
            Console.WriteLine("Tipo da Bolsa: "+b1.tipo);
            Console.WriteLine("Atuaçao da companhia: "+b1.areaAct);
            Console.WriteLine("Valor: {0:C} ", b1.valorAcao);
            Console.WriteLine("Valor anterior: {0:C}", b1.valorAnterior);
            Console.WriteLine("Variaçao hoje: {0:P}", b1.variacaoHoje);

            
            BolsaValores[] acoes1 = new BolsaValores[3];
            acoes1[0] = b1;
            acoes1[1] = b2;
            acoes1[2] = b3;
            /*
            BolsaValores[] acoes1 = new BolsaValores[3];
            for(int i = 0; i < 3; i++)
            {
                Console.Write("Digite o nome da companhia:");
                acoes[i].nomeCIA  = Console.ReadLine();
                Console.Write("Digite o tipo de bolsa:");
                acoes[i].tipo = Console.ReadLine();
                Console.Write("Digite a area de atuacao:");
                acoes[i].areaAct = Console.ReadLine();
                Console.Write("Digite o valor da acao: ");
                acoes[i].valorAcao = double.Parse(Console.ReadLine());
                Console.Write("Digite o valor anterior: ");
                acoes[i].valorAnterior = double.Parse(Console.ReadLine());
                Console.Write("Digite a variacao (positiva ou negativa): ");
                acoes[i].variacaoHoje = double.Parse(Console.ReadLine());
            }
            */

            double valor;
            Console.WriteLine("Digite um valor:");
            valor = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("====Açoes e empresas abaixo desse valor====");
            for(int i = 0; i < acoes1.Length; i++)
            {
                if(valor >= acoes1[i].valorAcao)
                {
                    Console.WriteLine("Companhia: " + acoes1[i].nomeCIA);
                    Console.WriteLine("Tipo da Bolsa: " + acoes1[i].tipo);
                    Console.WriteLine("Atuaçao da companhia: " + acoes1[i].areaAct);
                    Console.WriteLine("Valor: {0:C} ", acoes1[i].valorAcao);
                    Console.WriteLine("Valor anterior: {0:C}", acoes1[i].valorAnterior);
                    Console.WriteLine("Variaçao hoje: {0:P}", acoes1[i].variacaoHoje);
                    Console.WriteLine("");
                }
            }


            // Media dos preços das ações
            double soma = 0, totalDesvios = 0 ;
            double media,variancia, desvioPadrao;

            for (int i = 0; i < acoes1.Length; i++)
            {
                soma += acoes1[i].valorAcao;
            }

            media = soma / acoes1.Length;

            Console.WriteLine("Média dos valores das açoes: " + media);

            //variancia e Desvio Padrão
            for (int i = 0; i < acoes1.Length; i++)
            {
                totalDesvios += Math.Pow((acoes1[i].valorAcao - media), 2);
            }
            variancia = totalDesvios / acoes1.Length;

            desvioPadrao = Math.Sqrt(variancia);

            Console.WriteLine("Desvio padrao: "+ desvioPadrao);
            Console.WriteLine("");
            /*Console.Write("Digite um novo valor para todas acoes: ");
            double novoValor = double.Parse(Console.ReadLine());
            for(int i = 0; i < acoes1.Length; i++)
            {
                acoes1[i].valorAcao = novoValor;
                if(acoes1[i].valorAnterior < acoes1[i].valorAcao)
                {
                    acoes1[i].variacaoHoje = (acoes1[i].valorAcao/acoes1[i].valorAnterior)- 1;
                }
                else
                {
                    acoes1[i].variacaoHoje = 1 - (acoes1[i].valorAnterior/acoes1[i].valorAcao) ;
                }
            }

            for(int i = 0; i < acoes1.Length; i++)
            {
                Console.WriteLine("Companhia: " + acoes1[i].nomeCIA);
                Console.WriteLine("Tipo da Bolsa: " + acoes1[i].tipo);
                Console.WriteLine("Atuaçao da companhia: " + acoes1[i].areaAct);
                Console.WriteLine("Valor: {0:C} ", acoes1[i].valorAcao);
                Console.WriteLine("Valor anterior: {0:C}", acoes1[i].valorAnterior);
                Console.WriteLine("Variaçao hoje: {0:P}", acoes1[i].variacaoHoje);
                Console.WriteLine("");
            }*/

            for(int i = 0; i < acoes1.Length; i++)
            {
                BolsaValores aux;
                for(int j = 0; j< acoes1.Length; j++)
                {
                    if(acoes1[i].valorAcao < acoes1[j].valorAcao)
                    {
                        aux = acoes1[i];
                        acoes1[i] = acoes1[j];
                        acoes1[j] = aux;

                    }
                }
            }

            for (int i = 0; i < acoes1.Length; i++)
            {
                Console.WriteLine("Companhia: " + acoes1[i].nomeCIA);
                Console.WriteLine("Tipo da Bolsa: " + acoes1[i].tipo);
                Console.WriteLine("Atuaçao da companhia: " + acoes1[i].areaAct);
                Console.WriteLine("Valor: {0:C} ", acoes1[i].valorAcao);
                Console.WriteLine("Valor anterior: {0:C}", acoes1[i].valorAnterior);
                Console.WriteLine("Variaçao hoje: {0:P}", acoes1[i].variacaoHoje);
                Console.WriteLine("");
            }
        }
    }
}
