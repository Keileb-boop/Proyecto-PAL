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
            Console.WindowHeight = 35;
            Console.WindowWidth = 60;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Cuerpos Geométricos...";
            Console.Write("\nDesafia 1 Ejercicio2");
            Console.WriteLine("\n");
            Console.WriteLine("\t***Cálculo del área de cuerpos geométricos***");
            Console.WriteLine("\t*                                           *");
            Console.WriteLine("\t*             [1] Esfera                    *");
            Console.WriteLine("\t*             [2] Pirámide                  *");
            Console.WriteLine("\t*             [3] Cono                      *");
            Console.WriteLine("\t*                                           *");
            Console.WriteLine("\t****************************************");
            Console.Write("\n");
            Console.WriteLine("Seleccione una opción: ");
            Console.ForegroundColor = ConsoleColor.Red;

            int option = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n");

            switch (option)
            {
                case 1:
                    Console.WriteLine("Ingrese el radio de la esfera (en cm): ");
                    double r = double.Parse(Console.ReadLine());
                    double areaesfera = 4 * Math.PI * Math.Pow(r, 2);
                    Console.WriteLine("El área de la esfera es: " + areaesfera + " cm^2");
                    break;
                case 2:
                    Console.WriteLine("Ingrese el lado de la base de la pirámide (en cm): ");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura de la pirámide (en cm): ");
                    double h = double.Parse(Console.ReadLine());
                    double areaPiramide = (b * h) / 2;
                    Console.WriteLine("El área de la pirámide es: " + areaPiramide + " cm^2");
                    break;
                case 3:
                    Console.WriteLine("Ingrese la generatriz del cono (en cm): ");
                    double g = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del cono (en cm): ");
                    h = double.Parse(Console.ReadLine());
                    double areaCono = Math.PI * Math.Pow(g, 2) / 2 + Math.PI * g * Math.Sqrt(Math.Pow(g / 2, 2) + Math.Pow(h, 2));
                    Console.WriteLine("El área del cono es: " + areaCono+ " cm^2");
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

            Console.ReadLine();
            Console.WriteLine("\n");
            //Pantalla opcional
            Console.Write("\t");
            Console.WriteLine("*********************************************");
            Console.WriteLine("\t*                                         *");
            Console.WriteLine("\t*     Este programa fue diseñado por:     *");
            Console.WriteLine("\t*                                         *");
            Console.WriteLine("\t*         Alexander Valladares            *");
            Console.WriteLine("\t*                                         *");
            Console.Write("\t");
            Console.WriteLine("*********************************************");

            Console.Write("\t");
            Console.WriteLine("---> Calculo terminado <---");
            Console.Write("\t");
            Console.ReadKey();
        }
    }
}
