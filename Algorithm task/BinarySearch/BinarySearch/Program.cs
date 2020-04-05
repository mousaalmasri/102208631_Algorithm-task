using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BinarySearch
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

            /*
             * the result of the number is 575154: 8677            the result of the number is 45231: 638
             * the result of the number is 182339: 2694            the result of the number is 580: 7  
             * the result of the number is 17132: 269             the result of the number is 629822:9504
             * the result of the number is 296934:4451
             * the result of the number is 991395:14867
             * the result of the number is 303270:4537
             *  
                   */
            int theValue = 629822;  //the largest number 

            Console.Write($"\n\nthe reslut of a binary search for {theValue} is : ");
            Console.WriteLine(binarySearch(x, theValue));


            Console.ReadLine();


        }
        public static int binarySearch(int[] a, int x)
        {
            // step 1 intialize variables
            int p = 0; //beginning of the rang
            int r = a.Length - 1; //the end of the rang aka last slot

            // step 2 we do something(search for our value
            while (p <= r) // we are still in the rang 
            {
                int q = (p + r) / 2;    //find midpoint 
                if (x < a[q])
                {
                    r = q - 1;      // set r to mid point we narrowed to 1st 
                                    //half of the array in the case x is lee
                                    // the data in slot q
                }
                else if (x > a[q])
                {
                    p = q + 1;
                }
                else
                {
                    return q;
                }
            }

            // step 3 indicate not found 
            return -1;
        }
    }
}
