
namespace Revison_First_.Arrays;

public class Count_Subarray_With_Given_Sum
{

    public static int CountSubArraySum(int[] arr,int k)
    {
        Dictionary<int, int> FrequencyCount = new Dictionary<int, int>();
        int count = 0;
        int prefixSum = 0;

        FrequencyCount[0] = 1;

        for(int i = 0; i < arr.Length; i++)
        {
            prefixSum+= arr[i];

            if (FrequencyCount.ContainsKey(prefixSum - k))
            {
                
               count += FrequencyCount[prefixSum - k];
            }

            if (!FrequencyCount.ContainsKey(prefixSum))
            {
                FrequencyCount[prefixSum] = 1;
            }
            else
            {
                FrequencyCount[prefixSum] ++;
            }
        }
        return count;
    }
}
