using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.TwoDimension_Array;

public class Merge_Intervals
{
    public static void Merge_Interval_Brute()
    {
       // int[,] mergeInterval = { { 1, 3 }, { 2, 6 }, { 8, 9 }, { 9, 11 }, { 8, 10 }, { 2, 4 }, { 15, 18 }, { 16, 17 } };

         List<List<int>> intervals = new()
        {
            new List<int> { 1, 3 },
            new List<int> { 2, 6 },
            new List<int> { 8, 9 },
            new List<int> { 9, 11 },
            new List<int> { 8, 10 },
            new List<int> { 2, 4 },
            new List<int> { 15, 18 },
            new List<int> { 16, 17 }
        };

        // int n = mergeInterval.GetLength(0);
        //int m = mergeInterval.GetLength(1);

        intervals.Sort((a, b) =>
        {
            if (a[0] != b[0])
            {
                return a[0].CompareTo(b[0]);
            }
            else
            {
                return a[1].CompareTo(b[1]);
            }
        });

        List<int> tempInterval = new(intervals[0]);
        List<List<int>> result = new();
       for(int i = 1; i < intervals.Count; i++)
        {
            int currentStart = intervals[i][0];
            int currentEnd = intervals[i][1];

            if (currentStart <= tempInterval[1])
            {
                if(currentEnd > tempInterval[1])
                {
                    tempInterval[1] = currentEnd;
                }
            }
            else
            {
                result.Add(tempInterval);
                tempInterval = new List<int>(intervals[i]);
            }
           
        }
        result.Add(tempInterval);
        Console.WriteLine(result);
    }

    public static void Merge_Interval_Optimal()
    {
        List<List<int>> intervals = new()
        {
            new List<int> { 1, 3 },
            new List<int> { 2, 6 },
            new List<int> { 8, 9 },
            new List<int> { 9, 11 },
            new List<int> { 8, 10 },
            new List<int> { 2, 4 },
            new List<int> { 15, 18 },
            new List<int> { 16, 17 }
        };

        intervals.Sort((a, b) =>
        {
            if (a[0] != b[0])
            {
               return a[0].CompareTo(b[0]);
            }
            else
            {
              return  a[1].CompareTo(b[1]);
            }
        });

        List<List<int>> result = new();

        for (int i = 0; i < intervals.Count; i++)
        {
            if (result != null || intervals[i][0] > intervals[i-1][0])
            {
                result.Add(intervals[i]);
            }
            else
            {
                
            }
        }
     }
}
