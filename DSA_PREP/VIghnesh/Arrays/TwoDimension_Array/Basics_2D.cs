using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.TwoDimension_Array
{
    public class Basics_2D
    {

        public static void BasicOperation()
        {
            //int[,] arrayMatrix = new int[3, 3];
            int[,] matrix = {
                             {1, 2, 3},
                             {4, 5, 6},
                             {7, 8, 9}
                         };

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j=0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine(matrix[i, j] + " ");
                    //Console.WriteLine("Rows Columns Data :" + count++);
                }
            }
        }
    }
}
