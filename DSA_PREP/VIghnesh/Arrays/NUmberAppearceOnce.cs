using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays;

public class NumberAppearceOnce
{
    public static int NumAppearceOnce(int[] arr)
    {
        Dictionary<int,int> mapData = new Dictionary<int, int>();
        for(int i = 0; i < arr.Length; i++)
        {
            if (mapData.ContainsKey(arr[i])){
                mapData[arr[i]] = mapData[arr[i]]+1;
            }
            else
            {
                mapData.Add(arr[i],1);
            }
        }

        foreach(var item in mapData)
        {
            if (item.Value == 1)
            {
                return item.Key;
            }
        }
        return -1;
    }
    //Optimized Understod and did
    public static int NumAppearceOnceXOR(int[] arr)
    {

        int num = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            num = num ^ arr[i];
        }

        return num;
    }
}
