using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03_C_BASICS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EJERCICIO 1");
            Ejercicio1();
            Console.WriteLine("\n");
            Console.WriteLine("EJERCICIO 2");
            Ejercicio2();
            Console.WriteLine("\n");
            Console.WriteLine("EJERCICIO 3");
            Ejercicio3();
            Console.WriteLine("\n");
            Console.WriteLine("EJERCICIO 4");
            Ejercicio4();
            Console.WriteLine("\n");
            Console.WriteLine("EJERCICIO 5");
            Ejercicio5();
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }

        static void Ejercicio1()
        {

            int x = 20;
            int y = 10;
            int resultado;

            resultado = x + y;
            Console.WriteLine("La Suma de {0} y {1} es {2}", x, y, resultado);
            resultado = x - y;
            Console.WriteLine("La Resta de {0} y {1} es {2}", x, y, resultado);
            resultado = x * y;
            Console.WriteLine("La Multiplicacion de {0} y {1} es {2}", x, y, resultado);
            resultado = x / y;
            Console.WriteLine("La Division de {0} y {1} es {2}", x, y, resultado);
            resultado = x % y;
            Console.WriteLine("El modulo entre {0} y {1} es {2}", x, y, resultado);
            
        }

        static void Ejercicio2()
        {

            int N = 5;
            double A = 4.56;
            char C = 'a';
            double resultado;

            Console.WriteLine("Variable N es {0}", N);
            Console.WriteLine("Variable A es {0}", A);
            Console.WriteLine("Variable C es {0}", C);
            resultado = (double)N + A;
            Console.WriteLine("{0} + {1} = {2}", N, A, resultado);
            resultado = A - (double)N;
            Console.WriteLine("{0} + {1} = {2}", A, N, resultado);
            N = (int)C;
            Console.WriteLine("El valor numerico de C es {0}", N);

        }

        static  void Ejercicio3()
        {
            int x = 20;
            int y = 10;
            double N = 4.5;
            double M = 3.5;
            
            Console.WriteLine("Variable y es {0}", y);
            Console.WriteLine("Variable N es {0}", N);
            Console.WriteLine("Variable M es {0}", M);
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
            Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
            Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
            Console.WriteLine("{0} % {1} = {2}", x, y, x % y);

            Console.WriteLine("{0} + {1} = {2}", N, M, N + M);
            Console.WriteLine("{0} - {1} = {2}", N, M, N - M);
            Console.WriteLine("{0} * {1} = {2}", N, M, N * M);
            Console.WriteLine("{0} / {1} = {2}", N, M, N / M);
            Console.WriteLine("{0} % {1} = {2}", N, M, N % M);

            Console.WriteLine("{0} + {1} = {2}", x, N, x + N);
            Console.WriteLine("{0} / {1} = {2}", y, M, y / M);
            Console.WriteLine("{0} % {1} = {2}", y, M, y % M);

            Console.WriteLine("El doble de x es {0}",  x * 2);
            Console.WriteLine("El doble de y es {0}", y * 2);
            Console.WriteLine("El doble de N es {0}", N * 2);
            Console.WriteLine("El doble de M es {0}", M * 2);


            Console.WriteLine("{0} + {1} + {2} + {3} = {4}", x, y,M,N, (double)x + (double)y + M + N);
            Console.WriteLine("{0} * {1} * {2} * {3} = {4}", x, y, M, N, (double)x * (double)y * M * N);

        }

        static void Ejercicio4()
        {            
            int N = 1;
            Console.WriteLine("Variable N es {0}", N);
            N = N + 77;
            Console.WriteLine("N + 77 = {0}", N);
            N = N - 3;
            Console.WriteLine("N - 3 = {0}", N);
            N = N * 2;
            Console.WriteLine("N * 2 = {0}", N);

        }

        static void Ejercicio5()
        {
            int A, B, C, D;
            A = 10;
            B = 20;
            C = 30;
            D = 40;
            Console.WriteLine("VALORES INICIALES A = {0},B = {1},C = {2},D = {3}", A,B,C,D);
            B = C;
            C = A;
            A = D;
            D = B;
            Console.WriteLine("VALORES FINALES A = {0},B = {1},C = {2},D = {3}", A, B, C, D);
       }

    }
}
