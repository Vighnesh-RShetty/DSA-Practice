
using System.Runtime.InteropServices.Marshalling;

namespace Revison_First_.Binary_Search.BS_ON_1D_Array;

public class Search_Insert_Position
{
    public static int SearchInsert(int[] arr ,int target)
    {
        int low = 0; int high = arr.Length - 1;
        int ans = 0;
        while (low <= high)
        {
            int mid = low +( high-low / 2);

            if (arr[mid] >= target)
            {
                ans = mid;
                high = mid - 1;

            }
            else
            {
                low = mid + 1;
            }
        }
        return ans;
    }
}
