using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays
{
    public class UnionOfElements
    {

        // Solution One  Use HashSet Direclty

        public static int[] UnionOfUsingSet(int[] arr1, int[] arr2)
        {
            SortedSet<int> setArray = new SortedSet<int>();

            for (int i = 0; i < arr1.Length; i++)
            {
                setArray.Add(arr1[i]);
            }
            for (int j = 0; j < arr2.Length; j++)
            {
                setArray.Add(arr2[j]);
            }
            int n = setArray.Count;
            int[] resArray = new int[n];
            int index = 0;
            foreach(int i in setArray)
            {
                resArray[index++] = i;
            }
            return resArray;
        }

    }
}
