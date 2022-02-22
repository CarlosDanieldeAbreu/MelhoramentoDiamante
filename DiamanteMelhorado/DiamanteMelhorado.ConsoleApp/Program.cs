using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamanteMelhorado.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Diamante de X");
            Console.ResetColor();
            Console.WriteLine("=============");
            int impar = InseriOsDados();
            int quantidadeEspaco, quantidadeInicialDx, quantidadeDLinhas;
            Calculo(impar, out quantidadeEspaco, out quantidadeInicialDx, out quantidadeDLinhas);

            verificaSeOnumeroEhImpar(impar, ref quantidadeEspaco, ref quantidadeInicialDx, quantidadeDLinhas);
        }

        static int InseriOsDados()
        {
            Console.WriteLine("Informe um número ímpar:");
            string strImpar = Console.ReadLine();
            int impar = Convert.ToInt32(strImpar);
            return impar;
        }

        static void Calculo(int impar, out int quantidadeEspaco, out int quantidadeInicialDx, out int quantidadeDLinhas)
        {
            quantidadeEspaco = (impar - 1) / 2;
            quantidadeInicialDx = 1;
            quantidadeDLinhas = (impar - 1) / 2;
        }

        static void verificaSeOnumeroEhImpar(int impar, ref int quantidadeEspaco, ref int quantidadeInicialDx, int quantidadeDLinhas)
        {
            if (impar % 2 == 1)
            {
                EscreveAparteSuperiorDoDiamante(ref quantidadeEspaco, ref quantidadeInicialDx, quantidadeDLinhas);
                EscreveAparteDoMeioDoDiamante(impar, ref quantidadeEspaco, ref quantidadeInicialDx);
                EscreveAparteInferiorDoDiamante(ref quantidadeEspaco, ref quantidadeInicialDx, quantidadeDLinhas);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Seu número não e ímpar");
            }
        }

        static void EscreveAparteInferiorDoDiamante(ref int quantidadeEspaco, ref int quantidadeInicialDx, int quantidadeDLinhas)
        {
            for (int linhas = 0; linhas < quantidadeDLinhas; linhas++)
            {
                for (int Y = 0; Y < quantidadeEspaco; Y++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < quantidadeInicialDx; j++)
                {
                    Console.Write("X");
                }
                quantidadeEspaco++;
                quantidadeInicialDx -= 2;
                Console.WriteLine("");
            }
        }

        static void EscreveAparteDoMeioDoDiamante(int impar, ref int quantidadeEspaco, ref int quantidadeInicialDx)
        {
            for (int linhas = 0; linhas < impar; linhas++)
            {
                Console.Write("X");
            }
            quantidadeEspaco++;
            quantidadeInicialDx -= 2;

            Console.ReadLine();
        }

        static void EscreveAparteSuperiorDoDiamante(ref int quantidadeEspaco, ref int quantidadeInicialDx, int quantidadeDLinhas)
        {
            for (int linhas = 0; linhas < quantidadeDLinhas; linhas++)
            {
                for (int Y = 0; Y < quantidadeEspaco; Y++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < quantidadeInicialDx; j++)
                {
                    Console.Write("X");
                }

                quantidadeEspaco--;
                quantidadeInicialDx += 2;
                Console.WriteLine("");
            }
        }
    }
}
