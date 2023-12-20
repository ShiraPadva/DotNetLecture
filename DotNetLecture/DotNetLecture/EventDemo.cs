using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLecture
{
    using System;

    public class EventDemo
    {
        public class MyEventArgs : EventArgs
        {
            public string Message { get; set; }
        }

        public class Publisher
        {
            // Declare an event with custom event data
            public event EventHandler<MyEventArgs> MyCustomEvent;

            public void DoSomething()
            {
                // Raise the event with custom data
                MyCustomEvent?.Invoke(this, new MyEventArgs { Message = "Something interesting happened!" });
            }
        }

        public class Subscriber
        {
            // Method to be executed when the event occurs
            public void HandleEvent(object sender, MyEventArgs e)
            {
                Console.WriteLine($"Event handled by Subscriber: {e.Message}");
            }
        }

        public static void Demo()
        {
            var publisher = new Publisher();
            var subscriber = new Subscriber();

            // Subscribe to the event
            publisher.MyCustomEvent += subscriber.HandleEvent;

            // Call a method that raises the event
            publisher.DoSomething(); // Output: Event handled by Subscriber: Something interesting happened!

            // Unsubscribe from the event
            publisher.MyCustomEvent -= subscriber.HandleEvent;
        }

    }

}
