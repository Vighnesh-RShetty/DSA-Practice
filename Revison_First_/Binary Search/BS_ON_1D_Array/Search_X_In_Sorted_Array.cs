
namespace Revison_First_.Binary_Search.BS_ON_1D_Array;

public class Search_X_In_Sorted_Array
{
    public static int SearchXInSorted(int[] arr, int target)
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] == target)
            {
                return mid;
            }else if (arr[mid] > target)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }

        }
        return -1;
    }
       
}
