using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProblems
{
    class PlusMinus
    {
        /*
          
          Given an array of integers, calculate the fractions of its elements that are positive, negative, and are zeros.
          Print the decimal value of each fraction on a new line.
          This challenge introduces precision problems. 
          The test cases are scaled to six decimal places, though answers with absolute error of up to 10^4  are acceptable.
          
          You must print the following  lines:

          decimal representing of the fraction of positive numbers in the array compared to its size.
          decimal representing of the fraction of negative numbers in the array compared to its size.
          decimal representing of the fraction of zeros in the array compared to its size.


         */
        static void plusMinus(int n, int[] arr)
        {
            int positives = 0;
            int zeroes = 0;
            int negatives = 0;
            for(int i = 0; i < n; i++)
            {
                if(arr[i] > 0)
                {
                    positives++;

                }
                else if (arr[i] < 0)
                {
                    negatives++;
                }
                else
                {
                    zeroes++;
                }

            }
            
           Console.WriteLine(Math.Round(((double)positives / n), 6).ToString("0.000000"));
           
           Console.WriteLine(Math.Round(((double)negatives / n), 6).ToString("0.000000"));
           Console.WriteLine(Math.Round(((double)zeroes / n), 6).ToString("0.000000"));
           Console.ReadKey();
        }

        public void Run()
        {

            //int n = Convert.ToInt32(Console.ReadLine());
            //Test Case
             int n = 6;
            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            //Test Case
            int[] arr = new int[6]{-4,3,-9,0,4,1};

            plusMinus(n, arr);
        }
    }
}

