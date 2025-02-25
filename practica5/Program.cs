using System;

namespace ejercicio5
{
    class Aguinaldo
    {
        public double Sueldo { get; set; }
        
        public Aguinaldo(double Sueldo)
        {
            this.Sueldo = Sueldo;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"El aguinaldo es de: {CalcularAguinaldo()}");
        }

        public double CalcularAguinaldo()
        {
            double Aguinaldo = Sueldo*15;
            return Aguinaldo;
        }
    }

    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cual es tu sueldo?");
            double Sueldo = Convert.ToDouble(Console.ReadLine());

            Aguinaldo miAguinaldo = new Aguinaldo(Sueldo);

            miAguinaldo.MostrarInfo();
        }
    }
}