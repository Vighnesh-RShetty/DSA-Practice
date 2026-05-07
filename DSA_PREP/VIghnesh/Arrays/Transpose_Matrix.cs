using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays;

public class Transpose_Matrix
{
    //Brute Force
    public static void Rotate_2D_Array()
    {
        int[,] matrix = { { 1 ,2 , 3, 4},
                          { 5 ,6 , 7, 8},
                          { 9 ,10, 11, 12},
                          { 13 ,14 , 15, 16}, };


        int[,] newMatrix = new int [matrix.GetLength(0), matrix.GetLength(1)];


        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                newMatrix[j, matrix.GetLength(0) - 1-i] = matrix[i, j];
            }
        }

        Console.WriteLine(newMatrix);
    }
    //Optimize Space
    public static void Roate_2D_Array_Optimized()
    {
        int[,] matrix = { { 1 ,2 , 3, 4},
                          { 5 ,6 , 7, 8},
                          { 9 ,10, 11, 12},
                          { 13 ,14 , 15, 16}, };

        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = i + 1; j < matrix.GetLength(1); j++)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = temp;

            }
        }

        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            int left = 0;
            int right = matrix.GetLength(0)-1;
            while (left < right)
            {
                int temp = matrix[i, left];
                matrix[i, left] = matrix[i, right];
                matrix[i,right] = temp;
                left++;
                right--;
            }
        }
    }
}
