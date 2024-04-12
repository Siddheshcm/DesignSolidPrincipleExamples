using ObserverPattern.Observable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observer
{
    internal class EmailNotifyObserverImpl : INotificationObserver
    {
        string emailId;
        IStockObservable Observable;
        public EmailNotifyObserverImpl(string emailId, IStockObservable Observable)
        {
            this.emailId = emailId;
            this.Observable = Observable;
        }
        public void update()
        {
            sendMail(emailId, "Product is available");
        }
        public void sendMail(string emailId, String msg)
        {
            Console.WriteLine($"Mail sent to {emailId} with text {msg}");
        }
    }
}
