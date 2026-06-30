using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Recursion;

public class BaseCondition
{
    int count = 0;
    public  void functionBaseCondition()
    {
        if (count > 5) return;
        Console.WriteLine("COunt Value" + count);
        count++;
        functionBaseCondition();
    }
}
