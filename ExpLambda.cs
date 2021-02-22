using System;
using System.Linq;

namespace _10CosasSobreCSharp
{
    public class ExpLambda
    {
        public static void Run()
        {
            var palabra = "aabccg";
            Console.WriteLine(PrimerNoRepetidoClassic(palabra));
            Console.WriteLine(PrimerNoRepetido(palabra));
            Console.WriteLine(PrimerNoRepetidoLambda(MisFunciones.GetNoRepetido, palabra));
            Console.WriteLine(PrimerNoRepetidoLambda((x) => x.FirstOrDefault(), palabra));
        }
        public static char PrimerNoRepetidoClassic(string palabra)
        {
            foreach (var c in palabra)
            {
                if (palabra.ToCharArray().Where(x => x == c).Count() == 1)
                    return c;
            }
            return ' ';
        }

        public static char PrimerNoRepetido(string palabra) => MisFunciones.GetNoRepetido(palabra);

        public static char PrimerNoRepetidoLambda(Func<string, char> validacion, string palabra) => validacion(palabra);
    }
    public class MisFunciones
    {
        /// <summary>
        /// obtiene el primer caracter no repetido en una cadena
        /// </summary>
        /// <returns>char de caracter no repetido</returns>
        public static readonly Func<string, char> GetNoRepetido = (s) => s.ToCharArray()
                                                                         .GroupBy(x => x)
                                                                         .Where(x => x.Count() == 1)
                                                                         .Select(x => x.Key).FirstOrDefault();
    }
    
}