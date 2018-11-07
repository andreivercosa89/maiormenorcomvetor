using System;

namespace maiormenorcomvetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = 0, menor = 999999;

            Console.WriteLine("Informe uma quantidade: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int [quantidade];

            for (int i = 0; i < quantidade;i++){
                Console.WriteLine("Informe um numero: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }


            for (int i = 0; i < quantidade; i++)
            {

                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
                else if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }

            }

            Console.Write("Maior: {0}\nMenor: {1}",maior, menor);

        }
    }
}
