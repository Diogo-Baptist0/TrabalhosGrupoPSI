using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabGrupoM17C_Pert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Insira um número");
                vetor[i] = int.Parse(Console.ReadLine());

            }

            int maior = vetor[0];
            int indice = 0;
            //Console.WriteLine("maior {0}.", maior);
            //Console.WriteLine("indice {0}.", indice);
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] > maior)
                {
                    maior = vetor[i];
                    indice = i;

                }
            }
            Console.WriteLine("Maior valor {0} e o indice{0}. ", maior, indice);
            Console.ReadKey();
        }
    }
}