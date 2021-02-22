

using System;
using System.Collections.Generic;

namespace _10CosasSobreCSharp
{
    public class YieldReturn
    {

        public static void Run()
        {
            foreach (var numero in NumerosAleatorios(30))
            {
                Console.WriteLine(numero);
            }
        }

        public static IEnumerable<int> NumerosAleatorios(int cuenta)
        {
            for (int i = 0; i < cuenta; i++)
            {
              yield return  new Random().Next();
            } 
        }
    }
}