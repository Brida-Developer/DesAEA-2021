using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_01
{
    class Program
    {
        static void Main(string[] args)

        {
            
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Resta de dos números");
                Console.WriteLine("[3] Multiplicacion de dos números");
                Console.WriteLine("[4] Division de dos números");
                Console.WriteLine("[5] Imprimir los 10 primeros numeros primos");
                Console.WriteLine("[6] Convertir de Centigrados a Fahrenheit ");
                Console.WriteLine("[7] Convertir de Fahrenheit a Centigrados ");
                Console.WriteLine("[8] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("--- Suma de dos números ---");
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("--- Resta de dos números ---");
                        Console.WriteLine("Ingrese el primer número");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", c, d, Resta(c, d));
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("--- Multiplicacion de dos números ---");
                        Console.WriteLine("Ingrese el primer número");
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", e, f, Multiplicacion(e, f));
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.WriteLine("--- Division de dos números ---");
                        Console.WriteLine("Ingrese el primer número");
                        int g = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int h = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", g, h, Division(g, h));
                        Console.ReadKey();
                        break;

                    case "5":
                        Console.WriteLine("--- Calculando numeros primos ---");
                        Console.WriteLine("Los 10 primeros numeros primos son:");
                        NumPrimos();
                        Console.ReadKey();
                        break;

                    case "6":
                        Console.WriteLine("Ingrese grados centigrados");
                        int x = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(" {0} °C es igual a {1} °F", x, Temp(x));
                        Console.ReadKey();
                        break;

                    case "7":
                        Console.WriteLine("Ingrese grados Fahrenheit");
                        int y = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(" {0} °F es igual a {1} °C", y, Temp2(y));
                        Console.ReadKey();
                        break;

                    case "8":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));

        }

        static int Suma(int a, int b)
        {
            return a + b;
        }
        static int Resta(int a, int b)
        {
            return a  - b;
        }
        static int Multiplicacion(int a, int b)
        {
            return a  *  b;
        }
        static int Division(int a, int b)
        {
            return a  / b;
        }
        

        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }

        static double Temp(int x)
        {
            return (x * 1.8) + 32;

        }

        static double Temp2(int x)
        {
            return (x - 32) / 1.8;

        }



        //Procedimiento que imprime los 10 primero numeros primos
        static void NumPrimos()

        {
            int cont = 0;
            for (int i = 2; i <= 30; i++)
            {
                for (int j = 1; j <= i; j++)
                {

                    if (i % j == 0)
                    {
                        cont = cont + 1;
                    }
                }

                if (cont <= 2)
                {
                    Console.WriteLine(i);
                }
                cont = 0;


            }

        }




    }
}
