using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beers
{
    class Class2
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 5, 4, 7, 6, 9, 8, 11 };

            var valores = from n in numeros
                          where n % 2 == 0
                          select n;

            foreach (int num in valores)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("-----------");


            numeros[1] = 12;

            foreach (int num in valores)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Ejecucion inmediata");

            //se guardan los resultados como arreglo
            int[] arrayValores = (from n in numeros where n % 2 == 0 select n).ToArray<int>();

            //se guardan los resultados como un list

            List<int> ListValores = (from n in numeros where n % 2 == 0 select n).ToList<int>();

            Console.WriteLine("El arreglo");

            foreach (int num in arrayValores)
            {
                Console.WriteLine(num);
            }

            numeros[0] = 28;
            Console.WriteLine("---------- se actualiza despues de la modificiacion");

            foreach (int num in arrayValores)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("La lista");
            Console.WriteLine("-----------");

            foreach (int num in ListValores)
            {
                Console.WriteLine(num);
            }



        }
    }
}

