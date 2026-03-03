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
            foreach (int i in setArray)
            {
                resArray[index++] = i;
            }
            return resArray;
        }

        //Method Two Is Im Thinking To Use Two Pointer

        public static int[] UnionOfArrayTwoPointerApproach(int[] arr1, int[] arr2)
        {
            int[] res = new int[arr1.Length + arr2.Length];

            int i = 0;
            int j = 0;
            int z = 0;

            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] == arr2[j])
                {
                    if (z == 0 || res[z - 1] != arr1[i])
                    {
                        res[z] = arr1[i];
                        z++;
                    }
                    i++; j++;
                }
                else if (arr1[i] > arr2[j])
                {
                    if (z == 0 || res[z - 1] != arr2[j])
                    {
                        res[z] = arr2[j];
                        z++;

                    }
                    j++;
                }
                else
                {
                    if (z == 0 || res[z - 1] != arr1[i])
                    {
                        res[z] = arr1[i];
                        z++;
                    }
                    i++;
                }
            }
                while (i < arr1.Length)
                {
                    if (z == 0 || res[z - 1] != arr1[i])
                    {
                        res[z] = arr1[i];
                        z++;
                    }
                    i++;
                }
                while (j < arr2.Length)
                {
                    if (z == 0 || res[z - 1] != arr2[j])
                    {
                        res[z] = arr2[j];
                        z++;
                    }
                    j++;
                }
            return res;
        }
            

        }
    }

