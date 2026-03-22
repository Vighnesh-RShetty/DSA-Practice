using DSA_PREP.VIghnesh.SystemDesign.ObserverDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.SystemDesign.ObserverDesignPattern.ImplClasses.ObserverImpl
{
    public class SmsNotification : IObserver
    {
        public void Update()
        {
            Console.WriteLine("SMS Sent : New Stocks Arrive -> Please Check It Out");
        }
    }
}
