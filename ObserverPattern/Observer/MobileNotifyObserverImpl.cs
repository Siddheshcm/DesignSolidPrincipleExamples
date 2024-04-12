using ObserverPattern.Observable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observer
{
    internal class MobileNotifyObserverImpl : INotificationObserver
    {
        string Username;
        IStockObservable Observable;
        public MobileNotifyObserverImpl(string Username, IStockObservable Observable)
        {
            this.Username = Username;
            this.Observable = Observable;
        }
        public void update()
        {
            sendSMS(Username, "Product is available");
        }
        public void sendSMS(string Username, String sms)
        {
            Console.WriteLine($"SMS sent to {Username} with text {sms}");
        }
    }
}
