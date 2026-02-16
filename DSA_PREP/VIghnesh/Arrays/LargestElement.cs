using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays
{
    public class LargestElement
    {

        public static int LargeEelement(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static int SecondLargest(int[] arr)
        {
            int maxOne = arr[0];
            int maxSecond = arr[1];

            if (maxOne < maxSecond)
            {
                int temp = maxOne;
                maxOne = maxSecond;
                maxSecond = temp;
            }
            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] > maxOne)
                {
                    int temp = maxOne;
                    maxOne = arr[i];
                    maxSecond = temp;

                }else if (arr[i]>maxSecond && arr[i] < maxOne)
                {
                    maxSecond = arr[i];
                }
            }
            return maxSecond;
        }

        //public static void Main(string[] args)
        //{
        //    int[] arr = { 3, 4, 9, 8, 10 };
        //    LargestElement largset = new LargestElement();
        //   largset.LargeEelement(arr);
        //}

    }
}
