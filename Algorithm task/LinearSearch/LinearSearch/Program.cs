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

            /* BOTH OF THE RESULT RETURN THE SAME OUTPUT 
             * the result of the number is 575154: 8677            the result of the number 45231 is : 638
             * the result of the number is 182339: 2694            the result of the number 580 is : 7  
             * the result of the number is 17132: 269             the result of the number 629822 is :9504
             * the result of the number is 296934:4451
             * the result of the number is 991395:14867
             * the result of the number is 303270:4537
             *  
                   */
            int theValue = 629822;  //the largest number

            Write($"\n\nthe reslut of a linearSearch search for {theValue} is : ");
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
