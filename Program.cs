using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {   







            string h, b;
            double trocah, trocab;
            double result;

            Console.WriteLine();
            Console.ForegroundColor=ConsoleColor.DarkMagenta;
            Console.WriteLine("--- AreaTrianguloRet ---");
            Console.WriteLine("Digite a base e a altura do Triângulo Retângulo, para que seja dada a área...");
            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("- Base:");
            Console.ForegroundColor=ConsoleColor.DarkMagenta;
            b = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("- Altura:");
            Console.ForegroundColor=ConsoleColor.DarkMagenta;
            h = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine();

            trocah = Convert.ToDouble(h);
            trocab = Convert.ToDouble(b);

            result = trocah*trocab/2;

            Console.Beep();
            Console.WriteLine("- Área:");
            Console.ForegroundColor=ConsoleColor.DarkMagenta;
            Console.WriteLine($"{result:N}");
            Console.ResetColor();








        }
    }
}
