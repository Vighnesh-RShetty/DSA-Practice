
namespace Revison_First_.Arrays.TwoDimensionArray;

public class Rotate_Matrix_By_90_Degrees
{

    public static void RotateBy90(int[][] matrix)
    {
        int row = matrix.Length;
        int columns = matrix[0].Length;
        int n = matrix.Length;


        for(int i = 0; i < n; i++)
        {
            for(int j = i + 1; j < n; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }

        for(int i = 0; i < n; i++)
        {
            ReverseRow(matrix[i]);
        }

    }

    public static void ReverseRow(int[] arr)
    {
        int start = 0;  int end = arr.Length-1;

        while (start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;end--;
        }
    }
}
