using System;

namespace ConsoleApp1.Events
{
    class EventEmailSender : INotificationAction
    {
        public void ActOnNotification(string message)
        {
            // wysyłanie adresu email do administratora
            Console.WriteLine("EventEmailSender: " + message);
        }
    }
}
