using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CalculatorLib
{
    public class Calculator
    {
        public static int[] generateArray(int count){
            return Calculator.generateArray(count, 100);
        }
        public static int[] generateArray(int count, int range){
            Random r = new Random();
            int[] array = new int[count];
            for (int i = 0; i < array.Length; i++)
                array[i] = r.Next(range);
            return array;
        }
        public static void writeOut(int[] array){
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }
        public static string writeOut(int[] array, String gui)
        {
            string s = "";
            for (int i = 0; i < array.Length; i++)
                s += array[i]+" ";
            return s;
        }
        public static void writeOutBackward(int[] array){
            Stack stack = new Stack();
        
            for (int i = 0; i < array.Length; i++)
                stack.Push(array[i]);
            for (int i = 0; i < array.Length; i++)
                Console.Write(stack.Pop() + " ");
            Console.WriteLine();
        }
        public static string writeOutBackward(int[] array, string gui)
        {
            Stack stack = new Stack();
            string s = "";
            for (int i = 0; i < array.Length; i++)
                stack.Push(array[i]);
            for (int i = 0; i < array.Length; i++)
                s+=stack.Pop() + " ";
            return s;
        }
        public static int processLength(int[] array){
            return array.Length;
        }
        public static int processLength(int[,] array)
        {
            return array.Length;
        }
        public static int processSum(int[] array){
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
                sum += array[i];
            return sum;
        }
        public static int processSum(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    sum += array[i,j];
            return sum;
        }
        public static double processArAverage(int[] array){
            return (double)Calculator.processSum(array) / (double)Calculator.processLength(array);
        }
        public static int processMax(int[] array){
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
                if (array[i] > max)
                    max = array[i];
            return max;
        }
        public static int processMin(int[] array){
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
                if (array[i] < min)
                    min = array[i];
            return min;
        }
        public static int[] processSortAscensional(int[] array){
            int[] arrayHelp = (int[])array.Clone();

            for (int i = 0; i < arrayHelp.Length - 1; i++)
                for (int j = 0; j < arrayHelp.Length - 1; j++)
                    if (arrayHelp[j] > arrayHelp[j + 1]){
                        int h = arrayHelp[j];
                        arrayHelp[j] = arrayHelp[j + 1];
                        arrayHelp[j + 1] = h;
                    }
            return arrayHelp;
        }
        public static bool processSearchFor(int[] array, int searchedInt){
            for (int i = 0; i < array.Length; i++)
                if (array[i] == searchedInt)
                    return true;
            return false;
        }
        public static double[,] generateArray2D(int rowCount, int columnCount){
            Random r = new Random();
            double[,] array2D = new double[rowCount, columnCount];
            for (int i = 0; i < rowCount; i++)
                for (int j = 0; j < columnCount; j++)
                    array2D[i, j] = r.NextDouble();
            return array2D;
        }
        public static void writeOut(double[,] array2D){
            for (int i = 0; i < array2D.GetLength(0); i++){
                for (int j = 0; j < array2D.GetLength(1); j++){
                    Console.Write(array2D[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static string writeOutGUI(double[,] array2D)
        {
            string s = string.Empty;
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    //Console.Write(array2D[i, j] + " ");
                    s += array2D[i, j] + "; "; 
                }
                //Console.WriteLine();
                s += Environment.NewLine;
            }
            return s;
        }
    }
}
