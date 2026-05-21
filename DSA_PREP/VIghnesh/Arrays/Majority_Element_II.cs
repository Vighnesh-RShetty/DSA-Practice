using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays
{
    public class Majority_Element_II
    {

        public static List<int> MajorityEle()
        {

            //Input: nums = [1, 2, 1, 1, 3, 2, 2]
            //Output: [1, 2]
            //Here, n / 3 = 7 / 3 = 2.
            int[] arr = [1, 2, 1, 1, 3, 2, 2];
            List<int> majorEle = new();
            Dictionary<int, int> dicArray = new();

            for (int i = 0; i < arr.Length; i++)
            {
                if (dicArray.ContainsKey(arr[i]))
                {
                    dicArray[arr[i]] += 1;
                    if (dicArray[arr[i]] > arr.Length / 3)
                    {
                        majorEle.Add(arr[i]);
                    }
                }
                else
                {
                    dicArray.Add(arr[i],1);
                }
            }
            return majorEle;
        }
     }
}
