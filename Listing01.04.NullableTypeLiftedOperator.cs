using System;

namespace NullableType.Chapter01.Listing01_04
{
    public class Program
    {
        public static void Main()
        {
            int? x = 100;
            int? y = null;
            int? z = 200;

            x++;
            System.Console.WriteLine("x = " + x + " in x++");

            x = x * z;
            System.Console.WriteLine("x = " + x + " in x = x * z");

            x = x + y;
            System.Console.WriteLine("x = " + x + "null in x = x + y");
        }
    }
}
