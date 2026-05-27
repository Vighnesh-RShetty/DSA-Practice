using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays;

public class Three_Sum
{

    public static List<List<int>> Three_Sum_Array()
    {
        // Input: nums = [2, -2, 0, 3, -3, 5]
        // Output: [[-2, 0, 2], [-3, -2, 5], [-3, 0, 3]]
        int[] arr = [2, -2, 0, 3, -3, 5];
        List<List<int>> listArray = new();

        int i = 0;
        int j = i + 1;
        int k = j + 1;

        while (k < arr.Length)
        {
            if (arr[i] + arr[j] + arr[k] == 0)
            {
                listArray.Add([arr[i], arr[j], arr[k]]);

            }
            i = j;
            j = k;
            k++;
        }
        return listArray;
    }

    //Brute Force
    public static List<List<int>> Three_Sum_Array_Brute()
    {
        // Input: nums = [2, -2, 0, 3, -3, 5]
        // Output: [[-2, 0, 2], [-3, -2, 5], [-3, 0, 3]]
        int[] arr = [2, -2, 0, 3, -3, 5];
        List<List<int>> listArray = new();
        HashSet<string> set = new HashSet<string>();

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                for (int k = j + 1; k < arr.Length; k++)
                {
                    if (arr[i] + arr[j] + arr[k] == 0)
                    {
                        List<int> temp = new();
                        temp.Sort();
                        String key = string.Join(",", temp);
                        if (!set.Contains(key))
                        {
                            set.Add(key);
                            listArray.Add(temp);
                        }


                    }
                }
            }
        }

        return listArray;
    }

    public static List<List<int>> Three_Sum_Array_Better()
    {
        int[] arr = [-4, -1, -1, -1, 0, 1, 2, 2, 2, 3, -2];
        List<List<int>> listArray = new();
        HashSet<string> dubSet = new();

        for (int i = 0; i < arr.Length; i++)
        {
            HashSet<int> set = new();
            for (int j = i+1; j < arr.Length; j++)
            {
                int k = -(arr[i] + arr[j]);
                if (set.Contains(k))
                {
                    List<int> temp = [arr[i] ,arr[j],k];
                    temp.Sort();

                    string key = string.Join(",", temp);

                    if (!dubSet.Contains(key)){
                        dubSet.Add(key);
                        listArray.Add(temp);
                    }
                }
                set.Add(arr[j]);
            }
        }
        return listArray;
    }

    public static List<List<int>> Three_Sum_Array_Optimal_Solution()
    {
        int[] arr = [-4, -1, -1, -1, 0, 1, 2, 2, 2, 3, -2];
        Array.Sort(arr);
        
        List<List<int>> listArray = new();

        for (int i = 0; i < arr.Length; i++)
        {
            
            if (i > 0 && arr[i] == arr[i - 1])
            {
                continue;
            }
            int k = arr.Length - 1;
           int j = i + 1;

            while (j < k)
            {
                int sum = arr[i] + arr[j] + arr[k];
                if(sum < 0)
                {
                    j++;
                }else if(sum > 0)
                {
                    k--;
                }
                else
                {
                    
                    List<int> temp = [arr[i], arr[j], arr[k]];
                    listArray.Add(temp);
                    j++; k--;
                    while (j < k && arr[j] == arr[j - 1]) j++;
                    while (j < k && arr[k] == arr[k - 1]) k--;
                }
            }

        }

        return listArray;
    }
}
