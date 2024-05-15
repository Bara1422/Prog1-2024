using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practico3
{
    internal class Program
    {
        static int LeerEnero(string mensaje)
        {


            Console.WriteLine(mensaje);
            int numero = 0;
            bool esEntero = false;
            while (!esEntero)
            {
                string datoEntrada = Console.ReadLine();
                //try parse (En ingles significa, intentar convertir)
                //es una funcion que recibe como parametro un dato de entrada de tipo string
                //y otro parametro, en este caso de salida umero entero
                //lo convierte y lo asigna a numero
                //si pasa esto TryParse retorna true, sino retorna false y numero no tiene asignacion
                //bool boolcon = false; string booldata = "true"; bool.TryParse(booldata, out boolcon);
                //double numero = 0.0;  string datoEntrada = "0.98";   double.TryParse(datoEntrada, out numero);

                if (!int.TryParse(datoEntrada, out numero))

                {

                    Console.WriteLine("El numero no es un entero. Por favor ingreselo de nuevo:");
                }
                else
                {
                    esEntero = true;
                }
            }

            return numero;
        }

        static void Main(string[] args)
        {
            /*
            //Ejercicio 1a
            int numero1a;
            Console.WriteLine("-----------1a numero par o impar------------");

            Console.WriteLine("Ingrese un numero");
            numero1a = Convert.ToInt32(Console.ReadLine());
            if (numero1a % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }

            //Ejercicio 1b
            Console.WriteLine("------------1b sumar 2 numeros-----------");
            int a;
            int b;
            int sumaAyB;
            Console.WriteLine("Ingrese el primer numero");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            b = Convert.ToInt32(Console.ReadLine());
            sumaAyB = a + b;
            Console.WriteLine("La suma es: " + sumaAyB);

            //Ejercicio 1c
            Console.WriteLine("------------1c calculo 30% de x-----------");
            int x;
            double porcentaje;
            Console.WriteLine("Esciba un numero");
            x = Convert.ToInt32(Console.ReadLine());
            porcentaje = x * 0.3;
            Console.WriteLine("El 30% de " + x + " es: " + porcentaje);

            //Ejercicio 1d
            Console.WriteLine("------------1d determinar si num1 es mayor a num2-----------");
            int num1;
            int num2;
            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segudno numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("El primer numero es mayor al segundo");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("El segundo numero es mayor al primero");
            }
            else
            {
                Console.WriteLine("Los numeros son iguales");
            }

            //Ejercicio 1e
            Console.WriteLine("------------1e Equivalente DM en pies----------");
            float distanciaDm;
            float dmToM;
            float meterToInch;
            float inchToFeet;
            Console.WriteLine("Ingrese una distancia en DM");
            distanciaDm = float.Parse(Console.ReadLine());
            dmToM = distanciaDm / 10;
            meterToInch = dmToM * 39.37f;
            inchToFeet = meterToInch / 12;
            Console.WriteLine(distanciaDm + " dm expresados en pies es: " + inchToFeet);

            //Ejercicio 1f
            Console.WriteLine("------------1f cantidad billetes de cada denominacion-----------");
            int billete50 = 0;
            int billete25 = 0;
            int billete10 = 0;
            int billete5 = 0;
            int billete1 = 0;
            int precioProducto = 0;
            int precioPago = 0;
            int vuelto = 0;
            Console.WriteLine("Ingrese el precio del producto");
            precioProducto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese dinero abonado");
            precioPago = Convert.ToInt32(Console.ReadLine());
            if (precioPago > precioProducto)
            {
                vuelto = precioPago - precioProducto;
            }
            else
            {
                Console.WriteLine("El precio del producto es superior al monto pagado");
            }

            if (vuelto >= 50)
            {
                billete50 = vuelto / 50;
                vuelto = vuelto % 50;
            }
            if (vuelto >= 25)
            {
                billete25 = vuelto / 25;
                vuelto = vuelto % 25;
            }
            if (vuelto >= 10)
            {
                billete10 = vuelto / 10;
                vuelto = vuelto % 10;
            }
            if (vuelto >= 5)
            {
                billete5 = vuelto / 5;
                vuelto = vuelto % 5;
            }
            if (vuelto >= 1)
            {
                billete1 = vuelto / 1;
                vuelto = 0;
            }
            Console.WriteLine("El vuelto es de: " + billete50 + " billetes de 50, más " + billete25 + " billetes de 25, más " + billete10 + " billetes de 10, más " + billete5 + " billetes de 5, más " + billete1 + " billetes de 1");

            //Ejercicio 1g
            Console.WriteLine("-----------------1g diferencia entre a y b es mayor que c --------------------");
            int ag;
            int bg;
            int cg;
            int cuentag;
            Console.WriteLine("Si (a - b) > c => a * b | (a -b) < c => a / b");
            Console.WriteLine("Ingrese un numero para a");
            ag = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero para b");
            bg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero para c");
            cg = Convert.ToInt32(Console.ReadLine());
            if (ag - bg > cg)
            {
                cuentag = ag * bg;
            }
            else
            {
                cuentag = ag / bg;
            }
            Console.WriteLine(cuentag);


            //Ejercicio 1h
            Console.WriteLine("-----------------1h obra social--------------------");
            char ah = 'A';
            char bh = 'B';
            char ch = 'C';
            char tipoSocio;
            float costoTratamiento;
            do
            {
                Console.WriteLine("Ingrese su categoria A / B / C");
                tipoSocio = char.ToUpper(char.Parse(Console.ReadLine()));
            } while (tipoSocio != 'A' && tipoSocio != 'B' && tipoSocio != 'C');
            Console.WriteLine("Ingrese costo tratamiento");
            costoTratamiento = Convert.ToSingle(Console.ReadLine());
            if (tipoSocio == ah)
            {
                costoTratamiento = costoTratamiento - costoTratamiento * 0.5f;
            }
            else if (tipoSocio == bh)
            {
                costoTratamiento = costoTratamiento - costoTratamiento * 0.35f;
            }

            Console.WriteLine("El costo a pagar es: " + costoTratamiento);


            //Ejercicio 1i
            Console.WriteLine("-----------------1i año bisiesto --------------------");
            int anio = 0;
            Console.WriteLine("Escribe un año");
            anio = Convert.ToInt32(Console.ReadLine());
            if ((anio % 4 == 0) && (anio % 100 != 0 || anio % 400 == 0))
            {
                Console.WriteLine("El año " + anio + " es bisiesto");
            }
            else
            {
                Console.WriteLine("El año " + anio + " no es bisiesto");
            }

            //Ejercicio 2
            Console.WriteLine("----------------- 2: 3 notas alumnos --------------------");
            float nota1;
            float nota2;
            float nota3;
            float promedio;
            Console.WriteLine("Ingrese la primera nota");
            nota1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota");
            nota2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera nota");
            nota3 = Convert.ToSingle(Console.ReadLine());
            promedio = (nota1 + nota2 + nota3) / 3;
            if (promedio >= 6)
            {
                Console.WriteLine("Cursa y promociona");
            }
            else if (promedio >= 4)
            {
                Console.WriteLine("Cursa y rinde examen final");
            }
            else
            {
                Console.WriteLine("No cursa");
            }


            //Ejercicio 3
            Console.WriteLine("----------------- 3: edad actual usuario --------------------");
            int diaNacimiento = 0;
            int mesNacimiento = 0;
            int anioNacimiento = 0;
            int edadActual = 0;
            Console.WriteLine("Ingrese el año de nacimiento");
            anioNacimiento = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el dia de nacimiento");
            diaNacimiento = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el mes de nacimiento");
            mesNacimiento = Convert.ToInt32(Console.ReadLine());
            int anioActual = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            int mesActual = Convert.ToInt32(DateTime.Now.ToString("MM"));
            int diaActual = Convert.ToInt32(DateTime.Now.ToString("dd"));
            Console.WriteLine(anioActual);
            if (mesNacimiento == mesActual && diaNacimiento == diaActual)
            {
                Console.WriteLine("Feliz cumpleaños");
            }

            if (mesActual > mesNacimiento || (mesActual >= mesNacimiento && diaActual >= diaNacimiento))
            {
                edadActual = anioActual - anioNacimiento;
            }
            else
            {
                edadActual = anioActual - anioNacimiento - 1;

            }
            Console.WriteLine("La edad actual es " + edadActual);


            //Ejercicio 4
            Console.WriteLine("----------------- 4: latas pintura--------------------");
            float anchoVentana = 1.2f;
            float altoVentana = 1.5f;
            float anchoPuerta = 0.75f;
            float altoPuerta = 2f;
            float anchoHabitacion = 0;
            float altoHabitacion = 0;
            float largoHabitacion = 0;
            int cantidadVentanas = 0;
            int cantidadPuertas = 0;
            float superficiePared = 0;
            float superficieVentanas = 0;
            float superficiePuertas = 0;
            float superficieAPintar = 0;
            int cantidadLatas = 0;
            Console.WriteLine("Ingrese cantidad puertas");
            cantidadPuertas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad ventanas");
            cantidadVentanas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese ancho pared");
            anchoHabitacion = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese alto pared");
            altoHabitacion = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese largo habitacion");
            largoHabitacion = Convert.ToInt32(Console.ReadLine());
            if (cantidadPuertas > 0)
            {
                superficiePuertas = (altoPuerta * anchoPuerta) * cantidadPuertas;
            }
            if (cantidadVentanas > 0)
            {
                superficieVentanas = (altoVentana * anchoVentana) * cantidadVentanas;
            }
            superficiePared = 2 * (anchoHabitacion + largoHabitacion) * altoHabitacion; // salvo piso y techo
            superficieAPintar = superficiePared - superficiePuertas - superficieVentanas;
            cantidadLatas = (int)Math.Ceiling(superficieAPintar / 12);
            Console.WriteLine("Se necesitan " + cantidadLatas + " latas");


            //Ejercicio 5
            Console.WriteLine("----------------- 5: total a pagar y descuento en la pantalla --------------------");
            char formaDePago;
            float montoDeCompra = 0;
            float montoDescontado = 0;
            do
            {
                Console.WriteLine("Ingrese forma de pago E (efectivo) / T (tarjeta)/ O (otros)");
                formaDePago = char.ToUpper(char.Parse(Console.ReadLine()));
            }
            while (formaDePago != 'E' && formaDePago != 'T' && formaDePago != 'O');
            Console.WriteLine("Ingrese monto a pagar");
            montoDeCompra = float.Parse(Console.ReadLine());
            if (formaDePago == 'E')
            {
                montoDescontado = montoDeCompra * 0.2f;
            }
            else if (formaDePago == 'T')
            {
                if (montoDeCompra > 25000)
                {
                    montoDescontado = montoDeCompra * 0.1f;
                }
            }

            montoDeCompra = montoDeCompra - montoDescontado;
            Console.WriteLine("Descuento: " + montoDescontado);
            Console.WriteLine("Total a pagar: " + montoDeCompra);

            //Ejercicio 6
            Console.WriteLine("----------------- 6: perimetro o area--------------------");

            float resultado = 0;
            float ladoCuadrado = 0;
            int opcionElegida = 0;
            Console.WriteLine("Ingrese el lado de un cuadrado en cm");
            ladoCuadrado = float.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Ingrese una opcion 1 = muestra perímetro | 2 = muestra área");
                opcionElegida = Convert.ToInt32(Console.ReadLine());
            }
            while (opcionElegida != 1 && opcionElegida != 2);
            if (opcionElegida == 1)
            {
                resultado = ladoCuadrado * 4;
            }
            else
            {
                resultado = ladoCuadrado * ladoCuadrado;
            }
            Console.WriteLine("El resultado es: " + resultado);


            //Ejercicio 7
            Console.WriteLine("----------------- 7: menor y mayor de 3 numeros--------------------");
            int numero11;
            int numero12;
            int numero13;
            int numeroMayor;
            int numeroMenor;
            Console.WriteLine("Ingrese el primer numero");
            numero11 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            numero12 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            numero13 = Convert.ToInt32(Console.ReadLine());
            if (numero11 >= numero12 && numero11 >= numero13)
            {
                numeroMayor = numero11;
                if (numero12 > numero13)
                {
                    numeroMenor = numero13;
                }
                else
                {
                    numeroMenor = numero12;
                }
            }
            else if (numero12 >= numero11 && numero12 >= numero13)
            {
                numeroMayor = numero12;
                if (numero11 > numero13)
                {
                    numeroMenor = numero13;
                }
                else
                {
                    numeroMenor = numero11;
                }
            }
            else
            {
                numeroMayor = numero13;
                if (numero12 > numero11)
                {
                    numeroMenor = numero11;
                }
                else
                {
                    numeroMenor = numero12;
                }
            }


            Console.WriteLine("El numero mayor es: " + numeroMayor + " y el numero menor es: " + numeroMenor);


            //Ejercicio 8
            Console.WriteLine("----------------- 8: tipo de triangulo--------------------");
            int lado1;
            int lado2;
            int lado3;

            Console.WriteLine("Ingrese el primer lado del triangulo");
            lado1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo lado del triangulo");
            lado2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer lado del triangulo");
            lado3 = Convert.ToInt32(Console.ReadLine());

            if (lado1 != lado2)
            {
                if (lado1 != lado3 && lado2 != lado3)
                {
                    Console.WriteLine("El triangulo es escaleno");
                }
                else
                {
                    Console.WriteLine("El triangulo es isosceles");
                }
            }
            else
            {
                if (lado1 != lado3)
                {
                    Console.WriteLine("El triangulo es isosceles");
                }
                else
                {
                    Console.WriteLine("El triangulo es equilatero");
                }
            }
            */
            /*
            TryParse
            Console.WriteLine("Hola");
            bool numerito = int.TryParse(Console.ReadLine(), out int res);
            if (!numerito) Console.WriteLine("Numero no valido");
            Console.WriteLine(res);
            */

            /*
             TryParse con repeat
            Valores x ref   
            int cuarentaydos = 42;
            int ocho = 8;
            Console.WriteLine(cuarentaydos);
            Console.WriteLine(ocho);

            static void suma2nums(ref int cuarentaydos, ref int ocho)
            {
                cuarentaydos += ocho;
            }

            Console.WriteLine(cuarentaydos);
            suma2nums(ref cuarentaydos, ref ocho);
            Console.WriteLine(cuarentaydos);
            Console.WriteLine(ocho);
            */
            /*
            Console.WriteLine("Escriba un numero");
            bool numerito = false;
            do
            {
               numerito = int.TryParse(Console.ReadLine(), out int res);
                if (!numerito)
                {
                    Console.WriteLine("Numero no valido");
                }
                else
                {

                    Console.WriteLine("El numero es {0}", res);
                }
            }
            while (!numerito);
            
            

            Console.Write("Ingresa el primer numero: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = num1;
            string resultado = "";
            for(int i = 2; i < num2 / 2; i++)
            {
                bool esModuloCero = true;
                int cantidad = 0;
                while(esModuloCero)
                {
                    int modulo = num1 % 1;
                    if(modulo == 0)
                    {
                        cantidad++;
                        num1 = num1 / i;
                    }
                    else
                    {
                        esModuloCero = false;
                    }
                }
                if(cantidad > 0)
                {
                    if(resultado == "")
                    {
                        resultado = resultado + i + "^" + cantidad + " ";
                    }
                    else
                    {
                        resultado = resultado + " * " + i + " a la " + cantidad + " ";
                    }
                    
                }
                if (num1 > 1)
                {
                    if(resultado == "")
                    {
                        resultado = "" + num1;
                    }
                }else
                {
                    resultado = resultado + " * " + num2;
                }
            }
            

            bool esValido = false;
            int numeroIngresado;
            do
            {
                Console.WriteLine("ingrese numero valido");
                esValido = int.TryParse(Console.ReadLine(), out numeroIngresado);
            } while (!esValido);
            int cantidad = 0;
            for (int i = 2; i < numeroIngresado; i++)
            {
                while(numeroIngresado % i == 0)
                {
                    cantidad++;
                    numeroIngresado = numeroIngresado / 2;
                }
            }*/
            /*
            int num1 = LeerEnero("Ingrese el numero a descomponer en numeros primos: ");

            //seteo valores iniciales
            int recorrerHastaNumero = num1 / 2;
            string resultado = "";
            //Caso especial si num1==1
            if (num1 == 1)
            {
                Console.WriteLine(num1);
            }
            else
            {
                //Recorro los posibles numero, que se que son desde 2 a la mitad de num1

                for (int i = 2; i < recorrerHastaNumero; i++)
                {
                    //Seteo la condicion de corte si es divisor, esModuloCero == true
                    bool esModuloCero = true;
                    //Reinicio la cantidad para que sea cero 
                    int cantidad = 0;


                    //Mientras  num1 mod i == 0, sumo en cantidad, todas las veces que num1 es divisible 
                    //por i, por ejemplo 8, es igual a 2 al cubo entonces i == 2 y cantidad tiene 3
                    //cuando modulo es distinto a cero significa q num1 ya no es mas divisible por i
                    while (esModuloCero)
                    {
                        int modulo = num1 % i;
                        if (modulo == 0)
                        {
                            cantidad++;
                            num1 = num1 / i;
                        }
                        else
                        {
                            esModuloCero = false;
                        }


                    }
                    //para descartar en el resultado los numeros que no son divisibles 
                    //le agrego la condicion cantidad > 0

                    if (cantidad > 0)
                    {
                        //este if tiene dos partes, una es el caso de inicio
                        if (resultado == "")
                        {
                            resultado = i + "^" + cantidad + " ";

                        }
                        //y este es el caso que tengo que concatenar los resultados anteriores
                        else
                        {
                            resultado = resultado + " * " + i + "^" + cantidad + " ";

                        }
                    }

                }
                Console.WriteLine(resultado);
            }
            bool esValido = false;
            int numero;
            do
            {
                Console.WriteLine("Ingrese un numero válido");
                esValido = int.TryParse(Console.ReadLine(), out numero);
                
            } while (esValido == false);
            

            string resultado = "";
            int divisor = 2; // Empezamos con el primer número primo

            if(numero == 1)
            {
                Console.WriteLine("1^1");
            }
            while (numero > 1)
            {
                int contador = 0;

                while (numero % divisor == 0)
                {
                    contador++;
                    numero /= divisor;
                }

                if (contador > 0)
                {
                    resultado += $"{divisor}^{contador}";

                    if (numero > 1)
                    {
                        resultado += " * ";
                    }
                }

                divisor++;
            }
            Console.WriteLine(resultado);
            
            int numero;
            bool esEntero;
            do
            {
                Console.WriteLine("Escriba un número");
                esEntero = int.TryParse(Console.ReadLine(), out numero);
            } while (esEntero == false);

            string resultado = "";
            int divisor = 2;

            while (numero > 1)
            {
                int cantidad = 0;
                while (numero % divisor == 0)
                {
                    cantidad++;
                    numero = numero / divisor;
                }
                if(cantidad > 0)
                {
                    resultado = resultado + $"{divisor}^{cantidad}";

                    if(numero > 1)
                    {
                        resultado = resultado + " * ";
                    }
                }
                divisor++;
            }
            Console.WriteLine(resultado);
            
            int numero;
            bool esEntero;

            do
            {
                Console.WriteLine("Ingrese un numero entero por favor.");
                esEntero = int.TryParse(Console.ReadLine(), out numero);
            } while (esEntero == false);

            string resultado = "";

            for(int i = 2; i <= numero; i++)
            {
                int cantidad = 0;
                while(numero % i == 0)
                {
                    cantidad++;
                    numero = numero / i;
                }
                if(cantidad > 0)
                {
                    resultado = resultado + $"{i}^{cantidad}";
                    if(numero > 1)
                    {
                        resultado = resultado + $" * ";
                    }
                }
            }
            Console.WriteLine(resultado);

            


            Console.WriteLine("Ingrese el primer numero");
            int numero1 = NumeroValido();
            Console.WriteLine("Ingrese el segundo numero");
            int numero2 = NumeroValido();
            int numeroMasGrande = 0;
            if(numero1 > numero2)
            {
                numeroMasGrande = numero1;
            }else
            {
                numeroMasGrande = numero2;
            }
            int numeroActual;
            int mcm = 0;
            for(int i = 1; i <= numeroMasGrande; i++)
            {
                numeroActual = numero1 * i;
                if(numeroActual % numero2 == 0)
                {
                    mcm = numeroActual;
                    break;
                }
            }
            Console.WriteLine(mcm);


        }
        static int NumeroValido()
        {
            int numero = 0;
            bool esValido;
            do
            {
                esValido = int.TryParse(Console.ReadLine(), out numero);
                if (!esValido)
                {
                    Console.WriteLine("Ingrese un numero valido");
                }
            } while(esValido == false);
            return numero;
            */
            {
                Validacion();
            }

            static void Descomposicion(int numDesc)
            {
                int i = 0;
                int sumaFactores;
                for (i = 2; i <= numDesc; i++)
                {

                    while (numDesc % i == 0)
                    {

                        Console.WriteLine(numDesc + "   ");

                        Console.WriteLine("     " + i);

                        numDesc = numDesc / i;

                        sumaFactores += i;



                    }



                }

                Console.WriteLine("La suma de factores es:" + sumaFactores);
            }
            static void Validacion()
            {
                string dato;
                int numero;
                Console.WriteLine("Ingrese un numero entero positivo");
                dato = Console.ReadLine();
                if (int.TryParse(dato, out numero))
                {

                    descomposicion(numero);
                    if (numero < 0)
                    {
                        numero = numero * -1;

                    }
                }
                else
                {
                    Console.WriteLine("Número erroneo, porfavor ingreselo nuevamente.");
                    Validacion();

                }
            }
        }
    }

}
