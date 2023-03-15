using System;

class Program
{
    static void Main()
    {
        // Ejemplo de arreglo unidimensional
        int[] arreglo1D = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Arreglo unidimensional:");
        Console.WriteLine($"Longitud: {arreglo1D.Length}");
        Console.WriteLine($"Primer elemento: {arreglo1D[0]}");
        Console.WriteLine($"Último elemento: {arreglo1D[arreglo1D.Length - 1]}");

        // Ejemplo de arreglo bidimensional
        int[,] arreglo2D = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
        Console.WriteLine("\nArreglo bidimensional:");
        Console.WriteLine($"Longitud dimensión 1: {arreglo2D.GetLength(0)}");
        Console.WriteLine($"Longitud dimensión 2: {arreglo2D.GetLength(1)}");
        Console.WriteLine($"Primer elemento: {arreglo2D[0, 0]}");
        Console.WriteLine($"Último elemento: {arreglo2D[arreglo2D.GetLength(0) - 1, arreglo2D.GetLength(1) - 1]}");

        Console.ReadLine();
    }
}
