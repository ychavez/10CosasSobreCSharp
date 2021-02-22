using System;

namespace _10CosasSobreCSharp
{
    public class FuncionesLocales
    {

        public static void Run()
        {

            var numeroPotencia = Potenciar(2, 3);
            Console.WriteLine(numeroPotencia);
        }

        public static int Potenciar(int numero, int potencia)
        {
            int resultado = numero;

            for (int i = 0; i < potencia - 1; i++)
            {
                resultado = Multiplicar(numero);
            }
            return resultado;
            
            int Multiplicar(int _numero) => _numero * resultado;
            
        }
    }
}