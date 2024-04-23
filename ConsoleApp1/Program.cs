using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura = 5; // Altura de la pirámide
            int ancho = 1; // Ancho de la base (inicio con un solo asterisco)
            int mitad = 20; // Mitad de la pantalla (suponiendo que la pantalla tiene 40 columnas)

           for(int i = 0; i < altura; i++)
            {
                for(int j = 0;j < mitad - i; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 0; k < ancho; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                ancho +=2;
            }

            Console.ReadLine(); // Esperar a que el usuario presione Enter
        }
    }
}

