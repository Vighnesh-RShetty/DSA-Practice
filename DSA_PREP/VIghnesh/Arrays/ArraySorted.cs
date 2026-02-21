using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays;

public class ArraySorted
{
    //Brute force
    public static  Boolean SortedArray(int[] nums)
    {
        Boolean isSorted = true;

        for(int i=0;i< nums.Length; i++)
        {
            for(int j=0;j< nums.Length; j++)
            {
                if (nums[i] > nums[j])
                {
                    return false;
                }
            }
            
        }
        return true;
    }

    //Optimal Solution

    public static Boolean SortedArrayOptimal(int[] nums)
    {
        for(int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < nums[i-1])
            {
                return false;
            }
        }
        return true;
    }

    ///Remove the dublicate element from the sorted array. Integer Array Sorted in non decending order
    //remove all the dublicate in-place so that each unique element appears only once.
    public static Boolean RemoveDublicateEle(int[] arr) {
        HashSet<int> set = new();

        for(int i = 1; i < arr.Length; i++)
        {
            set.Add(arr[i]);
        }
        Console.WriteLine("Set Data");
        foreach(int value in set ){
            Console.WriteLine("Set Data : "+value);
        }

        return true;
    }
}
