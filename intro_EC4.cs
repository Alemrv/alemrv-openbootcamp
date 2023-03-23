using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alemrv__openbootcamp
{
    internal class intro_EC4
    {
        static void Main(string[] args)
        {
            //Resultado Ejercicio 1 Clase 4
            int numeroIF = -1;
            Console.WriteLine("Resultado Ejecicio 1:");
            condicionIF(numeroIF);

            //Resultado Ejercicio 2 Clase 4
            Console.WriteLine("Resultado Ejecicio 2:");

            int variableWhile = 0;

            bucleWhile(variableWhile);

            //Resultado Ejercicio 3 Clase 4
            Console.WriteLine("Resultado Ejecicio 3:");

            int variableDowhile = 0;
            bucleDoWhile(variableDowhile);

            //Resultado Ejercicio 4 Clase 4
            Console.WriteLine("Resultado Ejecicio 4:");
            bucleFor();

            //Resultado Ejercicio 4 Clase 4
            Console.WriteLine("Resultado Ejecicio 5:");
            condicionSwitch("primavera");
        }

        public static void condicionIF(int a)
        {
            
            if (a == 0)
            {
                Console.WriteLine("la variable es igual a 0");
            }
            else if (a > 0) 
            {
                Console.WriteLine("la variable es mayor a 0");
            }
            else
            {
                Console.WriteLine("la variable es menor a 0");
            }
        }

        public static void bucleWhile(int numeroWhile)
        {
            while (numeroWhile < 3 )
            {
                numeroWhile++;
                Console.WriteLine(numeroWhile);
            }
        }

        public static void bucleDoWhile(int numeroDoWhile)
        {
            do
            {
                numeroDoWhile++;
                Console.WriteLine(numeroDoWhile);

            } while (numeroDoWhile > 3);
        }

        public static void bucleFor()
        {
            for (int numeroFor = 0; numeroFor <= 3; numeroFor++)
            {
                Console.WriteLine(numeroFor);
            }
        }

        public static void condicionSwitch(string a)
        {

            switch (a)
            {
                case "primavera":
                    Console.WriteLine("es primavera");
                    break;
                case "verano":
                    Console.WriteLine("es verano");
                    break;
                case "otoño":
                    Console.WriteLine("es otoño");
                    break;
                case "invierno":
                    Console.WriteLine("es invierno");
                    break;
                default:
                    Console.WriteLine("no ha ingresado una estacion");
                    break;
            }
        }
    }
}
