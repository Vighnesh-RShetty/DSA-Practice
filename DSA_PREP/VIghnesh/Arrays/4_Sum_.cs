using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays
{
    public class _4_Sum_
    {

        public static List<List<int>> Four_Sum_Problem()
        {
            int[] nums = [4, 1, 2, -1, 1, -3, 5, 0, 2, -2, 3, 3, -1, 4];
            int target = 6;
            Array.Sort(nums);
            List<List<int>> resultArray = new();

            for(int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                 
                for(int j = i + 1; j < nums.Length; j++)
                {
                    int k = j + 1;
                    int l = nums.Length - 1;
                    if (j > i + 1 && nums[j] == nums[j - 1]) continue;

                    while (k < l)
                    {
                        long sum = nums[i] + nums[j];
                        sum += nums[k];
                        sum += nums[l];

                        if(sum < target)
                        {
                            k++;
                        }
                        else if(sum > target)
                        {
                            l--;
                        }
                        else
                        {
                            List<int> temp = [nums[i], nums[j], nums[k],nums[l]];
                            resultArray.Add(temp);
                            k++;l--;
                            while (k < l && nums[k] == nums[k - 1]) k++; ;
                            while (k < l && nums[l] == nums[l + 1]) l--;
                        }
                    }
                }
            }
            return resultArray;
        }
    }
}
