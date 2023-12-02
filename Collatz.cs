using System;
using System.Diagnostics.CodeAnalysis;

namespace VT_Extra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            do
            {
                Console.WriteLine("Introduce un numero: ");
                numero = int.Parse(Console.ReadLine());
                Collatz(numero);
            }while (numero<=1);
            
            
        }  

        public static void Collatz(int numero)
        {
            Console.WriteLine(numero);
            if(numero == 1)
            {
                return;
            }

            int siguientenumero;

            if(numero%2==0) 
            {
                siguientenumero = numero / 2;
            }
            else
            {
                siguientenumero = (numero * 3) + 1;
            }

            Collatz(siguientenumero);
        }
        
    }
}