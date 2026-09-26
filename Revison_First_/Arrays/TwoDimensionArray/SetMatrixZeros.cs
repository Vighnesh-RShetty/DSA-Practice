

using System.Text.Json.Serialization;

namespace Revison_First_.Arrays.TwoDimensionArray;

public class SetMatrixZeros
{

    public static void Set_Matrix_Zeros(int[][] matrixArray)
    {
        int row = matrixArray.Length;
        int col = matrixArray[0].Length;

        bool[] boolRow = new bool[row];
        bool[] boolCol = new bool[col];

        for (int i = 0; i < row; i++)
        {
            for(int j = 0; j < col; j++)
            {
                if (matrixArray[i][j] == 0)
                {
                    boolRow[i] = true;
                    boolCol[j] = true;
                    
                }
            }
        }

        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j < col; j++)
            {
                if (boolRow[i]==true || boolCol[j] == true)
                {
                    matrixArray[i][j] = 0;
                }
            }
        }
    }
}
