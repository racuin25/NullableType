using System;

namespace NullableType.Chapter01.Listing01_07
{
    public class Program
    {
        public static void Main()
        {
            double? x = 44.4;
            object iBoxed = x;
            // Access IConvertible interface implemented by double.
            IConvertible ic = (IConvertible)iBoxed;
            int i = ic.ToInt32(null);
            string str = ic.ToString();

            Console.WriteLine(str + " Casted");
        }
    }
}
