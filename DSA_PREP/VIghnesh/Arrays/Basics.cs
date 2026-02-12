using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays
{
    public class Basics
    {
        public static void Run()
        {
            int[] array = new int[5];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;

            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

    }
}
