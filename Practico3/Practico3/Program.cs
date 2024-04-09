namespace Practico3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
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
            else
            {
                Console.WriteLine("El segundo numero es mayor al primero");
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
            if(vuelto >= 1)
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
            Console.WriteLine("Ingrese un numero para ag");
            ag = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero para bg");
            bg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero para cg");
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
            Console.WriteLine("Ingrese su categoria A / B / C");
            tipoSocio = char.ToUpper(char.Parse(Console.ReadLine()));
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
            int dia = 0;
            int mes = 0;
            int anioNacimiento = 0;
            int edadActual = 0;
            Console.WriteLine("Ingrese el año de nacimiento");
            anioNacimiento = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el dia de nacimiento");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el mes de nacimiento");
            mes = Convert.ToInt32(Console.ReadLine());
            int actualYear = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            int actualMonth = Convert.ToInt32(DateTime.Now.ToString("MM"));
            int actualDay = Convert.ToInt32(DateTime.Now.ToString("dd"));
            Console.WriteLine(actualYear);
            if (mes == actualMonth && dia == actualDay)
            {
                Console.WriteLine("Feliz cumpleaños");
            }

            if (actualMonth > mes || (actualMonth>=mes && actualDay >= dia) )
            {
                edadActual = actualYear - anioNacimiento;
            }
            else
            {
                edadActual = actualYear - anioNacimiento - 1;

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
            if(cantidadPuertas > 0)
            {
                superficiePuertas = (altoPuerta * anchoPuerta) * cantidadPuertas;
            }
            if(cantidadVentanas > 0) 
            {
                superficieVentanas = (altoVentana * anchoVentana) * cantidadVentanas;
            }
            superficiePared = 2 * (anchoHabitacion + largoHabitacion) * altoHabitacion; // salvo piso y techo
            superficieAPintar = superficiePared - superficiePuertas - superficieVentanas;
            cantidadLatas = (int)Math.Ceiling(superficieAPintar / 12);
            Console.WriteLine("Se necesitan " +  cantidadLatas + " latas");
            

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
                Console.WriteLine(opcionElegida);
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
                }else
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
                if(numero12 > numero11)
                {
                    numeroMenor = numero11;
                } else
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

            if(lado1 != lado2)
            {
                if(lado1 != lado3 && lado2 != lado3)
                {
                    Console.WriteLine("El triangulo es escaleno");
                }
                else
                {
                    Console.WriteLine("El triangulo es isosceles");
                }
            } else
            {
                if(lado1 != lado3)
                {
                    Console.WriteLine("El triangulo es isosceles");
                }else
                {
                    Console.WriteLine("El triangulo es equilatero");
                }
            }
            

        }
    }
}
