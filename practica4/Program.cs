using System;

namespace ejercicio4
{
    class Alimento
    {
        public int Dias { get; set; }

        public Alimento(int Dias)
        {
            this.Dias = Dias;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"El consumo total es de: {CalcularConsumo()}kg");
        }

        public int CalcularConsumo()
        {
            int Consumo = 750;
            return Consumo * Dias;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos dias se va de viaje?");
            int Dias = Convert.ToInt32(Console.ReadLine());

            Alimento miAlimento = new Alimento(Dias);

            miAlimento.MostrarInfo();
        }
    }
}