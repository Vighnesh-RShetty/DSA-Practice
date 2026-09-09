
using System.Security.Cryptography;
namespace Revison_First_.Arrays;

public class Next_Permutations
{
    // Input:  [1, 4, 3, 2]
    public static void NextPerm(int[] arr)
    {

        int index = -1;

        for(int i = arr.Length - 2; i >= 0; i--)
        {
            if (arr[i] < arr[i + 1])
            {
                index = i;
                break;
            }
        }

        // No next permutation
        if (index == -1)
        {
            ReverseArray(arr, 0, arr.Length - 1);
            return;
        }

        for (int i = arr.Length - 1; i>index; i--)
        {
            if (arr[i] > arr[index])
            {
                int temp = arr[i];
                arr[i] = arr[index];
                arr[index] = temp;
                break;
            }
        }

        ReverseArray(arr, index + 1, arr.Length - 1);
    }

    public static void ReverseArray(int[] arr,int start,int end)
    {
        while (start <= end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
    }
}
