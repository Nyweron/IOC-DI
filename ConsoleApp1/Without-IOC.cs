using System;

namespace ConsoleApp1
{
    public class Without_IoC
    {
        public class IISAppPoolWatcher
        {
            EventLogWriter writer = null;
            EventSendEmail sm = null;
            public void Notify(string message)
            {
                writer = new EventLogWriter();
                writer.Write(message);

                sm = new EventSendEmail();
                sm.SendMail(message);
            }
        }

        class EventLogWriter
        {
            public void Write(string message)
            {
                // zapisywanie logów do pliku dziennika
                Console.WriteLine("Log: " + message);
            }
        }

        class EventSendEmail
        {
            public void SendMail(string message)
            {
                //wyslij email
                Console.WriteLine("EmailSender: " + message);
            }
        }
    }
}
