using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Recursion
{

    public class Print_From_N_1
    {

        public void Prinrt_N_To_1(int n)
        {
            if (n < 1) return;
            Console.WriteLine("N Values " + n--);
            Prinrt_N_To_1(n);
        }
    }
}
