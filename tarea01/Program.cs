﻿using System;

namespace tarea01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 6;
            double num3 = 2.57;
            double suma;
            suma = num1 + num3;

            Console.WriteLine(suma);
            string valor = Console.ReadLine();
            Console.WriteLine("El numero introducido es: " + valor);
            int valorint = Convert.ToInt32(valor);

            Console.ReadKey();
        }
    }
}
