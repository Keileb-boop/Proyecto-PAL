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


            Console.Title = "Programa para comprobar las compuertas Xor y NAND";
            Console.WindowWidth = 60;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;


            //Declaración de las variables

            String entrada1xor, entrada2xor, entrada1nand, entrada2nand;

            //Entrada Xor

            Console.WriteLine("Ingrese porfavor solo letras mayúsculas o minúsculas :)");

            Console.WriteLine();


            Console.WriteLine("Ingrese la letra de la primer compuerta xor: ");
            entrada1xor = (Console.ReadLine());
            Console.WriteLine("Ingrese la letra de la segunda compuerta xor: ");
            entrada2xor = (Console.ReadLine());
            

            //intento de proceso Xor


            


            if (entrada1xor == "f"  && entrada2xor == "f") // instrucción
            {
                Console.WriteLine("\t Si ingresó los datos (f) y (f) la compuerta Xor es: v");

            }

            if (entrada1xor == "F" && entrada2xor == "F")
            {
                Console.WriteLine("\t Si ingresó los datos (F) y (F) la compuerta Xor es: V");
            }

            if (entrada1xor == "f"  && entrada2xor == "v") // instrucción
            {
                Console.WriteLine("\t Si ingresó los datos (f ) y (v) la compuerta Xor es: f");            
            }

            if (entrada1xor == "F" && entrada2xor == "V")
            {
                Console.WriteLine("\t Si ingresó los datos (F) y (V) la compuerta Xor es: F");
            }

            if (entrada1xor == "v"  && entrada2xor == "f") // instrucción
            {
                Console.WriteLine("\t Si ingresó los datos (v) y (f) la compuerta Xor es: f");

            }

            if (entrada1xor == "V" && entrada2xor == "F")
            {
                Console.WriteLine("\t Si ingresó los datos (V) y (F) la compuerta Xor es: F");
            }

            if (entrada1xor == "v"  && entrada2xor == "v") // instrucción
            {
                Console.WriteLine("\t Si ingresó los datos (v) y (v) la compuerta Xor es: v");
            }

            if (entrada1xor == "V" && entrada2xor == "V")
            {
                Console.WriteLine("\t Si ingresó los datos (V) y (V) la compuerta Xor es: V");
            }





            Console.WriteLine();

            //Entrada NAND

            Console.WriteLine("Ingrese la letra de la primer compuerta NAND: ");
            entrada1nand = (Console.ReadLine());
            Console.WriteLine("Ingrese la letra de la segunda compuerta NAND: ");
            entrada2nand = (Console.ReadLine());

            if (entrada1nand == "f" && entrada2nand == "f")
            {
                Console.WriteLine("\t Si ingresó los datos (f) y (f) la compuerta NAND es: v");
            }

            if (entrada1nand == "F" && entrada2nand == "F")
            {
                Console.WriteLine("\t Si ingresó los datos (F) y (F) la compuerta NAND es: V");
            }

            if (entrada1nand == "f" & entrada2nand == "v")
            {
                Console.WriteLine("\t Si ingresó los datos (f) y (v) la compuerta NAND es: v");
            }

            if (entrada1nand == "F" && entrada2nand == "V")
            {
                Console.WriteLine("\t Si ingresó los datos (F) y (V) la compuerta NAND es: F");
            }

            if (entrada1nand == "v" && entrada2nand == "f")
            {
                Console.WriteLine("\t Si ingresó los datos (v) y (f) la compuerta NAND es: f");
            }

            if (entrada1nand == "V"  && entrada2nand == "F")
            {
                Console.WriteLine("\t Si ingresó los datos (V) y (F) la compuerta NAND es: F");
            }

            if (entrada1nand == "v" && entrada2nand == "v")
            {
                Console.WriteLine("\t Si ingresó los datos (v) y (v) la compuerta NAND es: v");
            }

            if (entrada1nand == "V" && entrada2nand == "V")
            {
                Console.WriteLine("\t Si ingresó los datos (V) y (V) la compuerta NAND es: V");
            }



            Console.WriteLine();


            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;


            Console.WriteLine("\t***********************************");

            Console.WriteLine("\t   Gracias por usar el programa    ");

            Console.WriteLine("\t                                   ");

            Console.WriteLine("\t     Hecho por Caleb Peñate :)     ");

            Console.WriteLine("\t***********************************");

            Console.ReadKey();


        }
    }
}
