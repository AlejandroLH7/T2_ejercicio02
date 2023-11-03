using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_ejercicio02
{
    class Program
    {
        
            static string[] notas = new string[100];
            static int cantidadNotas = 0;

            static void Main()
            {
                while (true)
                {
                    Console.Clear();
                    MostrarMenu();

                    if (int.TryParse(Console.ReadLine(), out int opcion))
                    {
                        switch (opcion)
                        {
                            case 1:
                                RegistrarNotas();
                                break;
                            case 2:
                                HallarNota("Nota mas alta");
                                break;
                            case 3:
                                HallarNota("Nota mas baja");
                                break;
                            case 4:
                                VerNotasRegistradas();
                                break;
                            default:
                                Console.WriteLine("Opción inválida. Intente nuevamente.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                    }

                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }
            }

            static void MostrarMenu()
            {
                Console.WriteLine("================================");
                Console.WriteLine("Ingrese de estudiantes: ");
                Console.WriteLine("================================");
                Console.WriteLine("1: Ingresar nota");
                Console.WriteLine("2: Nota mas alta");
                Console.WriteLine("3: Nota mas baja");
                Console.WriteLine("4: Ver lista de estudiantes");
                Console.WriteLine("================================");
                Console.Write("Ingrese una opción: ");
            }

            static void RegistrarNotas()
            {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine("Ingresar Nota");
                Console.WriteLine("================================");
                Console.Write("Ingrese el nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese la nota: ");
                string nota = Console.ReadLine();

                if (cantidadNotas < notas.Length)
                {
                    notas[cantidadNotas] = $"{nombre}-{nota}";
                    cantidadNotas++;

                    Console.WriteLine("================================");
                    Console.WriteLine("!Guardado!");
                    Console.WriteLine("================================");
                    Console.WriteLine("1: Agregar uno más | 2: Volver");
                    Console.WriteLine("================================");
                    Console.Write(">");

                    if (int.TryParse(Console.ReadLine(), out int opcion))
                    {
                        if (opcion == 1)
                        {
                            RegistrarNotas();
                        }
                        else if (opcion == 2)
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Opción inválida. Volviendo al menú principal.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opción inválida. Volviendo al menú principal.");
                    }
                }
                else
                {
                    Console.WriteLine("Se ha alcanzado el límite de notas.");
                    Console.WriteLine("================================");
                    Console.WriteLine("1: Regresar");
                    Console.WriteLine("================================");
                    Console.Write("Ingrese una opción: ");
                    int opcion = int.Parse(Console.ReadLine());
                }
            }

            static void HallarNota(string mensaje)
            {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine(mensaje);
                Console.WriteLine("================================");
                Console.Write("Estudiante: ");
                string estudiante = Console.ReadLine();
                Console.Write("Nota: ");
                string nota = Console.ReadLine();

                Console.WriteLine("================================");
                Console.WriteLine("Presione enter para volver");
                Console.WriteLine("================================");
                Console.Write(">");
                Console.ReadLine();
            }

            static void VerNotasRegistradas()
            {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine("Lista de estudiantes");
                Console.WriteLine("================================");

                for (int i = 0; i < cantidadNotas; i++)
                {
                    string[] datos = notas[i].Split('-');
                    string estudiante = datos[0];
                    string nota = datos[1];
                    Console.WriteLine($"{estudiante} | {nota}");
                }

                Console.WriteLine("================================");
                Console.WriteLine("Presione enter para volver");
                Console.WriteLine("================================");
                Console.Write(">");
                Console.ReadLine();
            }
        
        
    }
}