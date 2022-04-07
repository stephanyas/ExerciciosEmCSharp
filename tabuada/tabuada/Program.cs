using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            //int colunaEsquerda;
            //int colunaDireita;

            //for(colunaEsquerda = 1; colunaEsquerda <= 10; colunaEsquerda ++)
            //{
            //    for(colunaDireita = 1; colunaDireita <= 10; colunaDireita++)
            //    {
            //        Console.WriteLine(colunaEsquerda + " X " + colunaDireita + " = " + colunaEsquerda * colunaDireita);
            //    }
            //    Console.WriteLine();
            //}

            Console.WriteLine("Qual taboada você gostaria de ver?");
            
            int indiceTab;
            int valorSelecionado = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine();

            for (indiceTab = 1; indiceTab <= 10; indiceTab++)
            {
                Console.WriteLine(valorSelecionado + " X " + indiceTab + " = " + valorSelecionado * indiceTab);
            }
        }
    }
}
