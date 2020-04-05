using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace shellSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //reading the file
            String file = "unsorted_numbers.csv";
            StreamReader dataStream = new StreamReader(file);
            string datasample;
         
           // put it in to an array 
            int[] x = new int[15000];
            int k = 0;
            while ((datasample = dataStream.ReadLine()) != null)
            {           
                x[k] = Int32.Parse(datasample);
                k++;
            }

            int n = x.Length;

            Console.WriteLine("\nOriginal Array Elements :");
            show_array_elements(x);
            shellSort(x, n);
            Console.WriteLine("\nSorted Array Elements :");
            show_array_elements(x);


            // new file for sorted number 
            string fileName = "Sorted_Number.txt";
            StreamWriter file2 = new StreamWriter(fileName);
            for (int newfile = 0; newfile < x.Length; newfile++)
            {
                file2.WriteLine(x[newfile]);
            }
            Console.ReadLine();

        }
        static void shellSort(int[] arr, int array_size)
        {
            int i, j, inc, temp;
            inc = 3;
            while (inc > 0)
            {
                for (i = 0; i < array_size; i++)
                {
                    j = i;
                    temp = arr[i];
                    while ((j >= inc) && (arr[j - inc] > temp))
                    {
                        arr[j] = arr[j - inc];
                        j = j - inc;
                    }
                    arr[j] = temp;
                }
                if (inc / 2 != 0)
                    inc = inc / 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
            }
            
        }
        static void show_array_elements(int[] arr)
        {
            foreach (var element in arr)
            {
                Console.Write("\n" + element + " ");
            }
            Console.Write("\n");

        }
    }
}
