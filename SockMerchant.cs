using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProblems
{
    class SockMerchant
    {
        /*
         John works at a clothing store. He has a large pile of socks that he must pair by color for sale.
         Given an array of integers representing the color of each sock,
         determine how many pairs of socks with matching colors there are.

         Complete the sockMerchant function in the editor below. 
         It must return an integer representing the number of matching pairs of socks that are available.
         sockMerchant has the following parameter(s):

            n: the number of socks in the pile
            ar: the colors of each sock

         The first line contains an integer n, the number of socks represented in ar . 
         The second line contains n space-separated integers describing the colors ar[i] of the socks in the pile.

         Sample Input:
         9
         10 20 20 10 10 30 50 10 20

         Sample Output:

         3
    */

        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {
            int numberOfPairs = 0;
            List<int> nums = ar.Distinct().ToList();
            foreach (int number in nums)
            {
                int repeats = 0;
                for (int i = 0; i < ar.Count(); i++)
                {
                    if (number == ar[i])
                    {
                        repeats++;
                    }
                }
                if (repeats == 1)
                {
                    repeats = 0;
                    continue;
                }
                if (repeats % 2 == 0)
                {
                    numberOfPairs += repeats / 2;
                }
                else
                {
                    numberOfPairs += ((repeats - 1) / 2);
                }
                repeats = 0;
            }
            

            return numberOfPairs;
        }


        public void Run()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());
            // Test case
            // int n = 10;
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            // Test case
            // int [] ar = [1,1,3,1,2,1,3,3,3,3];
            int result = sockMerchant(n, ar);
            Console.WriteLine(result + " number of pairs");
            Console.ReadKey();
           // textWriter.WriteLine(result);

           // textWriter.Flush();
           // textWriter.Close();
        }
    }
}
