using System;

class Program
{
    static int fib(int n)
    {
        if (n <= 1 )
            return n;
        return fib(n - 1) + fib(n - 2);
    }

    static void Main()
    {
        Console.Write("Ingresa un número del Fibonacci: ");
        int n = int.Parse(Console.ReadLine());

        int resul = fib(n);
        Console.WriteLine($"El numero de Fibonacci esta en la posición {n} es: {resul} ");
    }
}