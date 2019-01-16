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
                Console.WriteLine("Log IoC: " + message);
            }
        }

        class EmailSenderIoC : INotificationAction
        {
            public void ActOnNotification(string message)
            {
                Console.WriteLine("EmailSenderIoC: " + message);
            }
        }

        class SMSSenderIoC : INotificationAction
        {
            public void ActOnNotification(string message)
            {
                Console.WriteLine("SMSSenderIoC: " + message);
            }
        }
    }
}
