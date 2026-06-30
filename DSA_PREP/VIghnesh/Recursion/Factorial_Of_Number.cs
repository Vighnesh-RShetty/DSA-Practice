using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Recursion;

public class Factorial_Of_Number
{
    public void Print_Factorial_Number(int n, int factorial)
    {
        if(n<1)
        {
            Console.WriteLine(factorial);
            return;
        }

        Print_Factorial_Number(n - 1, factorial * n);
    }
}
