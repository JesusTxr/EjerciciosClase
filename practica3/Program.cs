using System;

namespace ejercicio3
{
    class Medidor
    {
        public int Inicio { get; set; }
        public int Fin { get; set; }
        public int Consumo { get; set; }

        public Medidor(int Inicio, int Fin, int Consumo)
        {
            this.Inicio = Inicio;
            this.Fin = Fin;
            this.Consumo = Consumo;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"El consumo total es de: {CalcularConsumo()}m3");
        }

        public int CalcularConsumo()
        {
            return (Fin - Inicio)*Consumo;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio de la lectura");
            int Inicio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fin de la lectura");
            int Fin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dias de consumo");
            int Consumo = Convert.ToInt32(Console.ReadLine());

            Medidor miMedidor = new Medidor(Inicio, Fin, Consumo);

            miMedidor.MostrarInfo();
        }
    }
}