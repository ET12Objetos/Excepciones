using System;
using System.Collections.Generic;
using System.Linq;

namespace Excepciones_01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingrese dividendo: ");
                int dividendo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese un divisor: ");
                int divisor = Convert.ToInt32(Console.ReadLine());
                int division = dividendo / divisor;
                Console.WriteLine($"Resultado: {division}");
            }
            catch(DivideByZeroException ex)
            {
                //capturar la excepcion y procesarla
                Console.WriteLine("Catch: No se puede dividir por cero");
                Console.WriteLine($"Mensaje: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
                throw ex;
            }
            catch (Exception ex)
            {
                //capturar la excepcion y procesarla
                Console.WriteLine("Catch: Excepcion generica");
                Console.WriteLine($"Mensaje: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
                throw ex;
            }
            finally
            {
                Console.WriteLine("Finally: No se pudo realizar la operacion");
            }
        }
    }
}
