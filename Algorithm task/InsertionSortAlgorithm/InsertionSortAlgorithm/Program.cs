using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace InsertionSortAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {

            String file = "unsorted_numbers.csv";
            StreamReader dataStream = new StreamReader(file);
            string datasample;

            int[] x = new int[15000];
            int k = 0;
            while ((datasample = dataStream.ReadLine()) != null)
            {
                x[k] = Int32.Parse(datasample);
                k++;
            }



            Console.WriteLine("\nUnsorted Number :");
            PrintIntegerArray(x);
            Console.WriteLine("\nSorted Number :");
            PrintIntegerArray(InsertionSort(x));
            Console.WriteLine("\n");

            string fileName = "sortedNumber.txt";
            StreamWriter file2 = new StreamWriter(fileName);

            for (int newfile = 0; newfile < x.Length; newfile++)
            {
                file2.WriteLine(x[newfile]);
            }

            Console.ReadLine();

        }
        static int[] InsertionSort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            return inputArray;
        }
        public static void PrintIntegerArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write("\n" + i.ToString() + "  ");
            }
        }
    }
}
