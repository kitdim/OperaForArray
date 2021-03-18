using System;
using System.Collections.Generic;
using System.Text;

namespace PascalTriangle
{

    class PascalTriangle
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Pascal Triangle Program");
            System.Console.Write("Enter the number of rows: ");
            string input = System.Console.ReadLine();

            int n = Convert.ToInt32(input);


            for (int y = 0; y < n; y++)
            {
                int c = 1;
                for (int q = 0; q < n - y; q++)
                {
                    System.Console.Write("   ");
                }

                for (int x = 0; x <= y; x++)
                {
                    System.Console.Write("   {0:D} ", c);
                    c = c * (y - x) / (x + 1);
                }
                System.Console.WriteLine();
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
        }
    }
}