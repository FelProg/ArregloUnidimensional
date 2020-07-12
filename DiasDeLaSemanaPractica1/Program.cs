using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

//Hacer una aplicación en C# de consola, donde se ingrese el número del día de la semana 
//(del 1 al 7) y se muestre en pantalla el nombre del día correspondiente al número ingresado.

//Nota: si no se ingresa ningún número se deben mostrar todos los días.


namespace DiasDeLaSemanaPractica1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaración del arreglo.
            string[] diasDeLaSemana = new string[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

            //se obtiene solo la opción valida de la función local.    
            int op = CapturaDeOpcion(diasDeLaSemana);
            Console.WriteLine($"\nEl día seleccionado es : {diasDeLaSemana[op-1]}");
            Console.WriteLine($"Presione cualquier tecla para salir... Muchas gracias");

            //el argumento true es para que no se vea el valor al teclearlo.
            Console.ReadKey(true);
        }

        static int CapturaDeOpcion(string[] diasDeLaSemana)
        {
            try
            {
                Console.Clear();
                Console.Write($"Seleccione una opción para desplegar del siguiente menú: \n");

                //Despliega menú recorriendo los datos en el arreglo.
                for (int i = 0; i < diasDeLaSemana.Length; i++)
                {
                    Console.WriteLine($"{i + 1} : {diasDeLaSemana[i]}");
                }
                Console.Write("Opcion:   ");

                //Obtiene la entrada del usuario.
                int op = Int32.Parse(Console.ReadLine());
                
                //devuelve solo los valores del 1 al 7  o se vuelve a llamar a si misma.
                return (op > 0 && op <8) ? op : CapturaDeOpcion(diasDeLaSemana);
            }
            catch
            {
                //se vuelve a llamar a si misma
                return CapturaDeOpcion(diasDeLaSemana);
            }
           
        }

    }
}
