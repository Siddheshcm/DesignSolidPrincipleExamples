using ObserverPattern.Observable;
using ObserverPattern.Observer;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IStockObservable obj = new IphoneObservableImpl();
            INotificationObserver obj1 = new EmailNotifyObserverImpl("abc@gmail.com", obj);
            INotificationObserver obj2 = new EmailNotifyObserverImpl("abc@gmail.com", obj);
            INotificationObserver obj3 = new MobileNotifyObserverImpl("siddhesh", obj);

            obj.add(obj1);
            obj.add(obj2);
            obj.add(obj3);

            obj.setstockcount(10);

         
        }
    }
}