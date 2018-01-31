using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorLib;

namespace CalculatorCon
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ia01 = Calculator.generateArray(10);
            int[] ia02 = Calculator.generateArray(5, 1000);
            Console.Write("ia01) ");
            Calculator.writeOut(ia01);
            Console.Write("ia02) ");
            Calculator.writeOut(ia02);
            Console.WriteLine("============================");
            Console.Write("ia01) ");
            Calculator.writeOutBackward(ia01);
            Console.Write("ia02) ");
            Calculator.writeOutBackward(ia02);
            Console.WriteLine("============================");
            Console.Write("ia01) ");
            Console.WriteLine("Length: " + Calculator.processLength(ia01));
            Console.Write("ia02) ");
            Console.WriteLine("Length: " + Calculator.processLength(ia02));
            Console.WriteLine("============================");
            Console.Write("ia01) ");
            Console.WriteLine("Sum: " + Calculator.processSum(ia01));
            Console.Write("ia02) ");
            Console.WriteLine("Sum: " + Calculator.processSum(ia02));
            Console.WriteLine("============================");
            Console.Write("ia01) ");
            Console.WriteLine("Average: " + Calculator.processArAverage(ia01));
            Console.Write("ia02) ");
            Console.WriteLine("Average: " + Calculator.processArAverage(ia02));
            Console.WriteLine("============================");
            Console.Write("ia01) ");
            Console.WriteLine("Max: " + Calculator.processMax(ia01));
            Console.Write("ia02) ");
            Console.WriteLine("Max: " + Calculator.processMax(ia02));
            Console.WriteLine("============================");
            Console.Write("ia01) ");
            Console.WriteLine("Min: " + Calculator.processMin(ia01));
            Console.Write("ia02) ");
            Console.WriteLine("Min: " + Calculator.processMin(ia02));
            Console.WriteLine("============================");
            Console.Write("ia01) ");
            Calculator.writeOut(Calculator.processSortAscensional(ia01));
            Console.Write("ia02) ");
            Calculator.writeOut(Calculator.processSortAscensional(ia02));
            Console.WriteLine("============================");
            Console.Write("ia01) ");
            Console.Write("Search: ");
            int ih01 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Search("+ih01+"): " + Calculator.processSearchFor(ia01, ih01));
            Console.Write("ia02) ");
            Console.Write("Search: ");
            int ih02 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Search(" + ih02 + "): " + Calculator.processSearchFor(ia02, ih02));
            Console.WriteLine("============================");
            double[,] da2d01 = Calculator.generateArray2D(4, 6);
            Console.WriteLine("da2d01) ");
            Calculator.writeOut(da2d01);



            Console.WriteLine("=================================\n=================================");

            double[,] da2d02 = { {1.1, 2.2, 3.3}, {4.4, 5.5, 6.6}, {7.7, 8.8, 9.9}, {10.1, 11.1, 12.1} };
            Calculator.writeOut(da2d02);
            Console.WriteLine("da2d02) Length: " + da2d02.Length);
            Console.WriteLine("da2d02) rowCount: " + da2d02.GetLength(0));
            Console.WriteLine("da2d02) columnCount: " + da2d02.GetLength(1));

            Console.Read();
        }
    }
}
