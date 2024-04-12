using ObserverPattern.Observer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observable
{
    internal interface IStockObservable
    {
        void add(INotificationObserver observer); 
        void remove(INotificationObserver observer);
        void notifysubscriber();
        void setstockcount(int newStockAdded);
        int getStockCount(INotificationObserver observer);

    }
}
