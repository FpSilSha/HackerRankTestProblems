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
            throw new Exception("Not Yet Implemented");
        }


        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = sockMerchant(n, ar);

           // textWriter.WriteLine(result);

           // textWriter.Flush();
           // textWriter.Close();
        }
    }
}
