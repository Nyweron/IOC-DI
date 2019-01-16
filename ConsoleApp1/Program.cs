using System;
using ConsoleApp1.Events;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Without_IoC.IISAppPoolWatcher issapw = new Without_IoC.IISAppPoolWatcher();
            issapw.Notify("Example message without IoC");
            Console.WriteLine();

            With_IoC.IISAppPoolWatcherIoC issapwioc = new With_IoC.IISAppPoolWatcherIoC();
            issapwioc.Notify("Example message with IoC");
            Console.WriteLine();

            EventLogWriter writer = new EventLogWriter();
            With_IoC_DI.IISAppPoolWatcherIoC_DI watcher = new With_IoC_DI.IISAppPoolWatcherIoC_DI(writer);
            watcher.Notify("Example message with IoC and DI Log");

            EventEmailSender writer2 = new EventEmailSender();
            With_IoC_DI.IISAppPoolWatcherIoC_DI watcher2 = new With_IoC_DI.IISAppPoolWatcherIoC_DI(writer2);
            watcher.Notify("Example message with IoC and DI Email");

            EventSMSSender writer3 = new EventSMSSender();
            With_IoC_DI.IISAppPoolWatcherIoC_DI watcher3 = new With_IoC_DI.IISAppPoolWatcherIoC_DI(writer3);
            watcher.Notify("Example message with IoC and DI Sms");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
