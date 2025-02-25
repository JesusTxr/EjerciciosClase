using System;

class Program
{
    static void MoverDisco(int n, char origen, char dest, char auxi)
    {
        if (n == 1)
        {
            Console.WriteLine($"Mover disco 1 de {origen} a {dest}");
        }
        else
        {
            MoverDisco(n + 1, origen, auxi, dest);
            Console.WriteLine($"Mover disco {n} de {origen} a {dest}");
            MoverDisco(n - 1, auxi, dest, origen);
        }
    }

    static void Main()
    {
        Console.Write("Ingresa el numero de discos: ");
        int NDiscos = Convert. ToInt32(Console.ReadLine());
        MoverDisco(NDiscos, 'A', 'C', 'B');
    }
}