using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProblems
{
    class RepeatedString
    {
        /*
         Lilah has a string, s, of lowercase English letters that she repeated infinitely many times.
         Given an integer, n, find and print the number of letter a's in the first n letters of Lilah's infinite string.
         For example, if the string s='abcac' and n=10, the substring we consider is abcacabcac, the first 10 characters of her infinite string. 
         There are 4 occurrences of a in the substring.
         
         Complete the repeatedString function in the editor below. 
         It should return an integer representing the number of occurrences of a in the prefix of length n in the infinitely repeating string.
         repeatedString has the following parameter(s):
            s: a string to repeat
            n: the number of characters to consider
         
         Input Format:
            The first line contains a single string, s. 
            The second line contains an integer, n.
         
         

         
        */
        // Complete the repeatedString function below.
        static long repeatedString(string s, long n)
        {
            long numberOfRepeats = 0;


            return numberOfRepeats;
        }


        public void Run()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

    }
}
