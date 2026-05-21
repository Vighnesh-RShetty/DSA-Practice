using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DSA_PREP.VIghnesh.Arrays.Revision_Part_Two_Last.Matrix;

public class Set_Matrix_Zero
{


//    Input: matrix =
//    [[1, 1, 1],
//    [1, 0, 1],
//    [1, 1, 1]]

//Output:
 //[[1, 0, 1],
//[0, 0, 0],
//[1, 0, 1]]

//Explanation:

//Element at position(1, 1) is 0, so set entire row 1 and column 1 to 0.

    public static void SetMatZero()
    {
        int[,] matrix = {
            { 1,1,1},
            { 1,0,1},
            { 1,1,1}
             };

        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        //int k = 0;

        bool[] zeroIndex = new bool[m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    zeroIndex[j] = true;
                }
            } 
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (zeroIndex[i] ||  zeroIndex[j])
                {
                    matrix[i, j] = 0;
                }
            }
        }
    } 
}
