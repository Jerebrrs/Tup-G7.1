using System;
using Ejercisio2;
using Ejercisio3;
using Guia7;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Seleccione ele ejercisio de la guia 7.1 que desea ejecutar:\n-Opcion 1: Ejercicio menusalidad entre niñas.\n-Opcion 2: Ejercicio Budines.\n-Opcion 3: Creación patentes.\n-Opcion 0 para no continuar.");
            Console.Write("Ingrese su opción: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int opcion))
            {
                switch (opcion)
                {
                    case 1:
                        var niñas = new Niñas();
                        break;
                    case 2:
                        var budines = new Budines();
                        break;
                    case 3:
                        var patente = new Patentes();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Debe ingresar un número válido.");
            }
    }
}