using System;
using static System.Console;
namespace _10CosasSobreCSharp
{
    public class Tuplas_old
    {
        static Tuple<double, double> SumarYMultiplicar(double a, double b)
        {

            return Tuple.Create(a + b, a * b);
        }

        public static void Run()
        {
            var resultado = SumarYMultiplicar(3, 6);

            WriteLine(resultado);

            WriteLine($" Suma = {resultado.Item1} Multiplicacion = {resultado.Item2}");
        }
    }

    public class Tuplas_Nuevo
    {
        static (double suma, double multiplicacion) SumarYMultiplicar(double a, double b)
        {
            return (a + b, a * b);
        }


        public static void Run()
        {

            var resultado = SumarYMultiplicar(3, 6);

            WriteLine(resultado);

           WriteLine($" Suma = {resultado.suma} Multiplicacion = {resultado.multiplicacion}");

            var (suma, multiplicacion) = SumarYMultiplicar(4,5);
           WriteLine($" Suma = {suma} Multiplicacion = {multiplicacion}");


            (double ss, double mm) = SumarYMultiplicar(6,7);
            WriteLine($" Suma = {ss} Multiplicacion = {mm}");


            var snp = new Func<double,double,(double suma, double multiplicacion)>((x,y)=> (x+y,x*y));

            var lambdaResult = snp(8,9);

           WriteLine($" Suma = {lambdaResult.suma} Multiplicacion = {lambdaResult.multiplicacion}");


           var yo = (Nombre:"Yael",Edad:28);
           WriteLine(yo);
           WriteLine(yo.GetType());

      

        }

    }

}