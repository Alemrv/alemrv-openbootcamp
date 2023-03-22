using System;

namespace alemrv_openbootcamp
{
    internal class intro_EC3
    {
        static void Main(string[] args)
        {
            //Resultado Ejercicio 1 Clase 3
            Console.WriteLine(suma1(1, 2, 3));

            //Resultado Ejercicio 2 Clase 3
            Coche miCoche = new Coche();
            miCoche.incrementar();
            Console.WriteLine(miCoche.puertas);
        }

        private static int suma1(int a, int b, int c)
        {
            return a + b + c;
        }
    } 
    public class Coche
    {
        public int puertas = 4;

        public void incrementar()
        {
            this.puertas++;
        }
    }    
}