namespace Practico6
{
    internal class Program
    {
        static int NumeroValido(string mensaje)
        {
            int numero;
            do
            {
                Console.WriteLine(mensaje);

            } while (!int.TryParse(Console.ReadLine(), out numero));
            return numero;
        }


        static void Ejercicio1()
        {
            Console.WriteLine("generar 10 numeros aleatorios entre 1 y 20 incluidos");
            Console.WriteLine("pedir al usuario numero, si esta en el array mostrar la posicion, sino mostrar no se encontro");

            int[] numeros = new int[20];
            Random aleatorio = new Random();
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = aleatorio.Next(1, 21);
            }

            int numeroElegido = NumeroValido("Ingrese un numero para buscar");
            bool numeroEstaEnArray = false;
            //  for(int i = 0; i < numeros.Length; i++)
            //  {
            //      if (numeros[i] == numeroElegido)
            //      {
            //          numeroEstaEnArray = true;
            //      }
            //  }

            int contador = 0;
            while (contador < numeros.Length)
            {
                if (numeros[contador] == numeroElegido)
                {
                    Console.WriteLine($"El numero {numeroElegido} esta en la posicion {contador}");
                    numeroEstaEnArray = true;
                }
                contador++;
            }
            if (!numeroEstaEnArray)
            {
                Console.WriteLine($"El numero {numeroElegido} no se encontro");
            }
        }

        static void Ejercicio2()
        {
            Console.WriteLine("Generar array[8] llenar con num aleat.");
            Console.WriteLine("Crear otro de[8] llenar con los mismos numero pero inverso orden y mostrarlos en pantalla");

            int[] arrOriginal = new int[8];
            int[] arrInverso = new int[8];

            int numero;
            Random aleatorio = new Random();


            for (int i = 0; i < arrOriginal.Length; i++)
            {
                arrOriginal[i] = aleatorio.Next(0, 101);
            }

            int contador = 0;
            for (int i = arrInverso.Length - 1; i >= 0; i--)
            {
                arrInverso[i] = arrOriginal[contador];
                contador++;
            }

            foreach (int i in arrOriginal)
            {

                Console.Write($"{i} \t ");
            }
            Console.WriteLine();
            foreach (int i in arrInverso)
            {
                Console.Write($"{i} \t");
            }
        }

        static void Ejercicio3()
        {
            Console.WriteLine("generar dos arr[5] con numeros al entre 3 y 57. crear un 3er arr[5] con suma de los dos arr");

            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            int[] arr3 = new int[5];
            Random random = new Random();

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = random.Next(3, 57);
                arr2[i] = random.Next(3, 57);
            }
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = arr2[i] + arr1[i];
            }

            foreach (int i in arr1)
            {
                Console.Write($"{i} \t");
            }
            Console.WriteLine();
            foreach (int i in arr2)
            {
                Console.Write($"{i} \t");

            }
            Console.WriteLine();
            foreach (int i in arr3)
            {
                Console.Write($"{i} \t");
            }
        }

        static int CantAlumnos()
        {
            int cantAlumnos;
            do
            {
                Console.WriteLine("Ingrese cantidad alumnos");
            } while (!int.TryParse(Console.ReadLine(), out cantAlumnos));
            return cantAlumnos;
        }

        static double NotaValida(string mensaje)
        {
            double notaValida;
            do
            {
                Console.Write(mensaje);
            }while(!double.TryParse(Console.ReadLine(), out notaValida));
            return notaValida;
        }
        

      

        static void Ejercicio4()
        {
            Console.WriteLine("cargar notas examenes, ingresar por teclado cant alumn, luego cargar notas en arr, buscar nota mas alta y mostrarla, indicar indice de arr");
            int cantAlumnos = CantAlumnos();
            double[] notasAlumnos = new double[cantAlumnos];

            for (int i = 0; i < notasAlumnos.Length; i++)
            {
                notasAlumnos[i] = NotaValida($"Ingrese la {i + 1} nota: ");
            }

            double notaMasAlta = notasAlumnos[0];
            // foreach(int i in notasAlumnos)
            // {
            //     if (notasAlumnos[i] > notaMasAlta)
            //     {
            //         notaMasAlta = notasAlumnos[i];
            //     }
            // }

            int indiceNotaMasAlta = 0;
            for(int i = 0; i < notasAlumnos.Length;i++)
            {
                if (notasAlumnos[i] > notaMasAlta)
                {
                    indiceNotaMasAlta = i;
                    notaMasAlta = notasAlumnos[i];
                }
            }
            Console.WriteLine($"La nota mas alta es {notaMasAlta} y esta en el indice {indiceNotaMasAlta}");
        }

        static void Ejercicio5()
        {
            Console.WriteLine("Ingresar numero, validad numero, arr separar digitos, reccorrer arr y mostrar el indicia que contiene digito mayor");
            int numero;
            do
            {
                Console.WriteLine("Ingrese un numero");
            }while(!int.TryParse(Console.ReadLine(), out numero));
            //int cantDigitosNumero = numero.Split("");
            int[] arrDigitos = new int[numero];

        }

        static void Main(string[] args)
        {
            Ejercicio4();
        }
    }
}
