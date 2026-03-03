using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.SystemDesign.LiskovSubstituion_Principle.LiskovSolution
{
    public abstract class  Vehicle
    {
        public int GetNumberOfWheels()
        {
            return 2;
        }
    }

    public interface Engine
    {
        public Boolean HasEngine();
    }

    public class Car : Vehicle, Engine
    {

        public int GetNumberOfWheels()
        {
            return 4;
        }
        public Boolean HasEngine()
        {
            return true;
        }
    }
}
