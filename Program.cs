using System;

namespace PruebaGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Prueba Con GitHub");
            Console.WriteLine("Que funcione");
            Console.WriteLine("Hola Mundo");

            int num1;
            int num2;
            double resultado;

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            resultado = num1 + num2;

            Console.WriteLine("La suma de los numeros es: " + resultado);
        }
    }
}
