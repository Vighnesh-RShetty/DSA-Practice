using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.TwoDimension_Array;

public class Set_Matrix_Zeroes
{

    public static void SetMatrixZero()
    {
        //[[1,1,1],[1,0,1],[1,1,1]]
        int[,] matrix = 
            { 

            { 1, 1, 1 }, 
            { 1, 0, 1 },
            { 1, 1, 1 }
        };


        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        bool[] rowZero = new bool[rows];
        bool[] colZero = new bool[cols];


        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                if (matrix[i,j] == 0)
                {
                    rowZero[i] = true;
                    colZero[j] = true;
                }
            }
           
        }

        for( int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                if (rowZero[i] || colZero[j])
                {
                    matrix[i, j] = 0;
                }
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
