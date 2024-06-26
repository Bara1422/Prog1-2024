﻿namespace Practico5
{
    internal class Program
    {
        static int Invertir(int numero)
        {
            int invertido = 0;
            while (numero > 0)
            {
                invertido = invertido * 10 + (numero % 10);
                numero = numero / 10;
            }
            return invertido;
        }

        static void Ejercicio1()
        {
            Console.WriteLine("pedir numero entero y ver si es capicua o no");
            int numero;
            bool esNumero = false;
            do
            {
                Console.WriteLine("Ingrese un numero entero");
                esNumero = int.TryParse(Console.ReadLine(), out numero);
            } while (!esNumero);

            int numeroInvertido = Invertir(numero);
            if (numeroInvertido == numero)
            {
                Console.WriteLine($"El numero {numero} es capicua");
            }
            else
            {
                Console.WriteLine($"El numero {numero} no es capicua");
            }
        }

        static void Ejercicio2()
        {
            Console.WriteLine("Cuantos parametros por valor y cuantos por referencia");
            Console.WriteLine("static void Ej1(char a, char b, out string resultado) { 2 parametros por valor, 1 por referencia  }");
            Console.WriteLine("static void Ej2(out char a, out char b, out string resultado) { 3 parametros por referencia }");
            Console.WriteLine("static double F1(int num1, double num2, bool realizar) {3 parametros por valor }");
            Console.WriteLine("static char LeeLetra(string texto, int pos) { 2 parametros pro valor }");
            Console.WriteLine("static int LeeNumero(string texto, out bool error) { 1 parametro por valor, 1 por referencia }");
        }

        static void Ejercicio3()
        {
            Console.WriteLine("Que llamadas son correctas, aclarando en caso incorrecta");
            /*
            char a, b;
            string salida;
            int num1;
            double num2;
            bool esNum, dioError, ejecutar;
            */

            /*
            a. string resultado = Ej1(a, b, salida)
            b. Ej1(a,b, salida)
            c. int opcion = Ej2(a, b, salida);
            d. double calculo = F1(num1, num2, ejecutar);
            e.num1 = LeeNumero(salida, dioError);
            f.salida = LeeLetra(salida, num1);
            g.b = LeeLetra(salida, num1);
            */

            Console.WriteLine("a incorrecto xq no devuelve ningun valor la funcion Ej1");
            Console.WriteLine("b correcto");
            Console.WriteLine("c incorrecto xq no devuelve ningun valor la funcion Ej2");
            Console.WriteLine("d correcto");
            Console.WriteLine("e correcto");
            Console.WriteLine("f incorrecto salida es string y devuelve char");
            Console.WriteLine("g correcto");
        }

        static bool Es_Digito(char caracter)
        {
            int numero;
            return int.TryParse(caracter.ToString(), out numero);

        }

        static void Ejercicio4()
        {
            char caracter;
            bool esChar = false;
            Console.WriteLine("es o no un digito");
            do
            {
                Console.WriteLine("Ingrese un caracter");
                esChar = char.TryParse(Console.ReadLine(), out caracter);
            } while (!esChar);

            if (Es_Digito(caracter) == false)
            {
                Console.WriteLine($"{caracter} no es un digito");
            }
            else
            {
                Console.WriteLine($"{caracter} es un digito");
            }
        }

        static double RedondearCentesima(double numero)
        {

            double numeroMitad = Math.Round(numero, 2);


            Console.WriteLine(numeroMitad);

            return numeroMitad;
        }

        static void Ejercicio5()
        {
            Console.WriteLine("Ejercicio 5 redondearCentesima");
            double numero;
            bool esNum = false;
            do
            {
                Console.WriteLine("Ingrese un numero con decimales");
                esNum = double.TryParse(Console.ReadLine(), out numero);
            } while (!esNum);

            RedondearCentesima(numero);
        }

        static bool EsBisiesto(int anio)
        {
            if (anio % 4 == 0 && (anio % 100 != 0 || anio % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool EsNumeroValido(string mensaje, out int numero)
        {
            int[] meses31 = { 1, 3, 5, 7, 8, 10, 12 };
            bool esValido = false;
            numero = 0;
            Console.WriteLine($"Ingrese un {mensaje} valido");
            do
            {
                esValido = int.TryParse(Console.ReadLine(), out numero);
                if (mensaje == "dia")
                {
                    if (numero < 1 || numero > 31)
                    {
                        esValido = false;
                        Console.WriteLine($"Ingrese un {mensaje} entre 1 y 31");
                    }
                }
                if (mensaje == "mes")
                {
                    if (numero < 1 || numero > 12)
                    {
                        esValido = false;
                        Console.WriteLine($"Ingrese un {mensaje} entre 1 y 12");
                    }
                }
                if (mensaje == "anio")
                {
                    if (numero < 1)
                    {
                        esValido = false;
                        Console.WriteLine($"Ingrese un {mensaje} mayor a 0");
                    }
                }
            } while (!esValido);
            return esValido;
        }
        static void Ejercicio7()
        {
            int dia, mes, anio;
            bool mesContieneDia = false;
            
            Console.WriteLine("Ejercicio 7 es bisiesto?");
            EsNumeroValido("dia", out dia);
            do
            {
                EsNumeroValido("mes", out mes);
                if ((mes == 4 || mes == 6 || mes == 9 || mes == 11) && dia == 31)
                {
                    Console.WriteLine($"El mes {mes} no tiene {dia} dias");
                }
                else if (mes == 2 && dia >= 30)
                {
                    Console.WriteLine($"El mes {mes} no tiene {dia} dias");
                }else
                {
                    mesContieneDia = true;
                }
            } while (mesContieneDia == false);

            EsNumeroValido("anio", out anio);

            Console.WriteLine(dia);
            Console.WriteLine(mes);
            Console.WriteLine(anio);
            if(EsBisiesto(anio))
            {
                Console.WriteLine($"La fecha {dia}/{mes}/{anio} es de un anio biciesto");
            }
            else
            {
                Console.WriteLine($"La fecha {dia}/{mes}/{anio} no es de un anio biciesto");
            }
        }
        static void Main(string[] args)
        {
            Ejercicio7();
        }
    }
}
