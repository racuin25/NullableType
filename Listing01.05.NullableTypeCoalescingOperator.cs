using System;

namespace NullableType.Chapter01.Listing01_05
{
    public class Program
    {
        public static void Main()
        {
            int? x = null;

            int y = x ?? 0;

            System.Console.WriteLine(y + " y is a 0 instead of null");
        }
    }
}
