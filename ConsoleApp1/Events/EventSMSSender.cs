using System;

namespace ConsoleApp1.Events
{
    class EventSMSSender : INotificationAction
    {
        public void ActOnNotification(string message)
        {
            // wysyłanie wiadomości sms do administratora
            Console.WriteLine("EventSMSSender: " + message);
        }
    }
}
