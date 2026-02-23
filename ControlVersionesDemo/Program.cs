using System;

namespace ControlVersionesDemo
{
    public class Calculadora
    {
        public int Sumar(int a, int b)
        {
            return a + b;
        }

        public int Restar(int a, int b)
        {
            return a - b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.WriteLine("=== Demostración de Control de Versiones ===");
            Console.WriteLine($"Suma (5 + 3): {calc.Sumar(5, 3)}");
            Console.WriteLine($"Resta (10 - 4): {calc.Restar(10, 4)}");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}