using DSA_PREP.VIghnesh.SystemDesign.ObserverDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.SystemDesign.ObserverDesignPattern.ImplClasses.ObserverImpl
{
    public class EmailNotification : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Email Sent : New Stocks Arrived --> Check Out");
        }
    }
}
