using DSA_PREP.VIghnesh.SystemDesign.ObserverDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.SystemDesign.ObserverDesignPattern.ImplClasses.ObservableImpl
{
    public class ProducStock : IObservable
    {
        private List<IObserver> observers = new();
        private int stockCount = 0;

        public void AddObservers(IObserver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObservers(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObserver()
        {
            foreach(var observer in observers)
            {
                observer.Update();
            }
        }
        public void SetStock(int newStock)
        {
            stockCount = newStock;
            if(stockCount > 0 )
            {
                NotifyObserver();
            }
        }
        
    }
}
