using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int grn = 40;
            Console.WriteLine(" Введiть долар: ");
            var dollar = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("dollar " + dollar);
            Console.WriteLine("Долари переведенi в гривнi ");
            Console.WriteLine("Grn " + dollar * grn);

            int grn_2 = 36;
            Console.WriteLine(" Введiть євро: ");
            var euro = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("euro " + euro);
            Console.WriteLine("Євро переведенi в гривнi ");
            Console.WriteLine("Grn " + euro * grn);

        }
    }
}