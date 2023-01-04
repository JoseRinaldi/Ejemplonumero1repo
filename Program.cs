using System;

namespace unit8ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vacu = new int[15];
            int na, cv, max, p;

            for (int x = 0; x < 15; x++)
            {
                vacu[x] = 0;
            }

            Console.WriteLine("ingrese el numero de articulo:");
            na = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la cantidad vendida:");
            cv = int.Parse(Console.ReadLine());

            while (na != 0)
            {
                vacu[na - 1] += cv;

                Console.WriteLine("ingrese el numero de articulo:");
                na = int.Parse(Console.ReadLine());

                Console.WriteLine("ingrese la cantidad vendida:");
                cv = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("la cantidad vendida en el articulo 10 es: " + vacu[9]);
            
            for (int x = 0; x < 15; x++)
            {
                if(vacu[x] == 0){
                    Console.WriteLine("los numeros de articulos no vendidos son: " + (x + 1));
                }
            }

            max = vacu[0];
            p = 1;

            for (int x = 0; x < 15; x++)
            {
                if(vacu[x] > max){
                    max = vacu[x];
                    p = x + 1;

                }
            }

            Console.WriteLine("el articulo mas vendido es: " + p + "cantidad " + max);


        }
    }
}
