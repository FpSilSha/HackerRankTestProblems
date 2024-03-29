﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProblems
{
    class JumpingOnTheClouds
    {
        /*
         Emma is playing a new mobile game that starts with consecutively numbered clouds. 
         Some of the clouds are thunderheads and others are cumulus. 
         She can jump on any cumulus cloud having a number that is equal to the number of the current cloud plus 1 or 2. 
         She must avoid the thunderheads. 
         Determine the minimum number of jumps it will take Emma to jump from her starting postion to the last cloud. 
         It is always possible to win the game.

         For each game, Emma will get an array of clouds numbered 0 if they are safe or 1 if they must be avoided. 
         For example, c = [0,1,0,0,0,1,0] indexed from 0...6. The number on each cloud is its index in the list so she must avoid the clouds at indexes 1 and 5. 
         She could follow the following two paths: 0->2->4->6  or 0->2->3->4->6 . The first path takes 3 jumps while the second takes 4.
         
         Complete the jumpingOnClouds function in the below.
         It should return the minimum number of jumps required, as an integer.

         jumpingOnClouds has the following parameter(s):

            c: an array of binary integers
         The first line contains an integer n, the total number of clouds. 
         The second line contains n space-separated binary integers describing clouds c[i] where 0<=i<n.

        */
        // Complete the jumpingOnClouds function below.
        static int jumpingOnClouds(int n, int[] c)
        {
            int movesMade = 0;
            int currentPlace = 0;
            int placePlusOne = 0;
            int placePlusTwo = 0;
            
            bool endReached = false;
            while (!endReached)
            {
                placePlusOne = currentPlace + 1;
                placePlusTwo = currentPlace + 2;
                if(currentPlace != (n-1))
                {
                    if((placePlusTwo != c.Count() && placePlusTwo != (c.Count() + 1) && c[placePlusTwo] != 1))
                    {
                        currentPlace = placePlusTwo;
                        movesMade++;
                    }
                    else
                    {
                        currentPlace = placePlusOne;
                        movesMade++;
                    }
                }
                else
                {
                    endReached = true;
                }
            }
            return movesMade;
        }

        public void Run()
        {
           // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());
            //Test case
            // int n = 7;
            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
            //Test case
            // int[] c = new int[] { 0, 0, 1, 0, 0, 1, 0 };
            int result = jumpingOnClouds(n, c);
            Console.WriteLine(result + " moves made");
            Console.ReadKey();
           // textWriter.WriteLine(result);

           // textWriter.Flush();
           // textWriter.Close();
        }


    }
}
