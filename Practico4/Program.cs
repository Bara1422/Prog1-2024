namespace Practico4
{
    internal class Program
    {
        static void Ejercicio1()
        {
            Console.WriteLine("------------- 1: Secuencia desde 1 hasta X --------------");

            int valor = numeroValido();

            Console.WriteLine($"El ciclo desde 1 hasta {valor} es:");

            for (int i = 1; i <= valor; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }

        static void Ejercicio2()
        {
            Console.WriteLine("------------- 2: Secuencia desde 1 hasta X mostrando los pares --------------");
            int valor = numeroValido();

            Console.WriteLine($"Numeros pares entre 1 y {valor}");
            for (int i = 2; i <= valor; i++)
            {
                if (i % 2 == 0)
                {

                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }

        static void Ejercicio3()
        {
            Console.WriteLine("------------- 3: Suma y promedio de valores ingresados --------------");
            Console.WriteLine("Ingrese cantidad de valores a ingresar");
            double cantidadValores = numeroValido();
            double numerosIngresados = 0;
            double promedio;

            for (int i = 1; i <= cantidadValores; i++)
            {
                Console.WriteLine($"Ingrese el valor numero {i}");
                numerosIngresados += numeroValido();
            }

            promedio = numerosIngresados / cantidadValores;
            Console.WriteLine($"La suma de los valores es {numerosIngresados}");
            Console.WriteLine($"El promedio de los valores es {promedio}");
        }

        static void Ejercicio4()
        {
            Console.WriteLine("------------- 4: Multiplos X entre A y B --------------");
            int numero1, numero2, numero3;
            bool numerosPositivos = false;
            do
            {
                Console.WriteLine("Ingrese el primer numero");
                numero1 = numeroValido();
                Console.WriteLine("Ingrese el segundo numero");
                numero2 = numeroValido();
                Console.WriteLine("Ingrese el numero del cual quiere buscar los multiplos");
                numero3 = numeroValido();
                numerosPositivos = true;
                if (numero1 < 1 || numero2 < 1 || numero3 < 1)
                {
                    Console.WriteLine("Ingrese numeros enteros positivos");
                    numerosPositivos = false;
                }
                if (numero1 > numero2)
                {
                    Console.WriteLine("El primer numero debe ser menor o igual que el segundo\n");
                    numerosPositivos = false;
                }
            } while (!numerosPositivos);

            Console.Write($"Los numeros multiplos de {numero3} son: ");
            int cantidadMultiplos = 0;
            for (int i = numero1; i <= numero2; i++)
            {
                if (i % numero3 == 0)
                {
                    cantidadMultiplos++;
                    Console.Write($"{i} ");
                }
            }
            if (cantidadMultiplos == 0)
            {
                Console.Write(0);
            };
        }

        static void Ejercicio5()
        {
            Console.WriteLine("------------- 5: Dibujar rectangulo --------------");

            int baseRectangulo, alturaRectangulo;

            do
            {
                Console.WriteLine("Ingrese la medida de la base del rectangulo a dibujar");
                baseRectangulo = numeroValido();
                Console.WriteLine("Ingrese la medida de la altura del rectangulo a dibujar");
                alturaRectangulo = numeroValido();

                if (baseRectangulo > 40 || alturaRectangulo > 40)
                {
                    Console.WriteLine("Maximo de base o altura 40");
                }
                if (baseRectangulo < 1 || alturaRectangulo < 1)
                {
                    Console.WriteLine("Minimo de base o altura 1");
                }

            } while (baseRectangulo > 40 || baseRectangulo < 1 || alturaRectangulo > 40 || alturaRectangulo < 1);

            for (int i = 0; i < alturaRectangulo; i++)
            {
                for (int j = 0; j < baseRectangulo; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Ejercicio6()
        {
            Console.WriteLine("------------- 6: Calcular promedio --------------");
            double numeroIngresado, sumaNumeros, cantidadNumeros;
            double promedio;
            cantidadNumeros = 0;
            sumaNumeros = 0;
            do
            {
                Console.WriteLine("Ingrese un numero");
                numeroIngresado = Convert.ToDouble(Console.ReadLine());
                if (numeroIngresado > 0)
                {
                    cantidadNumeros++;
                    sumaNumeros += numeroIngresado;
                }
            } while (numeroIngresado > 0);

            promedio = sumaNumeros / cantidadNumeros;
            Console.WriteLine($"El promedio es {promedio} con un total de {cantidadNumeros} ingresos");

        }

        static void Ejercicio7()
        {
            Console.WriteLine("------------- 7: Secuencia ordenada menor a mayor --------------");
            Console.WriteLine("Ingrese enteros positivos, para terminar ingrese 0");
            int numeroActual, numeroAnterior;
            bool ordenada = true;

            numeroAnterior = 0;
            do
            {
                numeroActual = numeroValidoConCero();
                if (numeroActual > 0)
                {
                    if (numeroActual < numeroAnterior)
                    {
                        ordenada = false;
                    }

                }
                numeroAnterior = numeroActual;
            } while (numeroActual > 0);

            if (ordenada)
            {
                Console.WriteLine("La secuencia estaba ordenada de menor a mayor");
            }
            else
            {
                Console.WriteLine("La secuencia NO estaba ordenada de menor a mayor");
            }
        }

        static void Ejercicio8()
        {
            Console.WriteLine("------------- 8: Caracter en pantalla N veces --------------");
            string texto = "";
            int cantidadRepeticiones = 0;
            do
            {
                Console.WriteLine("Ingrese UN caracter que se repetira N veces ");
                texto = Console.ReadLine();
                if (texto.Length == 1)
                {
                    Console.WriteLine("Ingrese las veces que quiere que se repita el caracter");
                    cantidadRepeticiones = numeroValido();
                }

            } while (texto.Length != 1);

            for (int i = 1; i <= cantidadRepeticiones; i++)
            {
                Console.Write(texto);
            }
        }

        static bool EsVocal(char caracter)
        {
            string vocales = "aeiouAEIOUáéíóú";
            bool esVocal = false;
            int limite, indice;
            limite = vocales.Length;
            indice = 0;
            do
            {
                if (caracter == vocales[indice])
                {
                    esVocal = true;
                }
                indice += 1;
            } while (!esVocal && indice < limite);
            return esVocal;
        }

        static void Ejercicio9()
        {
            Console.WriteLine("------------- 9: Cantidad vocales --------------");
            string texto;
            int cantidadVocales = 0;
            Console.WriteLine("Ingrese un texto");
            texto = Console.ReadLine();
            if (texto.Length > 0)
            {


                for (int i = 0; i < texto.Length; i++)
                {
                    if (EsVocal(texto[i]))
                    {
                        cantidadVocales++;
                    }
                    //char charMinuscula = char.ToLower(texto[i]);
                    //if (charMinuscula == 'a' || charMinuscula == 'e' || charMinuscula == 'i' || charMinuscula == 'o' || charMinuscula == 'u')
                    //{
                    //    cantidadVocales++;
                    //}
                }
            }
            else
            {
                Console.WriteLine("Ingrese un texto valido");
            }

            Console.WriteLine($"Aparecen {cantidadVocales} vocales");
        }

        static void Ejercicio10()
        {
            Console.WriteLine("Ingrese una oracion");
            string texto = Console.ReadLine();


            Console.WriteLine("Ejercicio 10, ingrese el inciso que desea ver a-c");
            Console.WriteLine("a = Total caracteres de la oracion");
            Console.WriteLine("b = Total de letras de la oracion");
            Console.WriteLine("c = Cantidad palabras separadas por uno o mas espacios");
            string inciso = Console.ReadLine();

            if (inciso == "a")
            {
                Ejercicio10_a(texto);
            }
            else if (inciso == "b")
            {
                Ejercicio10_b(texto);
            }
            else if (inciso == "c")
            {
                Ejercicio10_c(texto);
            }
            else
            {
                Console.WriteLine("Inciso incorrecto para este ejercicio");
            }
        }

        static void Ejercicio10_a(string texto)
        {
            int caracteresEnTexto = texto.Length;
            Console.WriteLine($"La cantidad de caracteres del texto es de {caracteresEnTexto}");
        }

        static void Ejercicio10_b(string texto)
        {
            int cantidadLetras = 0;
            int caracteresEnTexto = texto.Length;

            for (int i = 0; i < caracteresEnTexto; i++)
            {
                if (EsLetra2(texto[i]))
                {
                    cantidadLetras++;
                }
            }
            Console.WriteLine($"Cantidad total de letras es {cantidadLetras}");
        }

        static bool EsLetra(char caracter)
        {
            int ascii = Convert.ToInt32(caracter);
            bool resultado;
            if ((ascii >= 65 && ascii <= 90) || (ascii >= 97 && ascii <= 122) || (ascii >= 160 && ascii <= 165)
                || ascii == 130 || ascii == 144 || ascii == 181 || ascii == 214 || ascii == 224 || ascii == 233)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            return resultado;
        }

        static bool EsLetra2(char caracter)
        {
            bool resultado;
            if (char.ToLower(caracter) != char.ToUpper(caracter))
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            return resultado;
        }

        static void Ejercicio10_c(string texto)
        {
            string palabraActual = "";
            int cantidadPalabras = 0;

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == ' ')
                {
                    if (palabraActual.Length != 0)
                    {
                        cantidadPalabras += 1;
                        palabraActual = "";
                    }
                }
                else
                {
                    palabraActual += texto[i];
                }
            }
            if (texto[texto.Length - 1] != ' ')
            {
                cantidadPalabras++;
            }
            Console.WriteLine(palabraActual);
            Console.WriteLine($"La cantidad de palabras separadas son {cantidadPalabras}");
        }

        static void Ejercicio10_c2(string texto)
        {
            int cant, limite, posicion;
            cant = 0;
            posicion = 0;
            limite = texto.Length - 1;

            do
            {
                if (EsLetra(texto[posicion]))
                {
                    do
                    {
                        if (posicion + 1 <= limite)
                        {
                            posicion++;
                        }
                    } while (EsLetra(texto[posicion]) && posicion < limite);

                    cant++;
                }
                else
                {
                    do
                    {
                        if (posicion + 1 <= limite)
                        {
                            posicion++;
                        }
                    } while (EsLetra(texto[posicion]) && posicion < limite);
                }

            } while (posicion + 1 <= limite);
        }

        static void Ejercicio11()
        {
            Console.WriteLine("------------- 11: Palabra mas larga y cuantas letras tiene --------------");
            Console.WriteLine("Ingrese un texto");
            string texto = Console.ReadLine();
            string palabraActual = "";
            string palabraMasLarga = "";
            int caracteresPalabraMasLarga = 0;

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == ' ')
                {
                    if (palabraActual.Length > caracteresPalabraMasLarga)
                    {
                        palabraMasLarga = palabraActual;
                        caracteresPalabraMasLarga = palabraMasLarga.Length;
                    }
                    palabraActual = "";
                }
                else
                {
                    palabraActual += texto[i];
                }
            }

            if (palabraActual.Length > caracteresPalabraMasLarga)
            {
                palabraMasLarga = palabraActual;
                caracteresPalabraMasLarga = palabraMasLarga.Length;
            }
            Console.WriteLine($"La palabra mas larga es {palabraMasLarga} y tiene {caracteresPalabraMasLarga} caracteres");
        }

        static bool EsLetraEj11(char caracter)
        {
            bool esLetra;

            if (char.ToUpper(caracter) != char.ToLower(caracter))
            {
                return esLetra = true;
            }
            else
            {
                return esLetra = false;
            }
        }

        static void Ejercicio11_2()
        {
            Console.WriteLine("Ejericicio 11");
            string palabraMasLarga = "";
            string palabraActual = "";
            string texto = "";
            int caracteresPalabraMasLarga;
            do
            {
                Console.WriteLine("Ingrese un texto y verá la palabra mas larga");
                texto = Console.ReadLine();
            } while (texto.Length == 0);


            for (int i = 0; i < texto.Length; i++)
            {
                if (EsLetraEj11(texto[i]))
                {
                    palabraActual += texto[i];
                }
                else if (texto[i] == ' ')
                {
                    if (palabraActual.Length > palabraMasLarga.Length)
                    {
                        palabraMasLarga = palabraActual;
                    }
                    palabraActual = "";
                }
            }
            caracteresPalabraMasLarga = palabraMasLarga.Length;
            Console.WriteLine($"La palabra mas largar es {palabraMasLarga} y contiene {caracteresPalabraMasLarga} caracteres");
        }

        static int numeroValido()
        {

            int valor = 0;
            bool esValido;

            do
            {
                Console.Write("Ingrese un numero entero positivo: ");
                esValido = int.TryParse(Console.ReadLine(), out valor);
            } while (!(esValido && valor > 0));

            return valor;
        }

        static int numeroValidoConCero()
        {
            int valor = 0;
            bool esValido = false;

            do
            {
                Console.Write("Ingrese un numero entero positivo: ");
                esValido = int.TryParse(Console.ReadLine(), out valor);
            } while (!(esValido && valor >= 0));

            return valor;
        }



        static bool esNumeroValido(int n)
        {
            bool resultado;
            if (n >= 1 && n <= 11)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            return resultado;
        }

        static void Main(string[] args)
        {

            int numEjercicio;
            do
            {
                Console.WriteLine("----------------------------------------\n");
                Console.WriteLine("Ingrese un numero de ejercicio (1-11), pulse 0 para finalizar");
                numEjercicio = numeroValido();
                if (esNumeroValido(numEjercicio))
                {

                    if (numEjercicio == 1)
                    {
                        Ejercicio1();
                    }
                    else if (numEjercicio == 2)
                    {
                        Ejercicio2();
                    }
                    else if (numEjercicio == 3)
                    {
                        Ejercicio3();
                    }
                    else if (numEjercicio == 4)
                    {
                        Ejercicio4();
                    }
                    else if (numEjercicio == 5)
                    {
                        Ejercicio5();
                    }
                    else if (numEjercicio == 6)
                    {
                        Ejercicio6();
                    }
                    else if (numEjercicio == 7)
                    {
                        Ejercicio7();
                    }
                    else if (numEjercicio == 8)
                    {
                        Ejercicio8();
                    }
                    else if (numEjercicio == 9)
                    {
                        Ejercicio9();
                    }
                    else if (numEjercicio == 10)
                    {
                        Ejercicio10();
                    }
                    else if (numEjercicio == 11)
                    {
                        Ejercicio11_2();
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un numero valido entre 0 y 11");
                    }
                }
                else
                {
                    Console.WriteLine("El numero no es valido (0-11)");
                }
            } while (numEjercicio != 0);
        }
    }
}

