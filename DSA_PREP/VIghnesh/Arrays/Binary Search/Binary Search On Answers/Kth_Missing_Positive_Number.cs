
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

    //public static int OptimalSolutionBinarySearch(int[] arr,int k)
    //{

    //}
}
