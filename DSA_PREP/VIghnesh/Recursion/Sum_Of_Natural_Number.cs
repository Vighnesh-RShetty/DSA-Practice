using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Recursion;

public class Sum_Of_Natural_Number
{

    public void Print_Sum_Value(int n, int sum)
    {
        
        if(n==0)
        {
            Console.WriteLine("Sum"+sum);
            return;
        }
        Print_Sum_Value(n - 1,sum+n);
    }
}
