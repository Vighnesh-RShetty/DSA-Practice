using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.TwoDimension_Array;

public class Print_Matrix_In_Spiral_Manner
{

    public static void PrintMatrixInSpiralManner()
    {
        int[,] matrix = {
             {1,2,3},
             { 4,5,6 },
             { 7,8,9 },
        };

        int[] arr = new int[matrix.GetLength(0) * matrix.GetLength(1)];

        Console.WriteLine(matrix.GetLength(0));
        Console.WriteLine(matrix.GetLength(1));
        int i = 0;
        int j = 0;
        int k = 0;
        while (j < matrix.GetLength(1))
        {
            arr[k++] = matrix[i, j];
            //j++;
        }
        i++;
        while(i <= j)
        {
            arr[k++] =  matrix[i, j];
            i++;
        }

        while (i == j)
        {
            arr[k++] = matrix[i, j];
            j--;
        }

        Console.WriteLine(arr); 
    }
}
