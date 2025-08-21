using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsApp
{
    public delegate void Notify(string message);

    public class EventPublisher
    {
        // Declare the event using the delegate
        //The On prefix makes it immdeiately clear that this is an event.
        public event Notify OnNotify;
        // Method to raise the event
        public void RaiseEvent(string message)
        {
            OnNotify?.Invoke(message);//Invoke the event if there are any subscribers
        }
    }

    // A subscriber class that listens to the event
    public class EventSubscriber
    {
        // Method that matches the delegate signature
        public void OnEventRaised(string message)
        {
            Console.WriteLine($"Event received: {message}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            EventPublisher publisher = new EventPublisher();
            EventSubscriber subscriber = new EventSubscriber();
            publisher.OnNotify += subscriber.OnEventRaised; // Subscribe to the event
            publisher.RaiseEvent("Test");

            Console.ReadKey();
        }
    }
}
