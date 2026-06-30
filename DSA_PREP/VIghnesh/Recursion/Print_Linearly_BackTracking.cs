using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Recursion;

public class Print_Linearly_BackTracking
{
    public void Print_Linearly_BackTracking_1_N(int i,int n)
    {

        if (i < 1) return;

        Print_Linearly_BackTracking_1_N(i - 1, n);
        Console.WriteLine("i value" + i);

    }
}
