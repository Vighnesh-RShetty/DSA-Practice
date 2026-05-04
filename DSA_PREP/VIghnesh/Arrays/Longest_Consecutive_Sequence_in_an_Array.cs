using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays
{
    public class Longest_Consecutive_Sequence_in_an_Array
    {

        public static int LongestCOnsewcutiveSequenceInArray()
        {
            int[] arr = [0, 3, 7, 2, 5, 8, 4, 6, 0, 1];
            //int count = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[j] == arr[i + 1])
            //        {
            //            count++;
            //        }
            //    }
            //}
            //return count;

            Dictionary<int, int> arryDictionary = new();
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (!arryDictionary.ContainsValue(arr[i]))
                {
                    arryDictionary.Add(i, arr[i]);
                }

                if (arryDictionary.ContainsValue(arr[i] - 1))
                {
                    count+=2;
                }

            }
            Console.WriteLine(count);
            return count;
        }
    }
    }

