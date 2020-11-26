using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_While_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int var1, var2;
            int i;
            while (n != 6)

            {
                Console.Clear();
                Console.WriteLine("Seleccione una opción del MENU\n");

                Console.WriteLine("|*******  PREGUNTAS  *******| \n" +
                                  "|*                         *| \n" +
                                  "|* 1. Imprimir Números     *| \n" +
                                  "|* 2. Suma / Promedio      *| \n" +
                                  "|* 3. Ingreso Bar          *| \n" +
                                  "|* 4. DNI                  *| \n" +
                                  "|* 5. Palabra              *| \n" +
                                  "|* 6. EXIT                 *| \n" +
                                  "|*                         *| \n" +
                                  "|***************************| \n");

                n = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (n)

                {
                    case 1:
                        //Programa que solicite al usuario un número 
                        //e imprima los numeros desde el 0 hasta el número igresado.

                        Console.Clear();

                        do
                        {

                            Console.WriteLine("Ingrese un Número entero\n");
                            var1 = Convert.ToInt32(Console.ReadLine());

                            Console.Clear();

                            Console.WriteLine("Estos son los números que preceden " +
                                    "el número que usted ingresó: \n");

                            for (i = 0; i <= var1; i++)

                            {
                                Console.WriteLine(i);

                            }
                            i++;
                        } while (var1 < 0);

                        break;

                    case 2:

                        //Programa que ingrese 10 numeros y muestre la suma de ellos
                        //y su promedio.

                        int suma, promedio;
                        suma = 0;
                        var2 = 10;
                        int[] numeros = new int[var2];

                        Console.Clear();

                        do
                        {

                            Console.WriteLine("Ingrese 10 números enteros\n");

                            for (i = 0; i < var2; i++)

                            {
                                numeros[i] = Convert.ToInt32(Console.ReadLine());
                                suma = suma + numeros[i];
                            }

                            i++;

                        } while (suma < 10);
                        Console.Clear();
                        Console.WriteLine("La suma es igual a " + suma);
                        promedio = suma / var2;
                        Console.WriteLine("El promedio es igual a  " + promedio);

                        break;

                    case 3:

                        //Programa que pida valores de edad y diga si puede entrar
                        //a un bar o no segun la mayoria de edad, y segun el sexo 
                        //cobrar cover(Hombres) o no(Mujeres).

                        Console.Clear();

                        int n1 = 1;
                        int edad;


                        Console.WriteLine("Digite su edad");
                        edad = Convert.ToInt32(Console.ReadLine());

                        Console.Clear();

                        if (edad > 18)

                        {

                            while (n1 != 3)
                            {


                                Console.WriteLine("|* ES USTED HOMBRE O MUJER *| \n" +
                                                      "|*                         *| \n" +
                                                      "|* 1. Hombre               *| \n" +
                                                      "|* 2. Mujer                *| \n" +
                                                      "|* 3. EXIT                 *| \n" +
                                                      "|*                         *| \n" +
                                                      "|***************************| \n");

                                n1 = Convert.ToInt32(Console.ReadLine());

                                Console.Clear();

                                switch (n1)

                                {
                                    case 1:

                                        Console.WriteLine("Usted debe pagar un Cover de $15.000 pesos");

                                        break;

                                    case 2:

                                        Console.WriteLine("No tiene que pagar Cover\n" +
                                                           "Puede Ingresar!");

                                        break;

                                    default:

                                        Console.Clear();
                                        Console.WriteLine("Vuelva Pronto!");

                                        break;
                                }

                            }
                        }

                        else

                            Console.WriteLine("*Para ingresar al BAR CORONA usted debe ser mayor de edad*");

                        break;

                    case 4:

                        //Programa que tenga guardados 10 DNI peligrosos por la fiscalia
                        //y pida el DNI del usuario y diga si esta libre o 
                        //debe ser capturado.

                        //int user = 1;
                        int[] dni = new int[10];

                        do
                        {

                            for (i = 0; i < 10; i++)

                            {
                                dni[0] = 100;
                                dni[1] = 200;
                                dni[2] = 300;
                                dni[3] = 400;
                                dni[4] = 500;
                                dni[5] = 600;
                                dni[6] = 700;
                                dni[7] = 800;
                                dni[8] = 900;
                                dni[9] = 1000;
                            }


                            Console.WriteLine("\nIngrese su DNI:");
                            i = Convert.ToInt32(Console.ReadLine());

                            if (i == dni[0] || i == dni[1] || i == dni[2] || i == dni[3] ||
                               i == dni[4] || i == dni[5] || i == dni[6] || i == dni[7] ||
                               i == dni[8] || i == dni[9])

                            {

                                Console.WriteLine("**El sujeto tiene ORDEN DE CAPTURA**");

                            }

                            else
                                Console.WriteLine("Usted no tiene Antecedentes.\n" +
                                    "Puede continuar su camino");


                        } while (i > 1000);

                        break;

                    case 5:

                        //Programa que pida una palabra al usuario e 
                        //imprima sus letras separadas.

                        string palabra1;

                        do
                        {

                            Console.WriteLine("Digite una palabra:");
                            palabra1 = Console.ReadLine();
                            Console.Clear();

                            for (i = 0; i < palabra1.Length; i++)


                            {
                                Console.WriteLine(palabra1[i]);

                            }

                        } while (palabra1.Length > 10);

                        break;


                    default:

                        Console.Clear();
                        Console.WriteLine("**FIN DEL PROGRAMA**");

                        break;
                }


                Console.ReadKey();

            }

            Console.ReadKey();
        }
    }
}
