using System;

namespace experimento_3000 {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("----------------------------------");
      Console.WriteLine("Menu.");
      Console.WriteLine("Opción suma introduce (1)");
      Console.WriteLine("Opción multiplicar introduce (2)");
      Console.WriteLine("Opción dividir introduce (3)");
      Console.WriteLine("Opción resta introduce (4)");
      Console.WriteLine("Salir del menu introduce (0)");
      Console.WriteLine("----------------------------------");

      int opcion = 1, numero1 = 0, numero2 = 0;

      while (opcion != 0) {
        Console.Write("\nIntroduce la opción: ");
        while (!int.TryParse(Console.ReadLine(), out opcion)) {
          Console.WriteLine("ERROR. Introduce un número.");
        }
        if ((opcion > 4 || opcion < 0)) Console.WriteLine("Introduce un número del 0 al 4.");
        if (opcion == 0) Console.WriteLine("Adios :D");
        if (opcion == 1) {
          Console.WriteLine("----------------------------------");
          Console.WriteLine("Suma.");
          Console.WriteLine("----------------------------------");
          Console.Write("Introduce el primer número: ");
          while (!int.TryParse(Console.ReadLine(), out numero1)) {
            Console.WriteLine("ERROR. Introduce un número.");
          }
          Console.Write("Introduce el segundo número: ");
          while (!int.TryParse(Console.ReadLine(), out numero2)) {
            Console.WriteLine("ERROR. Introduce un número.");
          }
          int suma = numero1 + numero2;
          Console.WriteLine("\n" + numero1 + " + " + numero2 + " = " + suma);
        }
        if (opcion == 2) {
          Console.WriteLine("----------------------------------");
          Console.WriteLine("Multiplicar.");
          Console.WriteLine("----------------------------------");
          Console.Write("Introduce el primer número: ");
          while (!int.TryParse(Console.ReadLine(), out numero1)) {
            Console.WriteLine("ERROR. Introduce un número.");
          }
          Console.Write("Introduce el segundo número: ");
          while (!int.TryParse(Console.ReadLine(), out numero2)) {
            Console.WriteLine("ERROR. Introduce un número.");
          }
          int Multiplicar = numero1 * numero2;
          Console.WriteLine("\n" + numero1 + " + " + numero2 + " = " + Multiplicar);
        }
      }
    }
  }
}