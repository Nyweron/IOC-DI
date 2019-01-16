using System;

namespace ConsoleApp1
{
    public class Without_IoC
    {
        public class IISAppPoolWatcher
        {
            EventLogWriterWithoutIoc writer = null;
            EventSendEmailWithoutIoc sm = null;
            public void Notify(string message)
            {
                writer = new EventLogWriterWithoutIoc();
                writer.Write(message);

                sm = new EventSendEmailWithoutIoc();
                sm.SendMail(message);
            }
        }

        class EventLogWriterWithoutIoc
        {
            public void Write(string message)
            {
                Console.WriteLine("Log: " + message);
            }
        }

        class EventSendEmailWithoutIoc
        {
            public void SendMail(string message)
            {
                Console.WriteLine("EmailSender: " + message);
            }
        }
    }
}
