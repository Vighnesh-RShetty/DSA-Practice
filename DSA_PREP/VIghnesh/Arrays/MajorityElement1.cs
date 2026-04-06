using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays
{
    public class MajorityElement1
    {
        public static int MajorityElement(int[] arr)
        {
            int n = arr.Length / 2;
            Dictionary<int, int> dictionaryEle = new();

         
            for(int i = 0; i < arr.Length; i++)
            {
                if (dictionaryEle.ContainsKey(arr[i]))
                    dictionaryEle[arr[i]]++;
                else
                    dictionaryEle.Add(arr[i], 1);
                if(dictionaryEle.ContainsKey(arr[i]) && dictionaryEle[arr [i]] > n)
                {
                   return  arr[i];
                }
            }
            return -1;
        }
    }
}
