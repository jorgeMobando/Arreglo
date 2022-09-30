using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, tp = 0, pt = 0, par = 0;
            int[] numeros;

            Console.Write("Digite la cantidad de numeros que desea ingresar: ");
            tp = int.Parse(Console.ReadLine());
            numeros = new int[tp];

            for (int x = 0; x < tp; x++)
            {

                Console.WriteLine("\nIngrese el numero {0}", x + 1);
                numeros[x] = int.Parse(Console.ReadLine());
            }

            foreach (int x in numeros)
            {
                if (x % 2 == 0)
                {
                    par++;
                }
            }

            for (int i = 1; i < tp; i++)
            {
                for (int p = 0; p < tp - 1; p++)
                {
                    if (numeros[p] > numeros[i])
                    {
                        pt = numeros[i];
                        numeros[i] = numeros[p];
                        numeros[p] = pt;
                    }

                }

            }

            Array.Reverse(numeros);

            Console.WriteLine("La cantidad de numeros pares es: ");
            Console.WriteLine(par.ToString());

            Console.WriteLine("\nLos mumeros que digitó, se presentan ahora en una organizacion de  mayor a menor\n");

            for (int y = 0; y < numeros.Length; y++)
            {
                Console.Write(numeros[y].ToString() + " - ");

            }

            Console.ReadKey();

        }


    }
}
