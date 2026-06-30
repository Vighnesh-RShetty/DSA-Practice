using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Recursion;

public class Print_Linearly_1_N
{
    int count = 1;
    public void Print_1_N(int n)
    {

        if (count > n) return;

        Console.WriteLine("N Values"+ count++);
        Print_1_N(n);

    }
}
