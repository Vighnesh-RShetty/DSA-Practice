using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays;

public class Pascal_Triangle
{
    public static int PascalTriangle()
    {
        int r = 5;
        int k = 3;

        int n = r - 1;
        int m = k - 1;

        int result = 1;

        for(int i = 0; i < k; i++)
        {
            result = result * (n - i);
            result = result / (i + 1);
        }
        return result;
    }
}
