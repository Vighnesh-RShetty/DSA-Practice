

namespace Revison_First_.Arrays;

public class Sort_Array_0_1_2
{
    public static void Dutch_National_Algo(int[] arr)
    {
        //nums = [1, 0, 2, 1, 0]

        //       [0, 0, 1, 1, 2]

        int mid = 0;
        int low = 0;
        int high = arr.Length - 1;

        while (mid <= high)
        {
            if (arr[mid] == 0)
            {
                int temp = arr[mid];
                arr[mid] = arr[low];
                arr[low] = temp;
                mid++;
                low++;

            } else if (arr[mid] == 1)
            {
                mid++;
            }
            else
            {
                int temp = arr[high];
                arr[high] = arr[mid];
                arr[mid] = temp;
                high--;
                
            }
        }

    }
}
