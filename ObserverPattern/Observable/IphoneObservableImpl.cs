using ObserverPattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observable
{
    internal class IphoneObservableImpl : IStockObservable
    {
        public List<INotificationObserver> lstObservers = new List<INotificationObserver>();
        public int stockCount = 0;
        public void add(INotificationObserver observer)
        {
            lstObservers.Add(observer);
        }
        public void remove(INotificationObserver observer)
        {
            lstObservers.Remove(observer);
        }
        public int getStockCount(INotificationObserver observer)
        {
            return stockCount;
        }
        public void notifysubscriber()
        {
           foreach (INotificationObserver observer in lstObservers)
            {
                observer.update();
            }
        }

        public void setstockcount(int newStockAdded)
        {
            if (stockCount == 0)
            {
                notifysubscriber();
            }
            stockCount = stockCount + newStockAdded;
        }
    }
}
