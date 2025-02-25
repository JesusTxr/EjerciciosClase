using System;

namespace practica1
{
    class Program
    {
        static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número para calcular el factorial");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El factorial de " + n + " es: " + Factorial(n));
        }
    }
}