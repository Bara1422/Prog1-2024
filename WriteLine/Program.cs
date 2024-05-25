namespace WriteLine
{
    internal class Program
    {
        public static string archivo = "test2025.txt";
        public struct Alumno
        {
            public int Legajo;
            public string Nombre;
            public string Apellido;
        }

        public static Alumno LeerAlumno()
        {
            Alumno alumno = new Alumno();
            Console.WriteLine("Ingrese legajo");
            string legajo = Console.ReadLine();
            while (!int.TryParse(legajo, out alumno.Legajo))
            {
                Console.WriteLine("No ingreso un numero entero, Ingrese un numero de legajo:");
                legajo = Console.ReadLine();
            }
            Console.WriteLine("Ingrese nombre");
            alumno.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese apellido");
            alumno.Apellido = Console.ReadLine();

            return alumno;
        }

        public static void EditarAlumno(Alumno alumno)
        {
            List<Alumno> alumnos = RetornarListaAlumnos(archivo);
            if(alumnos.Any(a => a.Legajo == alumno.Legajo))
            {
                for(int i = 0; i< alumnos.Count; i++)
                {
                    if (alumnos[i].Legajo == alumno.Legajo)
                    {
                        Alumno alu = alumnos[i];
                        alu.Nombre = alumno.Nombre;
                        alu.Apellido = alumno.Apellido;
                    }
                }
                EscribirAlumno(alumnos, false);
            }
        }

        public static void EliminarAlumno(int Legajo)
        {
            List<Alumno> alumnos = RetornarListaAlumnos(archivo);
            bool existe = false;
            Alumno borrar = new Alumno();
            foreach (Alumno alumno in alumnos)
            {
                if (alumno.Legajo == Legajo)
                {
                    borrar = alumno;
                    existe = true;
                }
            }
            if (existe)
            {
                alumnos.Remove(borrar);
            }
            EscribirAlumno(alumnos, false);
        }

        static void Main(string[] args)
        {


            Alumno alumno = LeerAlumno();
            List<Alumno> listAlumno = new List<Alumno>();
            listAlumno.Add(alumno);
            EscribirAlumno(listAlumno, true);
            //List<Alumno> ListaAlumnos = new List<Alumno>();
            List<Alumno> listaAlumno = RetornarListaAlumnos(archivo);
            Alumno alumnoEditar = new Alumno();
            alumnoEditar.Nombre = "Ricardo";
            alumnoEditar.Apellido = "Stickar";
            alumnoEditar.Legajo = 1;

            foreach (Alumno alumnoEnLista in listaAlumno)
            {
                Console.WriteLine(alumnoEnLista.Legajo + ", " + alumnoEnLista.Nombre + ", " + alumnoEnLista.Apellido);
            }
            Console.WriteLine("Hello, World!");
        }

        public static List<Alumno> RetornarListaAlumnos(string archivo)
        {
            List<Alumno> listaAlumnos = new List<Alumno>();
            using (StreamReader sr = new StreamReader(archivo))
            {

                string? linea = sr.ReadLine();

                while (linea != null)
                {
                    string[] alumnoArchivo = linea.Split(',');
                    Alumno alumnoStruct = new Alumno();
                    alumnoStruct.Legajo = int.Parse(alumnoArchivo[0]);
                    alumnoStruct.Nombre = alumnoArchivo[1];
                    alumnoStruct.Apellido = alumnoArchivo[2];
                    listaAlumnos.Add(alumnoStruct);
                    //ListaAlumnos.OrderBy( x => x.Apellido ).ToList(); ordenar por apellido
                    linea = sr.ReadLine();
                }
            }
            return listaAlumnos;
        }

        private static void EscribirAlumno(List<Alumno> alumnos, bool concatenar)
        {
            using (StreamWriter escritor = new StreamWriter(archivo, concatenar))
            {
                foreach (Alumno alumno in alumnos)
                {
                    escritor.WriteLine(alumno.Legajo + ", " + alumno.Nombre + ", " + alumno.Apellido);
                }
            }
        }
    }
}
}
