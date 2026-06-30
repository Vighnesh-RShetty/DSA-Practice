using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Recursion;

public class  PrintName_FIve_Times
{
    int count = 1;
    public void PrintNames()
    {
        if (count > 5) return;

        Console.WriteLine("Name  " + "Vighnesh");
        count++;
        PrintNames();
    }

    }
