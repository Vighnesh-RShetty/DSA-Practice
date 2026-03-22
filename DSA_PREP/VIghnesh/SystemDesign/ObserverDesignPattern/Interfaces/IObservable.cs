using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.SystemDesign.ObserverDesignPattern.Interfaces
{
    public interface IObservable
    {
        void AddObservers(IObserver observer);
        void RemoveObservers(IObserver observer);
        void NotifyObserver();

    }
}
