using System;

namespace ConsoleApp1.Events
{
    public class EventLogWriter : INotificationAction
    {
        public void ActOnNotification(string message)
        {
            Console.WriteLine(message);
        }
    }
}
