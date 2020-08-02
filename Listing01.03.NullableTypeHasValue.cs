using System;

namespace NullableType.Chapter01.Listing01_03
{
    public class Program
    {
        public static void Main()
        {
            int? x = null;

            if (x.HasValue)
            {
                System.Console.WriteLine(x + " i have a value");
            }
            else
            {
                System.Console.WriteLine(x + "i is a null");
            }
            
        }
    }
}
