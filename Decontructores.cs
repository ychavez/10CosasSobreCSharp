using System;

namespace _10CosasSobreCSharp
{
    public class Decontructores
    {
        public static void Rund()
        {  var coordenadas = new Coordenadas();
           var (x,y) = coordenadas;

           Console.WriteLine($"{x} {y}");
        }

    }

    public class Coordenadas
    {
        public int X = 1, Y = 2;

        public void Deconstruct(out int x,out int y){
           x = X; y=Y;

        }
    }


}