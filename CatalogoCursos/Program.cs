// Program.cs (Búsqueda por ID)

using System;
using System.Collections.Generic;
using System.Linq; // Necesario para el método FirstOrDefault()

class Program
{
    // Definición de la estructura de datos (misma lista estática de cursos)
    static List<(int id, string name, string area)> Courses = new List<(int id, string name, string area)>() {
        (1, "Algoritmos I", "CS"),
        (2, "Introducción a la Programación", "CS"),
        (3, "Matemática Discreta", "Math")
    };

    static void Main()
    {
        Console.WriteLine("Catálogo de Cursos Demo");

        // Muestra todos los IDs disponibles para facilitar la prueba
        Console.WriteLine("Cursos disponibles (ID): 1, 2, 3");
        Console.Write("Ingrese el ID del curso a buscar: ");

        // Lee la entrada del usuario
        string input = Console.ReadLine();

        // Intenta convertir la entrada a un número entero (ID)
        if (int.TryParse(input, out int courseId))
        {

            // Busca el primer curso que coincida con el ID ingresado
            var result = Courses.FirstOrDefault(c => c.id == courseId);

            // Verifica si se encontró el curso
            if (result.name != null)
            {
                // Si se encontró, imprime los detalles
                Console.WriteLine($"\n--- Curso Encontrado ---");
                Console.WriteLine($"ID: {result.id}");
                Console.WriteLine($"Nombre: {result.name}");
                Console.WriteLine($"Área: {result.area}");
                Console.WriteLine("------------------------\n");
            }
            else
            {
                // Mensaje si no se encuentra el ID
                Console.WriteLine($"\nError: No se encontró un curso con ID {courseId}.");
            }
        }
        else
        {
            // Mensaje si la entrada no es un número válido
            Console.WriteLine("\nError: Por favor, ingrese un número de ID válido.");
        }
    }
}