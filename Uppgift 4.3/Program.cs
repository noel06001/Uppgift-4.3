using System;

namespace Uppgift_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "Meddelande";
            
            for (int i = x.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(x[i]);
            }
        }
    }
}
