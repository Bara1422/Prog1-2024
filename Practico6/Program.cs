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
                Console.Write($"{mensaje}: ");
            } while (!double.TryParse(Console.ReadLine(), out notaValida));
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
            for (int i = 0; i < notasAlumnos.Length; i++)
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
            } while (!int.TryParse(Console.ReadLine(), out numero));
            //int cantDigitosNumero = numero.Split("");
            string numeroString = numero.ToString();
            int[] stringsNumero = new int[numeroString.Length];
            int numeroMayor = 0;
            int indiceNumeroMayor = 0;

            for (int i = 0; i < numeroString.Length; i++)
            {
                stringsNumero[i] = numeroString[i] - '0';
                if (stringsNumero[i] > numeroMayor)
                {
                    numeroMayor = stringsNumero[i];
                    indiceNumeroMayor = i;
                }
                Console.Write($"{stringsNumero[i]} - ");
            }

            Console.WriteLine($"El mayor numero es {numeroMayor} y su indice es {indiceNumeroMayor}");
        }

        public struct AlumnoEj6
        {
            public string nombreAlumno;
            public string apellidoAlumno;
            public double notaAlumno;

        }

        static AlumnoEj6 AgregarAlumnoEj6()
        {


            AlumnoEj6 alumno = new AlumnoEj6();
            Console.Write("Ingrese apellido del alumno: ");
            alumno.nombreAlumno = Console.ReadLine();
            Console.Write("Ingrese nombre del alumno: ");
            alumno.apellidoAlumno = Console.ReadLine();
            alumno.notaAlumno = NotaValida("Ingrese la nota del alumno");

            return alumno;
        }

        static void Ejercicio6()
        {
            Console.WriteLine("Cargar lista alumnos y notas, generar lista si aporbaon o no (aprueba 40)");
            int numeroAlumnos;
            do
            {
                Console.Write("Ingrese cantidad alumnos: ");
            } while (!int.TryParse(Console.ReadLine(), out numeroAlumnos));
            List<AlumnoEj6> listAlumnosEj6 = new List<AlumnoEj6>();

            for (int i = 0; i < numeroAlumnos; i++)
            {
                AlumnoEj6 alumno = AgregarAlumnoEj6();
                listAlumnosEj6.Add(alumno);
            }
            string linea = "Nombre".PadRight(25) + "NOTA".PadRight(10) + "Resultado";
            foreach (AlumnoEj6 alumnoEnLista in listAlumnosEj6)
            {
                string aprobadoOReprobado;
                if (alumnoEnLista.notaAlumno >= 40)
                {
                    aprobadoOReprobado = "Aprobado";
                }
                else
                {
                    aprobadoOReprobado = "Reprobado";
                }
                Console.WriteLine($"{alumnoEnLista.apellidoAlumno}, {alumnoEnLista.nombreAlumno} \t {alumnoEnLista.notaAlumno.ToString().PadRight(30)} \t {aprobadoOReprobado.PadRight(30)}");
            }
        }

        static void AgregarElementoALista(int[] array, ref int UltPos)
        {
            UltPos++;
            int numeroAAgregar = NumeroValido("Ingrese el numero a agregar");
            array[UltPos] = numeroAAgregar;
        }

        static void OrdenarLista(int[] array, ref int UltPos)
        {
            for (int i = 0; i < UltPos; i++)
            {
                for (int j = 0; j < UltPos - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temporal = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temporal;
                    }
                }
            }
        }

        static void BorrarElementoDeLaLista(int[] array, ref int UltPos)
        {
            int numeroIndice = NumeroValido("Ingrese el indice que quiere borrar del array");
            array[numeroIndice] = 0;
        }

        static void Ejercicio7()
        {
            Console.WriteLine("Dada long maxima de una lista ordenada en MaxPos y cantidad realmente ocupada UltPos");
            Console.WriteLine("Agregar y borrar elementos de la lista, mantener lista ordenada");
            Console.WriteLine("Agregar menu: agregar elementos, borrar elementos, mostrar lista y salir");


            int MaxPos = NumeroValido("Cantidad maxima del array");
            int[] array = new int[MaxPos + 1];
            int UltPos = NumeroValido("Ultima posicion actual del array");
            if (UltPos > 0)
            {
                for (int i = 0; i <= UltPos; i++)
                {
                    array[i] = NumeroValido($"Ingrese el numero para el indice {i}");
                }
            }
            OrdenarLista(array, ref UltPos);

            int numeroIngresado;
            do
            {
                Console.WriteLine("Si desea agregar elementos presione 1");
                Console.WriteLine("Si desea borrar elementos presione 2");
                Console.WriteLine("Si desea mostrar la lista presione 3");
                Console.WriteLine("Si desea salir presione 0");
            } while (!int.TryParse(Console.ReadLine(), out numeroIngresado) && (numeroIngresado != 1 || numeroIngresado != 2 || numeroIngresado != 3 || numeroIngresado != 0));

            if (numeroIngresado == 1)
            {
                AgregarElementoALista(array, ref UltPos);
                OrdenarLista(array, ref UltPos);
            }
            else if (numeroIngresado == 2)
            {

            }
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
        }

        /*static int[] AlgoritmoBurbuja(int[] listaNumeros)
        {
            int cantidad = listaNumeros.Length;
            bool cambieOrdenamiento = false;
            int temporal = 0;
            int i = 0;
            while (i < cantidad && cambieOrdenamiento)
            {
                cambieOrdenamiento = false;
                for(int j = 0; j < cantidad - 1; j++)
                {
                    cambieOrdenamiento |= true;
                    temporal = listaNumeros[j];
                    listaNumeros[j] = listaNumeros[j + 1];
                    listaNumeros[j+1] = temporal;

                    Console.WriteLine();
                }
            }
            return listaNumeros;
        } */

        //STRUCT
        //ARCHIVOS
        //LISTAS
        // PROYECTO
        // HACER APPLICACION MENU COMO PROYECTO SUBIDO AL AULA
        // 3 ELEMENTOS ALUMNOS MAT INSCRIP
        // INSCP ALUMNO ANOTADO Y NOTA FINAL
        // METODO BURBUJA ORDENAR NOTAS FINALES DE UNA MATERIA
        // CON ABM
        // PROGRAMA NO TERMINA AL INGRESAR EL PRIMER DATO
        // LEGAJO NO SE PUEDE MODIFICAR
        // INSCRIBIR A MATERIA, ACTUALIZAR NOTA
        // EXISIST A MANO
        // PACIAL 19 MIERCOLES ARCHIVOS STRUC LISTA
        // 26 RECUPERATORIO
        // PROYECTO 26

        static void Main(string[] args)
        {
            Ejercicio7();
        }
    }
}
