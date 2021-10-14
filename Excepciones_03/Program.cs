using System;
using System.Collections.Generic;
using System.Linq;

namespace Excepciones_03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5 };

            try
            {
                int resultado = numeros.First(x => x > 10);
                Console.WriteLine($"Resultado: {resultado}");
            }
            catch(Exception exception)
            {
                Console.WriteLine($"No es posible obtener el elemente buscado, {exception.Message}, {exception.StackTrace}");
                throw exception;
            }
        }
    }
}
