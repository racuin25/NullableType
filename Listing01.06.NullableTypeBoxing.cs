using System;

namespace NullableType.Chapter01.Listing01_06
{
    public class Program
    {
        public static void Main()
        {
            bool? x = null;
            object boxedX = x;

            if (x == null)
            {
                Console.WriteLine(x + " x is True");
            }
            if (boxedX == null)
            {
                 Console.WriteLine(boxedX + " boxedX is True");
            }
        }
    }
}
