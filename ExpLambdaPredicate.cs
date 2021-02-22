using System;

namespace _10CosasSobreCSharp
{
    public class ExpLambdaPredicate
    {
        public static void Run() => Prueba(x => x > 10, 11);
        public static void Prueba(Predicate<int> predicado, int numero) => System.Console.WriteLine(predicado(numero));
    }

}