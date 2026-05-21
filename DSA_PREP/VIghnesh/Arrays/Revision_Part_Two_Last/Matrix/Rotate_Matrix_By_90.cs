using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Revision_Part_Two_Last.Matrix;

public class Rotate_Matrix_By_90
{

    public static void RotateMatrix()
    {

        // [[1, 2, 3], [4, 5, 6], [7, 8, 9]]
        int[,] matrix =
         {

            {1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }

        };

        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = i+1; j < matrix.GetLength(1); j++)
            {
                //int temp = matrix[i, j];
                //matrix[i, j] = matrix[j, i];
                //matrix[j, i] = temp;

                int temp = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = temp;
            }
        }

        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            int left = 0;
            int right = matrix.GetLength(0) - 1;

            while (left < right)
            {
                int temp = matrix[i, left];
                matrix[i, left] = matrix[i, right];
                matrix[i, right] = temp;

                left++;
                right--;
            }
        }
    }

}
