
namespace DSA_PREP.VIghnesh.Arrays.Binary_Search.Binary_Search_On_Answers;

public class Kth_Missing_Positive_Number
{

    public static int BruteForcce(int[] arr,int k)
    {
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] <= k) k++;
            else break;
        }
        return k;
    
    }

    public static int OptimalSolutionBinarySearch(int[] arr, int k)
    {
        int low = 0;
        int high = arr.Length - 1;

        int missingNumber = 0;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

             missingNumber = arr[mid] - (mid + 1);

            if(missingNumber < k)
            {

                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        // return arr[high] + (k - (arr[high]-(high+1))); (I Will get index out of bound issue)

       return low + k;
    }
}
