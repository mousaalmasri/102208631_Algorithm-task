using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            String file = "sourted_Number.txt";
            StreamReader dataStream = new StreamReader(file);
            string datasample;
            int[] x = new int[15000];
            int k = 0;
            while ((datasample = dataStream.ReadLine()) != null)
            {
                x[k] = Int32.Parse(datasample);
                k++;
            }
            int theValue = 992406;  //the largest number

            Write($"\n\nthe reslut of a binary search for {theValue} is : ");
            WriteLine(linearSearch(x, theValue));

            ReadLine();

        }
        static int linearSearch(int[] a, int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
