﻿using System;

namespace maiormenorcomvetor
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe uma quantidade: ");
            double quantidade = Convert.ToInt32(Console.ReadLine());

            double[] numeros = new double [Convert.ToInt32(quantidade)];

            for (int i = 0; i < quantidade;i++){
                Console.WriteLine("Informe um numero: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(numeros);//ordenar do menor para o maior

            Console.Write("Maior: {0}\nMenor: {1}", numeros[0], numeros[numeros.Length-1]);
        }
    }
}
