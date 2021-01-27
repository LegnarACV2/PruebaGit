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

            Console.Write("Ingrese el primer numero");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero");
            num2 = int.Parse(Console.ReadLine());

            resultado = num1 + num2;

            Console.WriteLine("La suma de los numeros es: " + resultado);
        }
    }
}
