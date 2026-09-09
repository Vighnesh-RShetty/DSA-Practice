
namespace Revison_First_.Arrays;

public class TwoSum
{

    public static int[] TwoSumProblem(int[] arr,int k)
    {
        Dictionary<int, int> twoSumDic = new();

        twoSumDic[arr[0]] = 0;

        for(int i = 1; i < arr.Length; i++)
        {
            if (twoSumDic.ContainsKey(k - arr[i])){
                return [twoSumDic[(k-arr[i])], i];
            }
            else
            {
                twoSumDic.Add(arr[i],i);
            }
        }
        return [-1, -1];
    }
}
