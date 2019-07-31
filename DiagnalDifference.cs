using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProblems
{
    class DiagnalDifference
    {
        /*
         
        Given a square matrix, calculate the absolute difference between the sums of its diagonals.

        For example, the square matrix arr is shown below:

        1 2 3
        4 5 6
        9 8 9  

        The left-to-right diagonal = 1+5+9=15. The right to left diagonal = 3+5+9 = 17. Their absolute difference is |15-17| = 2.


        Complete the  function in the editor below. It must return an integer representing the absolute diagonal difference.

        diagonalDifference takes the following parameter:

        arr: an array of integers .

        The first line contains a single integer, n, the number of rows and columns in the matrix arr. 
        Each of the next n lines describes a row, arr[i], and consists of n space-separated integers arr[i][j].

        */



        public int diagonalDifference(int n, List<List<int>> arr)
        {
            int fDia = 0;
            int sDia = 0;
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                fDia += arr[i][i];

            }
            for (int i = n - 1; i >= 0; i--)
            {
                
                sDia += arr[j][i];
                j++;
            }

            return Math.Abs(fDia - sDia);
        }




        public void Run()
        {
            // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int n = Convert.ToInt32(Console.ReadLine().Trim());
            //Test case
            int n = 3;
            List<List<int>> arr = new List<List<int>>();
            //Test case
            List<int> lineOne = new List<int> { 11, 2, 4 };
            List<int> lineTwo = new List<int> { 4, 5, 6 };
            List<int> lineThree = new List<int> { 10, 8, -12 };
            arr.Add(lineOne);
            arr.Add(lineTwo);
            arr.Add(lineThree);
            
            /*
            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }
            */
            int result = diagonalDifference(n, arr);
            Console.WriteLine(result);
            Console.ReadKey();
            // textWriter.WriteLine(result);

            // textWriter.Flush();
            // textWriter.Close();
        }



    }









}

