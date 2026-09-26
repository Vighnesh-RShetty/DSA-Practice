using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSA_PREP.VIghnesh.Arrays.Binary_Search.Binary_Search_On_Answers;

public class Gas_Station_Question
{
    public static double Gas_Station_Distance(int[] arr, int k)
    {

        //PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();

        PriorityQueue<(double distance,int index),double> priorityQueue = new();

        int[] tempArr = new int[arr.Length - 1];

        for (int j = 1; j < arr.Length; j++)
        {
            double distance = arr[j] - arr[j - 1];
            priorityQueue.Enqueue((distance, j-1),-distance);
        }

        for(int i =1; i <=k; i++)
         {
           var current = priorityQueue.Dequeue();

            tempArr[current.index]++;

            int originalDistance = arr[current.index + 1] - arr[current.index];

            double newDistance = (double)originalDistance / (tempArr[current.index] + 1);

            priorityQueue.Enqueue((newDistance, current.index), -newDistance);

            
         }
        var result = priorityQueue.Dequeue();
        return result.distance;
    }
     
}

