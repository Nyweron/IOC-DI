using System;

namespace ConsoleApp1
{
    public class With_IoC
    {
        public class IISAppPoolWatcherIoC
        {
            INotificationAction action = null;
            public void Notify(string message)
            {
                action = new EventLogWriterIoC();
                action.ActOnNotification(message);

                action = new EmailSenderIoC();
                action.ActOnNotification(message);

                action = new SMSSenderIoC();
                action.ActOnNotification(message);
            }
        }
        class EventLogWriterIoC : INotificationAction
        {
            public void ActOnNotification(string message)
            {
                // zapisywanie logów do pliku dziennika
                Console.WriteLine("Log IoC: " + message);
            }
        }

        class EmailSenderIoC : INotificationAction
        {
            public void ActOnNotification(string message)
            {
                // wysyłanie adresu email do administratora
                Console.WriteLine("EmailSenderIoC: " + message);
            }
        }
        class SMSSenderIoC : INotificationAction
        {
            public void ActOnNotification(string message)
            {
                // wysyłanie wiadomości sms do administratora
                Console.WriteLine("SMSSenderIoC: " + message);
            }
        }
    }
}
