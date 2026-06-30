using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Recursion;

public class ReverseArray_Through_Recursion
{
    //Recursion on the array
    public  void Reverse_Array(int[] arr,int start,int end)
    {
        if (start >= end) return;

        int temp = arr[start];
        arr[start] = arr[end];
        arr[end] = temp;
        start++;end--;

        Reverse_Array(arr, start, end);
    }
    //Recursion on the check palindrome
    public bool CheckPalindrome_Recursion(string strt , int i)
    {
        if (i>=(strt.Length-1)/2) return true;

        if (strt[i] != strt[strt.Length-i-1])
        {
            return false;
        }
        return CheckPalindrome_Recursion(strt, i+1);
    }

    public void PrintAllSubSequence(int[] arr, List<int> list, int index)
    {
        if(index >= arr.Length) {
            Console.WriteLine(string.Join(" ", list));
            return; 
        }
        
        list.Add(arr[index]);

        PrintAllSubSequence(arr, list, index + 1);

        // Backtrack
        list.RemoveAt(list.Count - 1);
        PrintAllSubSequence(arr, list, index + 1);
    }

    public void PrintAllSubSequenceSumEqulasK(int[] arr,int target ,List<int> list, int index, int sum)
    {
        if (index >= arr.Length)
        {
            if (target == sum)
            {
                Console.WriteLine(string.Join(" ", list));
            }
            return;
        }

        list.Add(arr[index]);
        //sum += arr[index];
        PrintAllSubSequenceSumEqulasK(arr, target,list, index + 1,sum);

        // Backtrack
        list.RemoveAt(list.Count - 1);
        //sum -= arr[index];
        PrintAllSubSequenceSumEqulasK(arr, target,list, index + 1,sum);
    }

    public bool PrintAllSubSequenceSumEqulasKOne(int[] arr, int target, List<int> list, int index, int sum)
    {
        if (index >= arr.Length)
        {
            if (target == sum)
            {
                
                    Console.WriteLine(string.Join(" ", list));
                return true;
            }
            else
            {
                return false;
            } 
        }

        list.Add(arr[index]);
        //sum += arr[index];
        if(PrintAllSubSequenceSumEqulasKOne(arr, target, list, index + 1, sum)==true) return true;

        // Backtrack
        list.RemoveAt(list.Count - 1);
        //sum -= arr[index];
       if( PrintAllSubSequenceSumEqulasKOne(arr, target, list, index + 1, sum)==true) return true;

        return false;
    }

    public int CountAllSubSequenceSumEqulasK(int[] arr, int target, int index, int sum)
    {
        if (index >= arr.Length)
        {
            if (target == sum)
            {
                return 1;
            }
            return 0;
        }

        //list.Add(arr[index]);
        //sum += arr[index];
       int l =  CountAllSubSequenceSumEqulasK(arr, target,  index + 1, sum);

        // Backtrack

      //  list.RemoveAt(list.Count - 1);

        //sum -= arr[index];
       int r= CountAllSubSequenceSumEqulasK(arr, target, index + 1, sum);
        return l + r;
    }
}
