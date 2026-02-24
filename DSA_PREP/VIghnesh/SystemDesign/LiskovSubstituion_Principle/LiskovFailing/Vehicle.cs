using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.SystemDesign.LiskovSubstituion_Principle.LiskovFailing
{
    public class Vehicle
    {
        public virtual int GetNumberOfWheels()
        {
            return 2;
        } 
        public virtual Boolean? HasEngine()
        {
            return true;
        }
    }

    public class MotorCycle : Vehicle
    {

    }

    public class Car : Vehicle
    {
        public override int GetNumberOfWheels()
        {
            return 4;
        }
    }

    public class BiCycle : Vehicle
    {
        public override bool? HasEngine()
        {
            return null;
        }
    }

    public class MainClass
    {
        public static void LiskovMain(string[] args)
        {
            List<Vehicle> vehicleList = new();
            vehicleList.Add(new Car());
            vehicleList.Add(new BiCycle());
            vehicleList.Add(new MotorCycle());
           

            foreach (Vehicle vehicle in vehicleList)
            {
                Console.WriteLine(vehicle.HasEngine().ToString());
            }
        }
    }
}
