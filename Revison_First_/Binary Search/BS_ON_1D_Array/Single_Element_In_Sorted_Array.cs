
namespace Revison_First_.Binary_Search.BS_ON_1D_Array;

public class Single_Element_In_Sorted_Array
{

    public static int FIndSingle(int[] arr)
    {

        int low = 0;
        int high = arr.Length - 1;
        if (arr[low + 1] == arr[low]) low += 1; else return arr[low];

        if (arr[high - 1] == arr[high]) high -= 1; else return arr[high];

        while(low <= high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] != arr[mid + 1] && arr[mid] != arr[mid - 1]) return arr[mid];

            if((mid%2==1 && arr [mid - 1] == arr[mid]) || (mid%2==0 && arr[mid + 1] == arr[mid]))
                {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
            
        }
        return 0;

    }
}
