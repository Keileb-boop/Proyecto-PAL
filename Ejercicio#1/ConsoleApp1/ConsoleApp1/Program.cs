using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa realizado por 
            // Día: 
            Console.WindowHeight = 25;  // alto de la ventana           
            Console.WindowWidth = 70; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Desafio Practico";
            Console.Write("\nEjercicio#1");
            // Declaracion de variables

            double a, b, perimetro, pulgadas;

            //Proceso
            Console.Write("\n\n");
            Console.Write("\tAsigne el valor numerico de a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("\tAsigne el valor numerico de b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("\n");

            perimetro =  Math.PI * (3 * (a + b) - Math.Sqrt ((3 * a + b) * (a + 3 * b)));
            perimetro = Math.Round(perimetro, 2);

            pulgadas = (perimetro * 2.54);

            Console.Write("\tEl perimetro de la elipse es: "+perimetro + " cm");
            Console.Write("\n");
            Console.Write("\tEl perimetro en pulgada es: " + pulgadas + " pulgadas");

            //finn
            Console.Write("\n");
            Console.Write("\n");
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t*                                           *");
            Console.WriteLine("\t*     Este programa fue diseñado por:       *");
            Console.WriteLine("\t*                                           *");
            Console.WriteLine("\t*         Carlos Batres, RB230288           *");
            Console.WriteLine("\t*                                           *");
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");

            Console.ReadKey();
        }
    }
}
