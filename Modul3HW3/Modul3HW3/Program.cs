using System;

namespace Modul3HW3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var itemClass1 = new Class1();
            itemClass1.ShowDelegate = Show;

            var itemClass2 = new Class2();
            itemClass2.PowDelegate = itemClass1.Pow;

            var resCalc = itemClass2.Calc(itemClass2.PowDelegate, 8, 2);

            itemClass1.ShowDelegate(resCalc(7));
        }

        public static void Show(bool value)
        {
            Console.WriteLine($"Result: {value}");
        }
    }
}
