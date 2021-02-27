using System;

namespace _10CosasSobreCSharp
{
    public class ExplLambdaAction
    { const string MENSAJE = "Esto fue un";
        public static void Run(int numero) => ImprimirMensaje((numero > 10)
            ? (Action<string>)(s => System.Console.WriteLine($"{s} numero grande."))
             : (Action<string>)(s => System.Console.WriteLine($"{s} numero pequeño.")));


        public static void ImprimirMensaje(Action<string> mensaje) =>
            mensaje(MENSAJE);
        

    }
}