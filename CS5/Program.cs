using System;
namespace CS5
{
    class Program
    {
        static void Main(string[] args)
        {
            //unidad 2 funciones
            //Sesion 12 instrucciones while 30092026
            // sintaxis while
            // inicializacion
            // while(expresion)
            // {
            //   Bloque de intrsucciones
            //   iterador;
            // }
            //iterar: repetir

            //Ejemplo 1: ciclo ascendente rango 1-3
            int m = 1; //inicializacion
            while(m <= 3)
            {
                Console.WriteLine($"m: {m}");
                m += 1;
            }


            int a = 1;
            while (a < 6)
            {
                Console.WriteLine("Mauricio");
                a += 1;
            }

            int b = 3;
            while (b > 0)
            {
                Console.WriteLine("bremer");
                b -= 1;
            }
            
            int c = 3;
            while (c <= 18)
            {
                Console.WriteLine($"c: {c}");
                c += 3;
            }

            int d = 16;
            while (d > 0)
            {
                Console.WriteLine("331");
                d -= 2;
            }

            //actividad 1 ciclo infinito
            //ascendente
            int i = 1;
            while (i > 0)
            {
                Console.WriteLine("inf");
                m += 1;
            }

            //descendente
            int desc = 9;
            while(number % 2 != 0)
            {
                Console.WriteLine(desc);
                desc -= 2;

            }

        }
    }
}