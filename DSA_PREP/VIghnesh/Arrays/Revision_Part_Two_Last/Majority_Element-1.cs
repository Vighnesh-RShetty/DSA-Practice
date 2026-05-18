using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DSA_PREP.VIghnesh.Arrays.Revision_Part_Two_Last;

public class Majority_Element_1
{
    public static int MajorityElement_1()
    {

        int[] nums = [7, 0, 0, 1, 7, 7, 2, 7, 7];
        //Output: 7
        //Explanation: The number 7 appears 5 times in the 9 sized array
        Dictionary<int, int> majorityDic = new();

        for(int i = 0; i < nums.Length; i++)
        {
            if (majorityDic[nums[i]] >= nums.Length/2) {
                return majorityDic[nums[i]];
            }

            else if (majorityDic.ContainsKey(nums[i]))
            {
                majorityDic[nums[i]]++;
            }
            else
            {
                majorityDic.Add(nums[i], i);
            }
        }
        return 0;
    }
}
