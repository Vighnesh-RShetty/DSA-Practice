using System;
namespace Revison_First_.Arrays;


public class MaximumSubArraySum
{
    
    public static int MaximumSubArraySum_Kadanes(int[] arr)
    {

        int sum = 0;
        int maxSum = 0;

        for(int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];

            if (sum >= maxSum)
            {
                maxSum = sum;
            }
            if (sum < 0)
            {
                sum = 0;
            }
        }
        return maxSum;
    }
}
