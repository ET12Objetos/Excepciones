using System;

namespace Excepciones_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int saldo = 1000;
            int dinero = 2000;
            if (saldo - dinero < 0)
            {
                //Crear una excepcion

                //Exception excepcion = new Exception("Fondos insuficientes");
                //throw excepcion;

                //o 

                throw new Exception("Fondos insuficientes");
            }
        }
    }
}
